using System;
using System.Data.SqlClient;

namespace EmployeeConsoleApp
{
    class Program
    {
        // Updated connection string with the correct database name
        private static readonly string connectionString = "data source=ICS-LT-98M46D3;initial catalog=EmployeeDB;user id=sa;password=pretheeba;";

        static void Main(string[] args)
        {
            Console.WriteLine("1. Employees who joined before 1/1/2015:");
            DisplayQueryResults("SELECT * FROM Employee WHERE DOJ < '2015-01-01'");

            Console.WriteLine("\n2. Employees with DOB after 1/1/1990:");
            DisplayQueryResults("SELECT * FROM Employee WHERE DOB > '1990-01-01'");

            Console.WriteLine("\n3. Employees with designation Consultant or Associate:");
            DisplayQueryResults("SELECT * FROM Employee WHERE Title IN ('Consultant', 'Associate')");

            Console.WriteLine("\n4. Total number of employees:");
            ExecuteScalarQuery("SELECT COUNT(*) FROM Employee");

            Console.WriteLine("\n5. Total number of employees in Chennai:");
            ExecuteScalarQuery("SELECT COUNT(*) FROM Employee WHERE City = 'Chennai'");

            Console.WriteLine("\n6. Highest Employee ID:");
            ExecuteScalarQuery("SELECT MAX(EmployeeID) FROM Employee");

            Console.WriteLine("\n7. Total number of employees who joined after 1/1/2015:");
            ExecuteScalarQuery("SELECT COUNT(*) FROM Employee WHERE DOJ > '2015-01-01'");

            Console.WriteLine("\n8. Total number of employees not with designation Associate:");
            ExecuteScalarQuery("SELECT COUNT(*) FROM Employee WHERE Title != 'Associate'");

            Console.WriteLine("\n9. Total number of employees by city:");
            DisplayQueryResults("SELECT City, COUNT(*) AS Total FROM Employee GROUP BY City");

            Console.WriteLine("\n10. Total number of employees by city and title:");
            DisplayQueryResults("SELECT City, Title, COUNT(*) AS Total FROM Employee GROUP BY City, Title");

            Console.WriteLine("\n11. Youngest employee:");
            DisplayQueryResults("SELECT * FROM Employee WHERE DOB = (SELECT MAX(DOB) FROM Employee)");

            Console.ReadLine();
        }

        private static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }

        private static void DisplayQueryResults(string query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            // Display column headers
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write($"{reader.GetName(i)}\t");
            }
            Console.WriteLine();

            // Display rows
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write($"{reader[i]}\t");
                }
                Console.WriteLine();
            }

            reader.Close();
            con.Close();
        }

        private static void ExecuteScalarQuery(string query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);

            // Execute the query and get a single value using ExecuteScalar
            object result = cmd.ExecuteScalar();
            Console.WriteLine(result);

            con.Close();
        }
    }
}
