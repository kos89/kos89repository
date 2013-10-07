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
using GlobalVars;

namespace TasksDevite
{
    public partial class TaskAddForm : Form
    {
        public TaskAddForm()
        {
            InitializeComponent();
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

        private bool check()
        {
            if (GlobalVar.DctnrUsers.ContainsKey(UserСomboBox.Text) == false)
                return false;
            if (GlobalVar.DctnrClients.ContainsKey(ClientComboBox.Text) == false)
                return false;

            return true;
        }
        private void UserСomboBox_TextChanged(object sender, EventArgs e)
        {
            buttonOk.Enabled = check();
        }

        private void ClientComboBox_TextChanged(object sender, EventArgs e)
        {
            buttonOk.Enabled = check();
        }

        private void TaskAddForm_Load(object sender, EventArgs e)
        {
            buttonOk.Enabled = check();
        }
    }
}
