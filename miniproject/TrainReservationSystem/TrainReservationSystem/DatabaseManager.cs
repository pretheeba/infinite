using System;
using System.Data.SqlClient;

namespace TrainReservationSystem.Data
{
    public class DatabaseManager
    {
        private readonly string _connectionString;

        public DatabaseManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlConnection GetConnection()
        {
            var con = new SqlConnection(_connectionString);
            con.Open();
            return con;
        }
    }
}
