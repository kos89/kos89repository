using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DBHelper;
using Google.GData.Calendar;
using Google.GData.Client;
using Google.GData.Extensions;

namespace TasksDevite
{
    public partial class TasksForm : Form
    {
        public TasksForm()
        {
            InitializeComponent();
        }

        private void TasksForm_Load(object sender, EventArgs e)
        {
            GridReload();
        }

        private void GridReload()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn = DBDevite.DBOpen();

                SqlDataAdapter da = new SqlDataAdapter("SELECT t.ID, u.Users as Фамилия, c.Name as Клиент, t.Date as Дата, t.TimeStart as Начало, t.TimeEnd as Конец, t.TaskStatus as Статус " +
                                                       "FROM tasks t " +
                                                       "LEFT JOIN users u ON t.userID = u.ID " + 
                                                       "LEFT JOIN clients c ON t.clientID = c.ID", cn);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewTask.DataSource = ds.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBDevite.DBClose(cn);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            TaskAddForm taf = new TaskAddForm();
            if (taf.ShowDialog() == DialogResult.OK)
            {
                bool status;
                status = taf.StatusComboBox.Text == "Открыт";

                SqlConnection cn = new SqlConnection();
                cn = DBDevite.DBOpen();
                
                TaskDAL.InsertTask(TaskDAL.GetID(cn),
                                   Convert.ToInt32(taf.UserСomboBox.SelectedValue), 
                                   Convert.ToInt32(taf.ClientComboBox.SelectedValue), 
                                   taf.DateTimePicker.Value.Date, 
                                   taf.TimeStartComboBox.Text,
                                   taf.TimeEndComboBox.Text,
                                   status,
                                   taf.AboutRichTextBox.Text, cn);

                DBDevite.DBClose(cn);
                GridReload();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить запись?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection cn = new SqlConnection();
                cn = DBDevite.DBOpen();

                TaskDAL.DeleteTask(Convert.ToInt32(dataGridViewTask[0, dataGridViewTask.CurrentRow.Index].Value), cn);

                DBDevite.DBClose(cn);
                GridReload();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int focused = Convert.ToInt32(dataGridViewTask[0, dataGridViewTask.CurrentRow.Index].Value);
            TaskAddForm taf = new TaskAddForm();
            SqlConnection cn = new SqlConnection();
            try
            {
                cn = DBDevite.DBOpen();

                DataSet dt = TaskDAL.GetFullRecord(focused, cn);
                taf.UserСomboBox.Text = dt.Tables[0].Rows[0]["Users"].ToString();
                taf.ClientComboBox.Text = dt.Tables[0].Rows[0]["Name"].ToString();
                taf.DateTimePicker.Value = Convert.ToDateTime(dt.Tables[0].Rows[0]["Date"].ToString());
                if (dt.Tables[0].Rows[0]["TaskStatus"].ToString() == "True")
                    taf.StatusComboBox.Text = "Открыт";
                else
                    taf.StatusComboBox.Text = "Закрыт";
                taf.AboutRichTextBox.Text = dt.Tables[0].Rows[0]["About"].ToString();
                taf.TimeStartComboBox.Text = dt.Tables[0].Rows[0]["TimeStart"].ToString();
                taf.TimeEndComboBox.Text = dt.Tables[0].Rows[0]["TimeEnd"].ToString();

                if (taf.ShowDialog() == DialogResult.OK)
                {
                    bool status;
                    status = taf.StatusComboBox.Text == "Открыт";

                    TaskDAL.UpdateTask(focused,
                        Convert.ToInt32(taf.UserСomboBox.SelectedValue),
                        Convert.ToInt32(taf.ClientComboBox.SelectedValue),
                        taf.DateTimePicker.Value.Date,
                        taf.TimeStartComboBox.Text,
                        taf.TimeEndComboBox.Text,
                        status, 
                        taf.AboutRichTextBox.Text, cn);

                    GridReload();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBDevite.DBClose(cn);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service service = new Service("cl", "companyName-appName-1");
            service.setUserCredentials("task@devite.ru", "jWH>45bY1");

            EventEntry entry = new EventEntry();
            AtomPerson author = new AtomPerson(AtomPersonType.Author);
            author.Name = "Kos";
            author.Email = "task@devite.ru";
            entry.Authors.Add(author);
            entry.Title.Text = "Кирилл хуил";
            entry.Content.Content = "Кирилл хуил!Кирилл хуил!";

            When eventTimes = new When();
            eventTimes.StartTime = DateTime.Parse("28/09/2013 12:00:00 PM");
            eventTimes.EndTime = DateTime.Parse("28/09/2013 13:00:00 PM");
            entry.Times.Add(eventTimes);

            Uri postUri = new Uri("http://www.google.com/calendar/feeds/task@devite.ru/private/full");

            // Send the request and receive the response:
            AtomEntry insertedEntry = service.Insert(postUri, entry);

        }
    }
}
