using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LINQ_SQL_Assignment
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Employee> empList = new List<Employee>
            {

          new Employee { EmployeeID = 1001, FirstName = "pretheeba", LastName = "udhayakumar", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" },
                new Employee { EmployeeID = 1002, FirstName = "sajana", LastName = "preetha", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
                new Employee { EmployeeID = 1003, FirstName = "vaishu", LastName = "raji", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
                new Employee { EmployeeID = 1004, FirstName = "kajal", LastName = "shukla", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
                new Employee { EmployeeID = 1005, FirstName = "dharshini", LastName = "udhayakumar", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
                new Employee { EmployeeID = 1006, FirstName = "pradeep", LastName = "vijyakumar", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
                new Employee { EmployeeID = 1007, FirstName = "sumathi", LastName = "udhayakumar", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
                new Employee { EmployeeID = 1008, FirstName = "udhai", LastName = "manoharan", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
                new Employee { EmployeeID = 1009, FirstName = "kumar", LastName = "manoharan", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
                new Employee { EmployeeID = 1010, FirstName = "hari", LastName = "radha", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }
            };

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
    }
}
