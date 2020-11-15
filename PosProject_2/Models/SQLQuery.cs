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
        public string ServerName { get { return "(local)"; } set { this.ServerName = value; } }
        public string DatabaseName { get { return "Project_1_Pos_FakeData"; } set { this.DatabaseName = value; } }
        public string ConnectionString
        {
            get
            {
                return @"Data Source="+this.ServerName+";Initial Catalog="+this.DatabaseName+";Integrated Security=True";
            }
        }
        public SQLQuery()
        {

        }
        public SQLQuery(string serverName)
        {
            this.ServerName = serverName;
        }
        public SQLQuery(string serverName, string databaseName)
        {
            this.ServerName = serverName;
            this.DatabaseName = databaseName;
        }
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
        public void OpenCloseConn(string query)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
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
