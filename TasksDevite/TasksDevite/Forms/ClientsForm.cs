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
            GridReload();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClientAddForm claForm = new ClientAddForm();
            if (claForm.ShowDialog() == DialogResult.OK)
            {
                bool status;
                status = claForm.StatusComboBox.Text == "Да";
                
                SqlConnection cn = new SqlConnection();
                cn = DBDevite.DBOpen();
                ClientDAL.InsertClient(ClientDAL.GetID(cn), claForm.NameTextBox.Text, claForm.AdressTextBox.Text, claForm.PhoneTextBox.Text,
                    claForm.DateStartTimePicker.Value.Date, status, cn);
                DBDevite.DBClose(cn);
                GridReload();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int focused = Convert.ToInt32(dataGridViewClients[0,dataGridViewClients.CurrentRow.Index].Value);
            ClientAddForm claForm = new ClientAddForm();
            SqlConnection cn = new SqlConnection();
            try
            {
                cn = DBDevite.DBOpen();
                DataSet dt = ClientDAL.GetRecord(focused, cn);
                claForm.NameTextBox.Text = dt.Tables[0].Rows[0]["Name"].ToString();
                claForm.AdressTextBox.Text = dt.Tables[0].Rows[0]["Adress"].ToString();
                claForm.PhoneTextBox.Text = dt.Tables[0].Rows[0]["Phone"].ToString();
                claForm.DateStartTimePicker.Value = Convert.ToDateTime(dt.Tables[0].Rows[0]["DateStart"].ToString());
                if (dt.Tables[0].Rows[0]["ClientStatus"].ToString() == "True") 
                    claForm.StatusComboBox.Text = "Да";
                else
                    claForm.StatusComboBox.Text = "Нет";   
                
                if (claForm.ShowDialog() == DialogResult.OK)
                {
                    bool status;
                    status = claForm.StatusComboBox.Text == "Да";

                    ClientDAL.UpdateClient(focused, claForm.NameTextBox.Text, claForm.AdressTextBox.Text, claForm.PhoneTextBox.Text,
                        claForm.DateStartTimePicker.Value.Date, status, cn);
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить запись?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection cn = new SqlConnection();
                cn = DBDevite.DBOpen();

                ClientDAL.DeleteClient(Convert.ToInt32(dataGridViewClients[0,dataGridViewClients.CurrentRow.Index].Value), cn);
                
                DBDevite.DBClose(cn);
                GridReload();
            }
        }

        private void GridReload()
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
    }
    
}
