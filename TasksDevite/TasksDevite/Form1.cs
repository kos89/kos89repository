using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;
using System.Configuration;
using System.Data.SqlClient;
using DBHelper;

namespace TasksDevite
{
    public partial class Form1 : Form
    {
        public Form1()
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
                    UsersDAL.InsertUser(3,"ss",cn);
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
            /*
                        // Получение строки подключения и поставщика из *.config
            string dp = ConfigurationManager.AppSettings["provider"];
            string cnStr = ConfigurationManager.AppSettings["cnStr"];

            // Получение генератора поставщика
            DbProviderFactory df = DbProviderFactories.GetFactory(dp);

            // Получение объекта подключения
            using (DbConnection cn = df.CreateConnection())
            {
                MessageBox.Show("Объект подключения --> " + cn.GetType().Name);
                cn.ConnectionString = cnStr;
                cn.Open();

                // Создание объекта команды
                DbCommand cmd = df.CreateCommand();
                MessageBox.Show("Объект команды --> " + cmd.GetType().Name);
                cmd.Connection = cn;
                cmd.CommandText = "Select * From Users";

                // Вывод данных с помощью объекта чтения данных
                using (DbDataReader dr = cmd.ExecuteReader())
                {
                    MessageBox.Show("Объект чтения данных --> " + dr.GetType().Name);
                    MessageBox.Show("\n*** Текущее содержимое Inventory ***\n");
                    while (dr.Read())
                        MessageBox.Show(dr["ID"].ToString() + dr["Users"].ToString());*=
                }*/
            
        }
    }
}
