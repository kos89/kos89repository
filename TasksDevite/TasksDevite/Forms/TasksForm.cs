using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DBHelper;
using Google.GData.Calendar;
using Google.GData.Client;
using Google.GData.Extensions;
using System.Windows.Forms.Calendar;
using System.Collections.Generic;
using GlobalVars;

namespace TasksDevite
{
    public partial class TasksForm : Form
    {
        List<CalendarItem> _items = new List<CalendarItem>();

        public TasksForm()
        {
            InitializeComponent();
        }

        private void TasksForm_Load(object sender, EventArgs e)
        {   
            //calendar.ViewStart = DateTime.Now.AddDays( 1 - Convert.ToInt32(DateTime.Now.DayOfWeek));
            //calendar.ViewEnd = DateTime.Now.AddDays( + (7 - Convert.ToInt32(DateTime.Now.DayOfWeek)));
            GridReload(0);
        }

        private void GridReload(int id) //TODO ???
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                //GridReload
                cn = DBDevite.DBOpen();

                SqlDataAdapter da = new SqlDataAdapter("SELECT t.ID, u.Users as Фамилия, c.Name as Клиент, t.Date as Дата, t.TimeStart as Начало, t.TimeEnd as Конец, t.TaskStatus as Статус " +
                                                       "FROM tasks t " +
                                                       "LEFT JOIN users u ON t.userID = u.ID " + 
                                                       "LEFT JOIN clients c ON t.clientID = c.ID", cn);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewTask.DataSource = ds.Tables[0];
               // dataGridViewTask.Rows[id].Selected = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBDevite.DBClose(cn);
            }
            calendarReload();
        }

        private void calendarReload()
        {
            calendar.SetViewRange(monthView1.SelectionStart, monthView1.SelectionEnd);
            _items.Clear();
            SqlConnection cn = new SqlConnection();
            try
            {
                DateTime start, end;
                CalendarItem ci;
                cn = DBDevite.DBOpen();

                //Task
                SqlCommand command = new SqlCommand("SELECT u.Users, c.Name, t.Date, t.TimeStart, t.TimeEnd, t.TaskStatus " +
                                                    "FROM tasks t " +
                                                    "LEFT JOIN users u ON t.userID = u.ID " +
                                                    "LEFT JOIN clients c ON t.clientID = c.ID " +
                                                    "WHERE t.TaskStatus = 'true'", cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        start = Convert.ToDateTime(reader.GetDateTime(2).ToString("dd-MM-yyyy") + " " + reader.GetString(3).Trim() + ":00");
                        end = Convert.ToDateTime(reader.GetDateTime(2).ToString("dd-MM-yyyy") + " " + reader.GetString(4).Trim() + ":00");
                        ci = new CalendarItem(calendar, start, end, reader.GetString(1) + "/" + reader.GetString(0));
                        _items.Add(ci);
                    }
                    reader.NextResult();
                }

                foreach (CalendarItem item in _items)
                {
                    if (calendar.ViewIntersects(item))
                    {
                        calendar.Items.Add(item);
                    }
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
                GridReload(dataGridViewTask.RowCount);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTask.RowCount != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Удалить запись?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection();
                    cn = DBDevite.DBOpen();

                    TaskDAL.DeleteTask(Convert.ToInt32(dataGridViewTask[0, dataGridViewTask.CurrentRow.Index].Value), cn);

                    DBDevite.DBClose(cn);
                    GridReload(dataGridViewTask.RowCount - 2);
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewTask.RowCount != 0)
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

                        GridReload(focused - 2);
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service service = new Service("cl", "companyName-appName-1");
            service.setUserCredentials("task@devite.ru", "jWH>45bY1");
            EventEntry entry = new EventEntry();
            DataSet ds = new DataSet();
            When eventTimes = new When();
            DateTime start, end;
            AtomEntry insertedEntry;

            SqlConnection cn = new SqlConnection();
            try
            {
                cn = DBDevite.DBOpen();

                SqlDataAdapter da = new SqlDataAdapter("SELECT u.Users as userw, c.Name as client, t.Date as date, t.TimeStart as start, t.TimeEnd as endw, t.About as about, t.TaskStatus " +
                                                       "FROM tasks t " +
                                                       "LEFT JOIN users u ON t.userID = u.ID " + 
                                                       "LEFT JOIN clients c ON t.clientID = c.ID " +
                                                       "WHERE t.TaskStatus = 'true'", cn);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Fill(ds);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBDevite.DBClose(cn);
            }

            Uri postUri = new Uri("http://www.google.com/calendar/feeds/task@devite.ru/private/full");
            //запись в EventEntry
            foreach(DataTable thisTable in ds.Tables)
            {
                foreach(DataRow row in thisTable.Rows)
                {
                    entry.Title.Text = row["client"].ToString() + "  " + row["userw"].ToString();
                    entry.Content.Content = row["about"].ToString();

                    eventTimes.StartTime = Convert.ToDateTime(Convert.ToDateTime(row["date"].ToString()).ToString("dd-MM-yyyy") + " " + row["start"].ToString().Trim() + ":00");
                    eventTimes.EndTime = Convert.ToDateTime(Convert.ToDateTime(row["date"].ToString()).ToString("dd-MM-yyyy") + " " + row["endw"].ToString().Trim() + ":00");
                    entry.Times.Add(eventTimes);
                    insertedEntry = service.Insert(postUri, entry);
                }
            }
         }

        private void monthView1_SelectionChanged(object sender, EventArgs e)
        {
            calendar.SetViewRange(monthView1.SelectionStart, monthView1.SelectionEnd);
            calendarReload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TaskMonthForm tmf = new TaskMonthForm();
            if (tmf.ShowDialog() == DialogResult.OK)
            { 
                SqlConnection cn = new SqlConnection();
                try
                {
                    cn = DBDevite.DBOpen();

                    for(int i = 0; i < tmf.dataGridView.RowCount; i++)
                    {
                        if (tmf.dataGridView.Rows[i].Cells[tmf.ColumnAdd.Index].Value.ToString() == "True")
                            TaskDAL.InsertTask(TaskDAL.GetID(cn),
                                                GlobalVar.DctnrUsers[tmf.dataGridView.Rows[i].Cells[tmf.ColumnUser.Index].Value.ToString()],
                                                GlobalVar.DctnrClients[tmf.dataGridView.Rows[i].Cells[tmf.ColumnClient.Index].Value.ToString()],
                                                Convert.ToDateTime(tmf.dataGridView.Rows[i].Cells[tmf.ColumnDate.Index].Value),
                                                tmf.dataGridView.Rows[i].Cells[tmf.ColumnStart.Index].Value.ToString(),
                                                tmf.dataGridView.Rows[i].Cells[tmf.ColumnEnd.Index].Value.ToString(),
                                                true, "", cn);
                    }

                    GridReload(0);
                    calendarReload();
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
        }
    }
}
