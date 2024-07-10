using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Employee
{
    public int EmployeeID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public DateTime DOB { get; set; }
    public DateTime DOJ { get; set; }
    public string City { get; set; }
}

public delegate int CalculatorDelegate(int x, int y);

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Calculator Operations");
        Console.WriteLine("2. Employee Operations");
        Console.WriteLine("3. File Operations");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid choice. Please enter either 1, 2, or 3.");
            return;
        }

        switch (choice)
        {
            case 1:
                CalculatorOperations();
                break;
            case 2:
                EmployeeOperations();
                break;
            case 3:
                FileOperations();
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter either 1, 2, or 3.");
                break;
        }

        Console.ReadLine();
    }

    static void CalculatorOperations()
    {
        int num1, num2;

        Console.WriteLine("Enter the first number:");
        if (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("Enter the second number:");
        if (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            Console.ReadLine();
            return;
        }

        CalculatorDelegate addDelegate = Add;
        CalculatorDelegate subtractDelegate = Subtract;
        CalculatorDelegate multiplyDelegate = Multiply;

        int sum = PerformOperation(addDelegate, num1, num2);
        Console.WriteLine($"Sum of {num1} and {num2} is: {sum}");

        int difference = PerformOperation(subtractDelegate, num1, num2);
        Console.WriteLine($"Difference of {num1} and {num2} is: {difference}");

        int product = PerformOperation(multiplyDelegate, num1, num2);
        Console.WriteLine($"Product of {num1} and {num2} is: {product}");

        Console.ReadLine();
    }

    static void EmployeeOperations()
    {
        List<Employee> empList = new List<Employee>
        {
            new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" },
            new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
            new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
            new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
            new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
            new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
            new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
            new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
            new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
            new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }
        };

        Console.WriteLine("Details of all employees:");
        foreach (var emp in empList)
        {
            Console.WriteLine($"{emp.EmployeeID} \t {emp.FirstName} \t {emp.LastName} \t {emp.Title} \t {emp.DOB.ToShortDateString()} \t {emp.DOJ.ToShortDateString()} \t {emp.City}");
        }
        Console.WriteLine();


        var allEmployees = from emp in empList select emp;
        Console.WriteLine("a. Details of all employees:");
        DisplayEmployees(allEmployees.ToList());

        var employeesNotInMumbai = from emp in empList where emp.City != "Mumbai" select emp;
        Console.WriteLine("\nb. Details of employees not in Mumbai:");
        DisplayEmployees(employeesNotInMumbai.ToList());

        var assistantManagers = from emp in empList where emp.Title == "AsstManager" select emp;
        Console.WriteLine("\nc. Details of employees with title AsstManager:");
        DisplayEmployees(assistantManagers.ToList());

        var employeesWithLastNameStartingWithS = from emp in empList where emp.LastName.StartsWith("S") select emp;
        Console.WriteLine("\nd. Details of employees whose Last Name starts with S:");
        DisplayEmployees(employeesWithLastNameStartingWithS.ToList());

        Console.ReadLine();
    }

    static void FileOperations()
    {
        string directoryPath = @"C:\batch24\C#\Assessment\CC4";
        string fileName = "file.txt";
        string filePath = Path.Combine(directoryPath, fileName);

        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        Console.WriteLine("Please enter the text to append to the file:");
        string userText = Console.ReadLine();

        string timeStamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        string textToAppend = $"[{timeStamp}] {userText}";

        StreamWriter writer = null;
        try
        {
            writer = new StreamWriter(filePath, append: true);
            writer.WriteLine(textToAppend);
            Console.WriteLine($"Text appended successfully to {filePath} with a timestamp.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            if (writer != null)
            {
                writer.Close();
            }
        }
        Console.ReadLine();
    }

    static void DisplayEmployees(List<Employee> employees)
    {
        foreach (var emp in employees)
        {
            Console.WriteLine($"{emp.EmployeeID} \t {emp.FirstName} \t {emp.LastName} \t {emp.Title} \t {emp.DOB.ToShortDateString()} \t {emp.DOJ.ToShortDateString()} \t {emp.City}");
        }
    }

    static int PerformOperation(CalculatorDelegate calcDelegate, int x, int y)
    {
        return calcDelegate(x, y);
    }

    static int Add(int x, int y)
    {
        return x + y;
    }

    static int Subtract(int x, int y)
    {
        return x - y;
    }

    static int Multiply(int x, int y)
    {
        return x * y;
    }
}
