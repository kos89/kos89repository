using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DBHelper;
using System.Collections.Generic;
using System;

namespace TasksDevite
{
    public partial class TaskMonthForm : Form
    {
        public TaskMonthForm()
        {
            InitializeComponent();
            gridReload();
        }

        private void gridReload()
        {
            string days;
            List<DateTime> dates;
            SqlConnection cn = new SqlConnection();
            try
            {
                cn = DBDevite.DBOpen();

                SqlCommand command = new SqlCommand("SELECT u.Users, c.Name, c.Days, c.TimeStart, c.TimeEnd, c.ClientStatus " +
                                                    "FROM clients c " +
                                                    "LEFT JOIN users u ON c.userID = u.ID", cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        days = reader.GetString(2).Trim(); //взять недельную строку 
                        for (int i = 0; i < 7; i++)        //пройтись по строке
                        {
                            if (days[i] == '1')
                            {
                                dates = dateToDays(i + 1);   //получить даты daysOfWeek
                                for (int j = 0; j < dates.Count; j++)  // пройтись по датам и добавить в грид
                                {
                                    dataGridView.Rows.Add(true, reader.GetString(0), reader.GetString(1), dates[j], reader.GetString(3), reader.GetString(4));                                    
                                }
                            }
                            //MessageBox.Show("d");
                        }
                            //MessageBox.Show(days.Trim());
                            //dataGridView.Rows.Add(true, reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
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

        private List<DateTime> dateToDays(int day)
        {
            DateTime days;
            List<DateTime> dates = new List<DateTime>();

            for (int d = 1; d <= DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month); d++)
            {
                days = Convert.ToDateTime(d.ToString() + "." + DateTime.Today.Month + "." + DateTime.Today.Year);

                if ((int)days.DayOfWeek == (day == 7 ? 0 : day) )
                    dates.Add(days);
            }
            return dates;
        }
    }
}
