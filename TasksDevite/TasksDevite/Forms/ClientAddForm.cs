using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DBHelper;

namespace TasksDevite
{
    public partial class ClientAddForm : Form
    {
        public ClientAddForm()
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

                UserComboBox.DataSource = ds.Tables[0];
                UserComboBox.DisplayMember = "Users";
                UserComboBox.ValueMember = "ID";
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
