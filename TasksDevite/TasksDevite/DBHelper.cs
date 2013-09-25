using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DBHelper
{
    public class DBDevite
    {
        public static SqlConnection DBOpen()
        {
            SqlConnectionStringBuilder connect = new SqlConnectionStringBuilder();
            connect.InitialCatalog = "test";
            //connect.DataSource = @"(local)\SQLEXPRESS";
            connect.DataSource = @"(local)";
            connect.AttachDBFilename = @"C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\test.mdf";
            connect.ConnectTimeout = 30;
            connect.IntegratedSecurity = true;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = connect.ConnectionString;
            cn.Open();
            return cn;
        }

        public static void DBClose(SqlConnection cn)
        {
            cn.Close();
        }
    }

    public class UsersDAL
    {
        public static void InsertUser(int id, string name, SqlConnection cn)
        {
            string sql = string.Format("Insert Into Users" + "(ID, Users) Values('{0}','{1}')", id, name);
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteUser(int id, SqlConnection cn)
        {
            string sql = string.Format("Delete from Users where ID = '{0}'", id);
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Нет такого пользователя!", ex);
                    throw error;
                }
            }
        }

        public static void UpdateUser(int id, string name, SqlConnection cn)
        {
            string sql = string.Format("Update Users Set Name = '{0}' Where ID = '{1}'", name, id);
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetAllUserAsDataTable(SqlConnection cn)
        {
            DataTable usr = new DataTable();
            string sql = "Select * From Users";
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                usr.Load(dr);
                dr.Close();
            }
            return usr;
        }
    }

    public class ClientDAL
    {
        public static void InsertClient(int id, string name, string adress, string phone, DateTime dateStart, bool status, SqlConnection cn)
        {
            string sql = ("Insert Into Clients (ID, Name, Adress, Phone, DateStart, ClientStatus)" +
                "Values(@ID, @Name, @Adress, @Phone, @DateStart, @ClientStatus)");

            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@ID";
                param.Value = id;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Name";
                param.Value = name;
                param.SqlDbType = SqlDbType.Char;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Adress";
                param.Value = adress;
                param.SqlDbType = SqlDbType.Char;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Phone";
                param.Value = phone;
                param.SqlDbType = SqlDbType.Char;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@DateStart";
                param.Value = dateStart;
                param.SqlDbType = SqlDbType.Date;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@ClientStatus";
                param.Value = status;
                param.SqlDbType = SqlDbType.Bit;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateClient(int id, string name, string adress, string phone, DateTime dateStart, bool status, SqlConnection cn)
        {
            string sql = ("Update Clients Set Name = @Name, Adress = @Adress, Phone = @Phone, DateStart = @DateStart, ClientStatus = @ClientStatus Where ID = @ID");

            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@ID";
                param.Value = id;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Name";
                param.Value = name;
                param.SqlDbType = SqlDbType.Char;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Adress";
                param.Value = adress;
                param.SqlDbType = SqlDbType.Char;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Phone";
                param.Value = phone;
                param.SqlDbType = SqlDbType.Char;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@DateStart";
                param.Value = dateStart;
                param.SqlDbType = SqlDbType.Date;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@ClientStatus";
                param.Value = status;
                param.SqlDbType = SqlDbType.Bit;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
            }
        }

        public static int GetID(SqlConnection cn)
        {
            using (SqlCommand cmd = new SqlCommand("select count(*) from Clients", cn))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                try
                {
                    dr.Read();
                    return Convert.ToInt32(dr[0])+1;
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Ошибка с доступом к таблице Clients", ex);
                    throw error;
                }
                finally
                {
                    dr.Close();
                }
            }
        }
        public static void DeleteClient(int id, SqlConnection cn)
        {
            string sql = string.Format("Delete from Clients where ID = '{0}'", id);
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Нет такого пользователя!", ex);
                    throw error;
                }
            }
        }

        public static DataSet GetAllData(SqlConnection cn)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from clients", cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public static DataSet GetRecord(int id, SqlConnection cn)
        {
            string sql = string.Format("select * from clients where ID = '{0}'", id);
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;    
        }
    }
}

