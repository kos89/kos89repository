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
            connect.DataSource = @"(local)\SQLEXPRESS";
            //connect.DataSource = @"(local)";
            //connect.AttachDBFilename = @"C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\test.mdf";
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
        public static void InsertClient(int id, string name, string adress, string phone, DateTime dateStart, string days, string timeStart, string timeEnd, int userID, bool status, SqlConnection cn)
        {
            string sql = ("Insert Into Clients (ID, Name, Adress, Phone, DateStart, Days, TimeStart, TimeEnd, UserID, ClientStatus)" +
                "Values(@ID, @Name, @Adress, @Phone, @DateStart, @Days, @TimeStart, @TimeEnd, @UserID, @ClientStatus)");

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
                param.ParameterName = "@Days";
                param.Value = days;
                param.SqlDbType = SqlDbType.Char;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@TimeStart";
                param.Value = timeStart;
                param.SqlDbType = SqlDbType.Char;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@TimeEnd";
                param.Value = timeEnd;
                param.SqlDbType = SqlDbType.Char;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@UserID";
                param.Value = userID;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@ClientStatus";
                param.Value = status;
                param.SqlDbType = SqlDbType.Bit;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateClient(int id, string name, string adress, string phone, DateTime dateStart, string days, string timeStart, string timeEnd, int userID, bool status, SqlConnection cn)
        {
            string sql = ("Update Clients Set Name = @Name, Adress = @Adress, Phone = @Phone, DateStart = @DateStart, Days = @Days, TimeStart = @TimeStart, TimeEnd = @TimeEnd, UserID = @UserID, ClientStatus = @ClientStatus Where ID = @ID");

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
                param.ParameterName = "@Days";
                param.Value = days;
                param.SqlDbType = SqlDbType.Char;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@TimeStart";
                param.Value = timeStart;
                param.SqlDbType = SqlDbType.Char;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@TimeEnd";
                param.Value = timeEnd;
                param.SqlDbType = SqlDbType.Char;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@UserID";
                param.Value = userID;
                param.SqlDbType = SqlDbType.Int;
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
            using (SqlCommand cmd = new SqlCommand("select ID from Clients order by ID desc", cn))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                try
                {
                    dr.Read();
                    return (dr.HasRows) ? Convert.ToInt32(dr[0]) + 1 : 1;
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
                    Exception error = new Exception("Нет такого пользователя!", ex); //TODO не дает удалить из за связи
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

        public static DataSet GetFullRecord(int id, SqlConnection cn)
        {
            string sql = string.Format("SELECT * " +
                                       "FROM clients c " +
                                       "INNER JOIN users u ON c.UserID = u.ID " +
                                       "WHERE c.ID = '{0}'", id);
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;    
        }
    }

    public class TaskDAL
    {
        public static void InsertTask(int id, int userID, int clientID, DateTime date, string timeStart, string timeEnd, bool status, string about, SqlConnection cn)
        {
            string sql = ("Insert Into Tasks (ID, UserID, ClientID, Date, TimeStart, TimeEnd, TaskStatus, About)" +
                "Values(@ID, @UserID, @ClientID, @Date, @TimeStart, @TimeEnd, @TaskStatus, @About)");

            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@ID";
                param.Value = id;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@UserID";
                param.Value = userID;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@ClientID";
                param.Value = clientID;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Date";
                param.Value = date;
                param.SqlDbType = SqlDbType.Date;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@TimeStart";
                param.Value = timeStart;
                param.SqlDbType = SqlDbType.Char;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@TimeEnd";
                param.Value = timeEnd;
                param.SqlDbType = SqlDbType.Char;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@TaskStatus";
                param.Value = status;
                param.SqlDbType = SqlDbType.Bit;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@About";
                param.Value = about;
                param.SqlDbType = SqlDbType.Char;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateTask(int id, int userID, int clientID, DateTime date, string timeStart, string timeEnd, bool status, string about, SqlConnection cn)
        {
            string sql = ("Update Tasks Set UserID = @UserID," + 
                            "ClientID = @ClientID, " + 
                            "Date = @Date, " + 
                            "TimeStart = @TimeStart, " +
                            "TimeEnd = @TimeEnd, " + 
                            "TaskStatus = @TaskStatus, " +
                            "About = @About " +
                          "Where ID = @ID");

            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@ID";
                param.Value = id;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@UserID";
                param.Value = userID;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@ClientID";
                param.Value = clientID;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Date";
                param.Value = date;
                param.SqlDbType = SqlDbType.Date;
                cmd.Parameters.Add(param);
                param = new SqlParameter();

                param = new SqlParameter();
                param.ParameterName = "@TimeStart";
                param.Value = timeStart;
                param.SqlDbType = SqlDbType.Char;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@TimeEnd";
                param.Value = timeEnd;
                param.SqlDbType = SqlDbType.Char;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@TaskStatus";
                param.Value = status;
                param.SqlDbType = SqlDbType.Bit;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@About";
                param.Value = about;
                param.SqlDbType = SqlDbType.Char;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
            }
        }

        public static int GetID(SqlConnection cn)
        {
            using (SqlCommand cmd = new SqlCommand("select ID from Tasks order by ID desc", cn))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                try
                {
                    dr.Read();
                    return (dr.HasRows) ? Convert.ToInt32(dr[0]) + 1 : 1;
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Ошибка с доступом к таблице Tasks", ex);
                    throw error;
                }
                finally
                {
                    dr.Close();
                }
            }
        }
        public static void DeleteTask(int id, SqlConnection cn)
        {
            string sql = string.Format("Delete from Tasks where ID = '{0}'", id);
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Exception error = new Exception("Нет такого тикета!", ex);
                    throw error;
                }
            }
        }

        public static DataSet GetAllData(SqlConnection cn)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Tasks", cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public static DataSet GetFullRecord(int id, SqlConnection cn)
        {
            string sql = string.Format( "SELECT t.ID, t.UserID, t.ClientID, t.Date, t.TimeStart, t.TimeEnd, t.TaskStatus, t.About, u.Users, c.Name " +
                                        "FROM  Tasks t " + 
                                        "INNER JOIN Clients c ON c.ID = t.ClientID " +
                                        "INNER JOIN Users u ON t.UserID = u.ID " +
                                        "WHERE t.ID = '{0}'", id);
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}

