using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using System.Configuration;
using System.Data.SqlClient;
using DBHelper;

namespace TasksDevite
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnectionStringBuilder connect = new SqlConnectionStringBuilder();
            connect.InitialCatalog = "test";
            connect.DataSource = @"(local)\SQLEXPRESS";
            connect.ConnectTimeout = 30;
            connect.IntegratedSecurity = true;

            // Создание открытого подключения
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = connect.ConnectionString;
                try
                {
                    //Открыть подключение
                    cn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from users", cn);
                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Users1");
                    //dataGridView1.DataSource = ds.Tables[0];

                    //UsersDAL.InsertUser(3,"ss",cn);
                    //string strSQL = "SELECT * FROM Users WHERE ID=0";
                    //SqlCommand myCommand = new SqlCommand(strSQL, cn);
                    //SqlDataReader dr = myCommand.ExecuteReader();
                    //while ()
                        //MessageBox.Show(dr[0].ToString() + dr[1].ToString());
                }
                catch (SqlException ex)
                {
                    // Протоколировать исключение
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // Гарантировать освобождение подключения
                    cn.Close();
                }
            }            
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EntresForm entForm = new EntresForm();
            if (entForm.ShowDialog() == DialogResult.OK)
                entForm.Close();
            else
                Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientsForm clForm = new ClientsForm();
            clForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
