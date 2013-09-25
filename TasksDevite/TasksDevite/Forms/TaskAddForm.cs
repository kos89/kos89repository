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
    public partial class TaskAddForm : Form
    {
        public TaskAddForm()
        {
            InitializeComponent();
        }

        private void TaskAddForm_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn = DBDevite.DBOpen();

                SqlDataAdapter da = new SqlDataAdapter("select * from users", cn);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);

                UserСomboBox.DataSource = ds.Tables[0];
                UserСomboBox.DisplayMember = "Users";
                UserСomboBox.ValueMember = "ID";
                ((System.Data.DataRowView)(UserСomboBox.SelectedItem)).Row.ItemArray[1].ToString()
                UserСomboBox.GetItemText(;

                da = new SqlDataAdapter("select * from clients", cn);
                cb = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);

                ClientComboBox.DataSource = ds.Tables[0];
                ClientComboBox.DisplayMember = "Name";
                ClientComboBox.ValueMember = "ID";
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
