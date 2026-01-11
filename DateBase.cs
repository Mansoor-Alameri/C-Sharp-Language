using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System_New_Virsion
{
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Windows.Forms;

    public static class Database
    {
        private static SqlConnection _connection;

        public static SqlConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(
                        @"Server=LAPTOP-V8DN1E0P;Database=Car_Rental_System_New_Virsion;Integrated Security=True;"
                    );
                }

                return _connection;
            }
        }

        public static void Open()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
                Connection.Open();
        }

        public static void Close()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
                Connection.Close();
        }

        public static void LoadData(string query, DataTable dt)
        {
            // 3) المحول DataAdapter
            Open();
            SqlDataAdapter da = new SqlDataAdapter(query, _connection);

            // 4) الجدول الذي سيحمل البيانات
            
            da.Fill(dt);
            Close();
            
           

        }
    }
}