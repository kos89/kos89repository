using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBHelper;
using System.Data.SqlClient;
//using TasksDevite.Forms;

namespace TasksDevite
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn = DBDevite.DBOpen();

                SqlDataAdapter da = new SqlDataAdapter("select ID,Name as Название,Phone as Телефон,Adress as Адрес,DateStart as Дата_начала_договора,ClientStatus as Статус from clients", cn);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewClients.DataSource = ds.Tables[0];
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
            ClientAddForm claForm = new ClientAddForm();
            if (claForm.ShowDialog() == DialogResult.OK)
            {
                bool status;
                status = claForm.StatusComboBox.Text == "Да";     
                //MessageBox.Show(claForm.DateStartTimePicker.Value.Date.ToString());
                //MessageBox.Show(claForm.StatusComboBox.SelectedItem.ToString());
                SqlConnection cn = new SqlConnection();
                cn = DBDevite.DBOpen();
                ClientDAL.InsertClient(ClientDAL.GetID(), claForm.NameTextBox.Text, claForm.AdressTextBox.Text, claForm.PhoneTextBox.Text,
                    claForm.DateStartTimePicker.Value.Date, status, cn);
            }
        }

    }
    
}
