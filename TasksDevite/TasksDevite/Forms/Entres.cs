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
    public partial class EntresForm : Form
    {
        public EntresForm()
        {
            InitializeComponent();
        }

        private void Entres_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetDevite.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.dataSetDevite.Users);
            /*SqlConnection cn = new SqlConnection();
            try
            {
                cn = DBDevite.DBOpen();

                SqlDataAdapter da = new SqlDataAdapter("select * from users", cn);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);

                comboBoxUser.DataSource = ds.Tables[0];
                comboBoxUser.DisplayMember = "Users";
                comboBoxUser.ValueMember = "ID";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBDevite.DBClose(cn);
            }*/
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            GlobalVar.CurrentUser = comboBoxUser.Text;
        }
    }
}
