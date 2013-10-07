using System;
using System.Data;
using System.Windows.Forms;
using DBHelper;
using System.Data.SqlClient;
using GlobalVars;

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
                string days = "";

                status = claForm.StatusComboBox.Text == "Да";

                foreach (Control c in claForm.Controls)
                {
                    CheckBox cb = c as CheckBox;
                    if (cb != null)
                    {
                        if (cb.Checked)
                            days += "1";
                        else
                            days += "0";
                    }
                }
                char[] arr = days.ToCharArray();
                Array.Reverse(arr);
                days = new String(arr);
                
                SqlConnection cn = new SqlConnection();
                cn = DBDevite.DBOpen();
                
                ClientDAL.InsertClient(ClientDAL.GetID(cn), 
                                       claForm.NameTextBox.Text,
                                       claForm.AdressTextBox.Text,
                                       claForm.PhoneTextBox.Text,
                                       claForm.DateStartTimePicker.Value.Date,
                                       days,
                                       claForm.TimeStartComboBox.Text,
                                       claForm.TimeEndComboBox.Text,
                                       Convert.ToInt32(claForm.UserComboBox.SelectedValue),
                                       status, cn);

                DBDevite.DBClose(cn);

                GlobalVar.DictionaryClientsReload();
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
                string days;
                int i = 6;
                cn = DBDevite.DBOpen();
                DataSet dt = ClientDAL.GetFullRecord(focused, cn);

                claForm.NameTextBox.Text = dt.Tables[0].Rows[0]["Name"].ToString();
                claForm.AdressTextBox.Text = dt.Tables[0].Rows[0]["Adress"].ToString();
                claForm.PhoneTextBox.Text = dt.Tables[0].Rows[0]["Phone"].ToString();
                claForm.DateStartTimePicker.Value = Convert.ToDateTime(dt.Tables[0].Rows[0]["DateStart"].ToString());
                days = dt.Tables[0].Rows[0]["Days"].ToString();
                foreach (Control c in claForm.Controls)
                {
                    CheckBox cb = c as CheckBox;
                    if (cb != null)
                    {
                        cb.Checked = days[i] == '1';
                        i -= 1;
                    }
                }
                claForm.TimeStartComboBox.Text = dt.Tables[0].Rows[0]["TimeStart"].ToString();
                claForm.TimeEndComboBox.Text = dt.Tables[0].Rows[0]["TimeEnd"].ToString();
                claForm.UserComboBox.Text = dt.Tables[0].Rows[0]["Users"].ToString();
                if (dt.Tables[0].Rows[0]["ClientStatus"].ToString() == "True") 
                    claForm.StatusComboBox.Text = "Да";
                else
                    claForm.StatusComboBox.Text = "Нет";   
                
                if (claForm.ShowDialog() == DialogResult.OK)
                {
                    bool status;
                    days = "";

                    status = claForm.StatusComboBox.Text == "Да";

                    foreach (Control c in claForm.Controls)
                    {
                        CheckBox cb = c as CheckBox;
                        if (cb != null)
                        {
                            if (cb.Checked)
                                days += "1";
                            else
                                days += "0";
                        }
                    }
                    char[] arr = days.ToCharArray();
                    Array.Reverse(arr);
                    days = new String(arr);

                    ClientDAL.UpdateClient(focused, 
                                           claForm.NameTextBox.Text, 
                                           claForm.AdressTextBox.Text, 
                                           claForm.PhoneTextBox.Text,
                                           claForm.DateStartTimePicker.Value.Date,
                                           days,
                                           claForm.TimeStartComboBox.Text,
                                           claForm.TimeEndComboBox.Text,
                                           Convert.ToInt32(claForm.UserComboBox.SelectedValue),
                                           status, cn);

                    GlobalVar.DictionaryClientsReload();
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

                GlobalVar.DictionaryClientsReload();
                GridReload();
            }
        }

        private void GridReload()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn = DBDevite.DBOpen();

                SqlDataAdapter da = new SqlDataAdapter("SELECT c.ID, c.Name as Название, " +
                                                       "u.Users as Ответственный, " +
                                                       "c.Phone as Телефон, "+
                                                       "c.Adress as Адрес, " +
                                                       "c.Days as Дни_недели, " +
                                                       "c.TimeStart as Начало, " +
                                                       "c.TimeEnd as Конец, " +
                                                       "c.DateStart as Дата_начала_договора, " +
                                                       "c.ClientStatus as Статус FROM clients c " +
                                                       "LEFT JOIN users u ON c.userID = u.ID", cn);
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
