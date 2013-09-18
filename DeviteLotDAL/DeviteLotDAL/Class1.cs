﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DeviteConnectedLayer
{
    public class UsersDAL
    {
        private SqlConnection connect = null;

        public static void OpenConnection(string connectionString)
        {
           // connect = new SqlConnection(connectionString);
            //connect.Open();
        }

        public void CloseConnection()
        {
            connect.Close();
        }

        public void InsertUser(int id, string name)
        {
            string sql = string.Format("Insert Into Users" + "(ID, Name) Values('{0}','{1}')", id, name);
            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteUser(int id)
        {
            string sql = string.Format("Delete from Users where ID = '{0}'", id);
            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
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

        public void UpdateUser(int id, string name)
        {
            string sql = string.Format("Update Users Set Name = '{0}' Where ID = '{1}'", name, id);
            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllUserAsDataTable()
        {
            DataTable usr = new DataTable();
            string sql = "Select * From Users";
            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
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
        private SqlConnection connect = null;

        public void OpenConnection(string connectionString)
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
        }

        public void CloseConnection()
        {
            connect.Close();
        }

        public void InsertClient(int id, string name, string adress, string phone, string dateStart, bool status)
        {
            string sql = string.Format("Insert Into Clients (ID, Name, Adress, Phone, DateStart, Status)" +
                "Values('{0}','{1}','{2}','{3}','{4}','{5}')", id, name, adress, phone, dateStart, status);

            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
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
                param.ParameterName = "@Status";
                param.Value = status;
                param.SqlDbType = SqlDbType.Bit;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteClient(int id)
        {
            string sql = string.Format("Delete from Client where ID = '{0}'", id);
            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
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

        public void UpdateClient(int id, string name, string adress, string phone, string dateStart, bool status)
        {
            string sql = string.Format("Update Clients Set Name = '{0}', Adress = '{1}', Phone, DateStart, Status Where ID = '{1}'", name, id);
            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllUserAsDataTable()
        {
            DataTable usr = new DataTable();
            string sql = "Select * From Clients";
            using (SqlCommand cmd = new SqlCommand(sql, this.connect))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                usr.Load(dr);
                dr.Close();
            }
            return usr;
        }
    }
 
    
}