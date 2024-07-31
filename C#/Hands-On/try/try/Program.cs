using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    public static SqlConnection con;
    public static SqlCommand cmd;
    public static SqlDataReader dr;

    static void Main(string[] args)
    {
        con = GetConnection();

        bool isAdmin = AuthenticateAdmin();

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Display All Trains");

            if (isAdmin)
            {
                Console.WriteLine("2. Add a Train (Admin only)");
            }

            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayAllTrains();
                    break;
                case "2":
                    if (isAdmin)
                    {
                        AddTrain();
                    }
                    else
                    {
                        Console.WriteLine("Only admin users can add trains.");
                    }
                    break;
                case "3":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private static SqlConnection GetConnection()
    {
        Console.WriteLine("Enter SQL Server data source:");
        string dataSource = Console.ReadLine();
        Console.WriteLine("Enter initial catalog (database name):");
        string initialCatalog = Console.ReadLine();
        Console.WriteLine("Enter user id:");
        string userId = Console.ReadLine();
        Console.WriteLine("Enter password:");
        string password = Console.ReadLine();

        string connectionString = $"data source={dataSource};initial catalog={initialCatalog};user id={userId};password={password};";
        con = new SqlConnection(connectionString);
        con.Open();
        return con;
    }

    private static bool AuthenticateAdmin()
    {
        Console.WriteLine("Enter username:");
        string username = Console.ReadLine();
        Console.WriteLine("Enter password:");
        string password = Console.ReadLine();

        cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username AND PasswordHash = @PasswordHash AND IsAdmin = 1", con);
        cmd.Parameters.AddWithValue("@Username", username);
        cmd.Parameters.AddWithValue("@PasswordHash", password); // In a real application, hash the password before storing and comparing

        int count = (int)cmd.ExecuteScalar();

        return count > 0;
    }

    public static void AddTrain()
    {
        Console.WriteLine("Enter Train Name:");
        string trainName = Console.ReadLine();
        Console.WriteLine("Enter Source Station:");
        string sourceStation = Console.ReadLine();
        Console.WriteLine("Enter Destination Station:");
        string destinationStation = Console.ReadLine();
        Console.WriteLine("Enter Total Seats:");
        int totalSeats = Convert.ToInt32(Console.ReadLine());

        cmd = new SqlCommand("AddTrain", con);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@TrainName", trainName);
        cmd.Parameters.AddWithValue("@SourceStation", sourceStation);
        cmd.Parameters.AddWithValue("@DestinationStation", destinationStation);
        cmd.Parameters.AddWithValue("@TotalSeats", totalSeats);
        cmd.Parameters.AddWithValue("@AvailableSeats", totalSeats); // Initial available seats same as total

        int trainID = (int)cmd.ExecuteScalar();
        Console.WriteLine($"Train added with TrainID: {trainID}");
    }

    public static void DisplayAllTrains()
    {
        cmd = new SqlCommand("SELECT TrainID, TrainName, SourceStation, DestinationStation, AvailableSeats FROM Trains", con);
        dr = cmd.ExecuteReader();

        Console.WriteLine("Available Trains:");
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("TrainID | Train Name        | Source       | Destination   | Available Seats");
        Console.WriteLine("------------------------------------------------------------");

        while (dr.Read())
        {
            int trainID = (int)dr["TrainID"];
            string trainName = (string)dr["TrainName"];
            string sourceStation = (string)dr["SourceStation"];
            string destinationStation = (string)dr["DestinationStation"];
            int availableSeats = (int)dr["AvailableSeats"];

            Console.WriteLine($"{trainID,-7} | {trainName,-18} | {sourceStation,-12} | {destinationStation,-14} | {availableSeats}");
        }

        Console.WriteLine("------------------------------------------------------------");

        dr.Close();
    }
}
