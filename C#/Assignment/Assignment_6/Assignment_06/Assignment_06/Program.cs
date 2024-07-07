using System;
using System.Collections.Generic;

public class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public string EmpCity { get; set; }
    public decimal EmpSalary { get; set; }
}

class Program
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Square of Numbers");
            Console.WriteLine("2. Filter Words");
            Console.WriteLine("3. Employee Operations");
            Console.WriteLine("4. Exit");

            bool isValidChoice = int.TryParse(Console.ReadLine(), out choice);

            if (isValidChoice)
            {
                switch (choice)
                {
                    case 1:
                        SquareOfNumbers();
                        break;
                    case 2:
                        FilterWords();
                        break;
                    case 3:
                        EmployeeOperations();
                        break;
                    case 4:
                        Console.WriteLine("Exiting the program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.WriteLine();
        } while (choice != 4);
    }

    // Method for square of numbers
    static void SquareOfNumbers()
    {
        int[] numbers = { 7, 2, 30 };

        foreach (int number in numbers)
        {
            int square = number * number;

            if (square > 20)
            {
                Console.WriteLine($"{number} - {square}");
            }
        }
    }

    // Method for filtering words
    static void FilterWords()
    {
        List<string> words = new List<string>
        {
            "apple",
            "cat",
            "alarm",
            "room",
            "atom",
            "band",
            "am"
        };

        foreach (string word in words)
        {
            if (word.StartsWith("a", StringComparison.OrdinalIgnoreCase) && word.EndsWith("m", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(word);
            }
        }
    }

    // Method for employee operations
    static void EmployeeOperations()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "John Doe", EmpCity = "Bangalore", EmpSalary = 50000 },
            new Employee { EmpId = 2, EmpName = "Jane Smith", EmpCity = "Mumbai", EmpSalary = 60000 },
            new Employee { EmpId = 3, EmpName = "Mike Brown", EmpCity = "Bangalore", EmpSalary = 55000 },
            new Employee { EmpId = 4, EmpName = "Emily Clark", EmpCity = "Delhi", EmpSalary = 48000 },
            new Employee { EmpId = 5, EmpName = "David Lee", EmpCity = "Chennai", EmpSalary = 45000 }
        };

        Console.WriteLine("Choose an employee operation:");
        Console.WriteLine("1. Display all employees");
        Console.WriteLine("2. Display employees with salary greater than 45000");
        Console.WriteLine("3. Display employees from Bangalore");
        Console.WriteLine("4. Display employees sorted by name");

        int operation;
        bool isValidOperation = int.TryParse(Console.ReadLine(), out operation);

        if (isValidOperation)
        {
            switch (operation)
            {
                case 1:
                    Console.WriteLine("All Employees:");
                    DisplayAllEmployees(employees);
                    break;
                case 2:
                    Console.WriteLine("Employees with Salary > 45000:");
                    DisplayEmployeesAboveSalary(employees, 45000);
                    break;
                case 3:
                    Console.WriteLine("Employees from Bangalore:");
                    DisplayEmployeesFromCity(employees, "Bangalore");
                    break;
                case 4:
                    Console.WriteLine("Employees sorted by Name (Ascending):");
                    DisplayEmployeesByNameAscending(employees);
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please enter a number between 1 and 4.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    // Helper methods for employee operations
    static void DisplayAllEmployees(List<Employee> employees)
    {
        foreach (var emp in employees)
        {
            Console.WriteLine($"EmpId: {emp.EmpId}, EmpName: {emp.EmpName}, EmpCity: {emp.EmpCity}, EmpSalary: {emp.EmpSalary}");
        }
    }

    static void DisplayEmployeesAboveSalary(List<Employee> employees, decimal salaryThreshold)
    {
        foreach (var emp in employees)
        {
            if (emp.EmpSalary > salaryThreshold)
            {
                Console.WriteLine($"EmpId: {emp.EmpId}, EmpName: {emp.EmpName}, EmpCity: {emp.EmpCity}, EmpSalary: {emp.EmpSalary}");
            }
        }
    }

    static void DisplayEmployeesFromCity(List<Employee> employees, string city)
    {
        foreach (var emp in employees)
        {
            if (emp.EmpCity.Equals(city, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"EmpId: {emp.EmpId}, EmpName: {emp.EmpName}, EmpCity: {emp.EmpCity}, EmpSalary: {emp.EmpSalary}");
            }
        }
    }

    static void DisplayEmployeesByNameAscending(List<Employee> employees)
    {
        employees.Sort((emp1, emp2) => string.Compare(emp1.EmpName, emp2.EmpName));

        foreach (var emp in employees)
        {
            Console.WriteLine($"EmpId: {emp.EmpId}, EmpName: {emp.EmpName}, EmpCity: {emp.EmpCity}, EmpSalary: {emp.EmpSalary}");
        }
    }
}
