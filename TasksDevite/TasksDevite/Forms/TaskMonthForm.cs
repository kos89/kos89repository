using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DBHelper;

namespace TasksDevite
{
    public partial class TaskMonthForm : Form
    {
        public TaskMonthForm()
        {
            InitializeComponent();
        }

        private void gridReload()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn = DBDevite.DBOpen();

                SqlCommand command = new SqlCommand("SELECT t.ID, u.Users as Фамилия, c.Name as Клиент, c.Days, t.TimeStart as Начало, t.TimeEnd as Конец, t.TaskStatus as Статус " +
                                                   "FROM clients c " +
                                                   "LEFT JOIN users u ON c.userID = u.ID", cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    while (reader.Read())
                    {

                    }
                    reader.NextResult();
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
