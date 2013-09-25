using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DBHelper;

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

                SqlDataAdapter da = new SqlDataAdapter("SELECT t.ID, u.Users as Фамилия, c.Name as Клиент, t.Date as Дата, t.TaskStatus as Статус " +
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
                    Convert.ToInt32(((System.Data.DataRowView)(taf.UserСomboBox.SelectedItem)).Row.ItemArray[0]), 
                    Convert.ToInt32(((System.Data.DataRowView)(taf.ClientComboBox.SelectedItem)).Row.ItemArray[0]), 
                    taf.DateTimePicker.Value.Date, status, taf.AboutRichTextBox.Text, cn);

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

                if (taf.ShowDialog() == DialogResult.OK)
                {
                    bool status;
                    status = taf.StatusComboBox.Text == "Открыт";

                    TaskDAL.UpdateTask(TaskDAL.GetID(cn),
                        Convert.ToInt32(((System.Data.DataRowView)(taf.UserСomboBox.SelectedItem)).Row.ItemArray[0]),
                        Convert.ToInt32(((System.Data.DataRowView)(taf.ClientComboBox.SelectedItem)).Row.ItemArray[0]),
                        taf.DateTimePicker.Value.Date, status, taf.AboutRichTextBox.Text, cn);

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
    }
}
