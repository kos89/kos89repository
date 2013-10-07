using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DBHelper;
using System.Windows.Forms;

namespace GlobalVars
{
    class GlobalVar
    {
        public static string CurrentUser;
        public static Dictionary<string, int> DctnrUsers = new Dictionary<string, int>();
        public static Dictionary<string, int> DctnrClients = new Dictionary<string, int>();

        public static void DictionaryUsersReload()
        {
            DctnrUsers.Clear();
            SqlConnection cn = new SqlConnection();
            try
            {
                cn = DBDevite.DBOpen();

                SqlCommand command = new SqlCommand("SELECT * FROM Users", cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        GlobalVar.DctnrUsers.Add(reader.GetString(1), reader.GetInt32(0));
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

        public static void DictionaryClientsReload()
        {
            DctnrClients.Clear();
            SqlConnection cn = new SqlConnection();
            try
            {
                cn = DBDevite.DBOpen();

                SqlCommand command = new SqlCommand("SELECT * FROM Clients", cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        GlobalVar.DctnrClients.Add(reader.GetString(1), reader.GetInt32(0));
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
