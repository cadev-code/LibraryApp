using MySql.Data.MySqlClient;
using System.Data.Common;

namespace LibraryApp.Data
{
    public class Connection
    {
        private string connectionString;

        public Connection()
        {
            connectionString = "Server=localhost;Database=libary_db;User ID=root;Password=root";
        }
        
        public DbConnection CreateConnection()
        {
            MySqlConnection dbConnection = new MySqlConnection(connectionString);
            dbConnection.Open();
            return dbConnection;
        }
    }
}
