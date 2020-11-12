using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PosProject_2.Models
{
    public class SQLQuery
    {
        public static void ExecuteQueryNonConn(string query, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
        public static void OpenCloseConn(string query, string connString)
        {
            SqlConnection connection = new SqlConnection(connString);
            try
            {
                connection.Open();
                ExecuteQueryNonConn(query, connection);
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
