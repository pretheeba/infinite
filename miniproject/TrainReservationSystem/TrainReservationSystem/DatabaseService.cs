
using System.Data.SqlClient;

namespace TrainReservationSystem.Services
{
    public static class DatabaseService
    {
        private static string connectionString = "data source=ICS-LT-98M46D3;initial catalog=try2;user id=sa;password=pretheeba;";


    public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
