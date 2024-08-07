using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TrainReservationSystem
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter one option: ");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("3. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Login();
                        break;
                    case 2:
                        Register();
                        break;
                    case 3:
                        return; // Exit the application
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private static SqlConnection GetConnection()
        {
            con = new SqlConnection("data source=ICS-LT-98M46D3;initial catalog=try2;user id=sa;password=pretheeba;");
            con.Open();
            return con;
        }

        private static void Login()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            con = GetConnection();
            cmd = new SqlCommand("SELECT * FROM Users WHERE Username=@username AND Password=@password", con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                bool isAdmin = (bool)dr["IsAdmin"];
                int userId = (int)dr["UserId"];

                if (isAdmin)
                {
                    AdminMenu(userId);
                }
                else
                {
                    UserMenu(userId);
                }
            }
            else
            {
                Console.WriteLine("Invalid credentials");
            }

            dr.Close();
            con.Close();
        }

        private static void Register()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            Console.Write("Are you an admin (yes/no): ");
            bool isAdmin = Console.ReadLine().ToLower() == "yes";

            con = GetConnection();
            cmd = new SqlCommand("INSERT INTO Users (Username, Password, IsAdmin) VALUES (@username, @password, @isAdmin)", con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@isAdmin", isAdmin);
            cmd.ExecuteNonQuery();

            Console.WriteLine("Registration successful");
            con.Close();
        }

        private static void AdminMenu(int userId)
        {
            while (true)
            {
                Console.WriteLine("1. Add Train");
                Console.WriteLine("2. Remove Train");
                Console.WriteLine("3. Logout");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddTrain();
                        break;
                    case 2:
                        RemoveTrain();
                        break;
                    case 3:
                        return; // Logout
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private static void AddTrain()
        {
            Console.Write("Enter train number: ");
            int trainNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter train name: ");
            string trainName = Console.ReadLine();
            Console.Write("Enter departure station: ");
            string departureStation = Console.ReadLine();
            Console.Write("Enter arrival station: ");
            string arrivalStation = Console.ReadLine();
            Console.Write("Enter price: ");
            decimal trainPrice = Convert.ToDecimal(Console.ReadLine()); // Renamed variable
            Console.Write("Enter class of travel (AC/General): ");
            string travelClass = Console.ReadLine(); // Renamed variable
            Console.Write("Enter train status (active/inactive): ");
            string trainStatus = Console.ReadLine();
            Console.Write("Enter seats available: ");
            int availableSeats = Convert.ToInt32(Console.ReadLine()); // Renamed variable

            con = GetConnection();
            cmd = new SqlCommand("INSERT INTO Trains (TrainNumber, TrainName, DepartureStation, ArrivalStation, Price, ClassOfTravel, TrainStatus, SeatsAvailable) VALUES (@trainNumber, @trainName, @departureStation, @arrivalStation, @price, @classOfTravel, @trainStatus, @seatsAvailable)", con);
            cmd.Parameters.AddWithValue("@trainNumber", trainNumber);
            cmd.Parameters.AddWithValue("@trainName", trainName);
            cmd.Parameters.AddWithValue("@departureStation", departureStation);
            cmd.Parameters.AddWithValue("@arrivalStation", arrivalStation);
            cmd.Parameters.AddWithValue("@price", trainPrice);
            cmd.Parameters.AddWithValue("@classOfTravel", travelClass);
            cmd.Parameters.AddWithValue("@trainStatus", trainStatus);
            cmd.Parameters.AddWithValue("@seatsAvailable", availableSeats);
            cmd.ExecuteNonQuery();

            Console.WriteLine("Train added successfully");
            con.Close();
        }

        private static void RemoveTrain()
        {
            Console.Write("Enter train number to remove: ");
            int trainNumber = Convert.ToInt32(Console.ReadLine());

            con = GetConnection();
            // Check if train exists
            cmd = new SqlCommand("SELECT * FROM Trains WHERE TrainNumber=@trainNumber", con);
            cmd.Parameters.AddWithValue("@trainNumber", trainNumber);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                dr.Close();
                // Remove associated coaches
                cmd = new SqlCommand("DELETE FROM Coaches WHERE TrainId=@trainNumber", con);
                cmd.Parameters.AddWithValue("@trainNumber", trainNumber);
                cmd.ExecuteNonQuery();

                // Remove train
                cmd = new SqlCommand("DELETE FROM Trains WHERE TrainNumber=@trainNumber", con);
                cmd.Parameters.AddWithValue("@trainNumber", trainNumber);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Train removed successfully");
            }
            else
            {
                Console.WriteLine("Train not found");
            }

            con.Close();
        }

        private static void UserMenu(int userId)
        {
            while (true)
            {
                Console.WriteLine("1. Book Ticket");
                Console.WriteLine("2. Cancel Ticket");
                Console.WriteLine("3. Logout");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        BookTicket(userId);
                        break;
                    case 2:
                        CancelTicket(userId);
                        break;
                    case 3:
                        return; // Logout
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private static void BookTicket(int userId)
        {
            Console.Write("Enter departure station: ");
            string departureStation = Console.ReadLine();
            Console.Write("Enter arrival station: ");
            string arrivalStation = Console.ReadLine();

            if (departureStation.Equals(arrivalStation, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Departure and arrival stations cannot be the same.");
                return;
            }

            con = GetConnection();
            cmd = new SqlCommand("SELECT * FROM Trains WHERE DepartureStation=@departureStation AND ArrivalStation=@arrivalStation AND TrainStatus='active'", con);
            cmd.Parameters.AddWithValue("@departureStation", departureStation);
            cmd.Parameters.AddWithValue("@arrivalStation", arrivalStation);
            dr = cmd.ExecuteReader();

            List<int> availableTrainIds = new List<int>();

            while (dr.Read())
            {
                int trainId = (int)dr["TrainId"];
                string trainName = (string)dr["TrainName"];
                decimal price = (decimal)dr["Price"];
                string classOfTravel = (string)dr["ClassOfTravel"]; // Correct variable here
                int seatsAvailable = (int)dr["SeatsAvailable"];

                Console.WriteLine($"Train ID: {trainId}, Train Name: {trainName}, Price: {price}, Class of Travel: {classOfTravel}, Seats Available: {seatsAvailable}");
                availableTrainIds.Add(trainId);
            }

            dr.Close();

            if (availableTrainIds.Count == 0)
            {
                Console.WriteLine("No trains available for the specified departure and arrival stations.");
                con.Close();
                return;
            }

            Console.Write("Enter train ID to book: ");
            int selectedTrainId = Convert.ToInt32(Console.ReadLine());

            if (!availableTrainIds.Contains(selectedTrainId))
            {
                Console.WriteLine("Invalid train ID selected.");
                con.Close();
                return;
            }

            Console.Write("Enter number of members (max 3): ");
            int numberOfMembers = Convert.ToInt32(Console.ReadLine());

            if (numberOfMembers < 1 || numberOfMembers > 3)
            {
                Console.WriteLine("You can book tickets for up to 3 members.");
                con.Close();
                return;
            }

            List<Passenger> passengers = new List<Passenger>();

            for (int i = 0; i < numberOfMembers; i++)
            {
                Console.Write($"Enter details for member {i + 1}:\n");

                Console.Write("Name: ");
                string passengerName = Console.ReadLine();
                Console.Write("Age: ");
                int passengerAge = Convert.ToInt32(Console.ReadLine());

                bool isSeniorCitizen = passengerAge >= 60;
                bool isChild = passengerAge <= 12;

                Console.Write("Class (AC/General): ");
                string passengerClass = Console.ReadLine(); // Use local variable `passengerClass`
                Console.Write("Food preference (Yes/No): ");
                bool foodPreference = Console.ReadLine().ToLower() == "yes";

                passengers.Add(new Passenger
                {
                    Name = passengerName,
                    Age = passengerAge,
                    IsSeniorCitizen = isSeniorCitizen,
                    IsChild = isChild,
                    ClassOfTravel = passengerClass, // Correct usage here
                    FoodPreference = foodPreference
                });
            }

            cmd = new SqlCommand("SELECT * FROM Coaches WHERE TrainId=@trainId AND CoachType=@coachType AND SeatsAvailable >= @numberOfSeats", con);
            cmd.Parameters.AddWithValue("@trainId", selectedTrainId);
            cmd.Parameters.AddWithValue("@coachType", passengers[0].ClassOfTravel); // Ensure correct usage
            cmd.Parameters.AddWithValue("@numberOfSeats", numberOfMembers);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int coachId = (int)dr["CoachId"];
                dr.Close();

                // Insert booking
                cmd = new SqlCommand("INSERT INTO Bookings (UserId, TrainId, CoachId, NumberOfSeats, BookingDate) VALUES (@userId, @trainId, @coachId, @numberOfSeats, GETDATE())", con);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@trainId", selectedTrainId);
                cmd.Parameters.AddWithValue("@coachId", coachId);
                cmd.Parameters.AddWithValue("@numberOfSeats", numberOfMembers);
                cmd.ExecuteNonQuery();

                // Update available seats
                cmd = new SqlCommand("UPDATE Coaches SET SeatsAvailable = SeatsAvailable - @numberOfSeats WHERE CoachId = @coachId", con);
                cmd.Parameters.AddWithValue("@numberOfSeats", numberOfMembers);
                cmd.Parameters.AddWithValue("@coachId", coachId);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Ticket(s) booked successfully");
                Console.WriteLine("Booking Details:");
                foreach (var passenger in passengers)
                {
                    Console.WriteLine($"Name: {passenger.Name}, Age: {passenger.Age}, Senior: {passenger.IsSeniorCitizen}, Child: {passenger.IsChild}, Class: {passenger.ClassOfTravel}, Food: {passenger.FoodPreference}");
                }
            }
            else
            {
                Console.WriteLine("Not enough seats available in the selected coach");
            }

            con.Close();
        }

        private static void CancelTicket(int userId)
        {
            Console.Write("Enter booking ID to cancel: ");
            int bookingId = Convert.ToInt32(Console.ReadLine());

            con = GetConnection();
            // Check if the booking exists
            cmd = new SqlCommand("SELECT * FROM Bookings WHERE BookingId = @bookingId AND UserId = @userId", con);
            cmd.Parameters.AddWithValue("@bookingId", bookingId);
            cmd.Parameters.AddWithValue("@userId", userId);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int coachId = (int)dr["CoachId"];
                int numberOfSeats = (int)dr["NumberOfSeats"];
                dr.Close();

                Console.Write("Reason for cancellation: ");
                string cancellationReason = Console.ReadLine();
                Console.Write("Is refund available (Yes/No): ");
                bool isRefundAvailable = Console.ReadLine().ToLower() == "yes";

                // Insert cancellation
                cmd = new SqlCommand("INSERT INTO Cancellations (BookingId, CancelledSeats, CancellationReason, RefundAvailable, CancellationDate) VALUES (@bookingId, @numberOfSeats, @cancellationReason, @refundAvailable, GETDATE())", con);
                cmd.Parameters.AddWithValue("@bookingId", bookingId);
                cmd.Parameters.AddWithValue("@numberOfSeats", numberOfSeats);
                cmd.Parameters.AddWithValue("@cancellationReason", cancellationReason);
                cmd.Parameters.AddWithValue("@refundAvailable", isRefundAvailable);
                cmd.ExecuteNonQuery();

                // Update available seats
                cmd = new SqlCommand("UPDATE Coaches SET SeatsAvailable = SeatsAvailable + @numberOfSeats WHERE CoachId = @coachId", con);
                cmd.Parameters.AddWithValue("@numberOfSeats", numberOfSeats);
                cmd.Parameters.AddWithValue("@coachId", coachId);
                cmd.ExecuteNonQuery();

                // Delete booking
                cmd = new SqlCommand("DELETE FROM Bookings WHERE BookingId = @bookingId", con);
                cmd.Parameters.AddWithValue("@bookingId", bookingId);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Ticket(s) cancelled successfully");
            }
            else
            {
                Console.WriteLine("Booking not found or you do not have permission to cancel this booking");
            }

            con.Close();
        }

        // Utility method to check if the input is an integer
        private static bool TryParseInt(string input, out int number)
        {
            return int.TryParse(input, out number);
        }

        // Utility class for passenger details
        private class Passenger
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public bool IsSeniorCitizen { get; set; }
            public bool IsChild { get; set; }
            public string ClassOfTravel { get; set; }
            public bool FoodPreference { get; set; }
        }
    }
}
