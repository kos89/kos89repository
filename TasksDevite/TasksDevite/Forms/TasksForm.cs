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
    }
}
