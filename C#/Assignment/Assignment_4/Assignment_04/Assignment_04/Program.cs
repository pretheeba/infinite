using System;

public class Program
{
    // Function 1: Display First Name and Last Name in Upper Case
    public static void DisplayNames()
    {
        Console.WriteLine("Enter First Name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter Last Name:");
        string lastName = Console.ReadLine();

        Console.WriteLine("First Name:");
        Console.WriteLine(firstName.ToUpper());
        Console.WriteLine("Last Name:");
        Console.WriteLine(lastName.ToUpper());
    }

    // Function 2: Count Occurrences of a Letter in a String
    public static void CountOccurrences()
    {
        Console.WriteLine("Enter a string:");
        string inputString = Console.ReadLine();

        Console.WriteLine("Enter a letter to count:");
        char letter = Console.ReadKey().KeyChar;
        Console.WriteLine(); // To move to the next line after input

        int count = 0;
        foreach (char c in inputString)
        {
            if (char.ToUpper(c) == char.ToUpper(letter))
            {
                count++;
            }
        }

        Console.WriteLine($"Number of occurrences of '{letter}' in '{inputString}': {count}");
    }

    // Function 3: Banking System with Custom Exception
    public static void BankingSystem()
    {
        Console.WriteLine("Banking System");

        // Example Banking System with custom exception
        BankAccount account = new BankAccount();
        account.Deposit(1000);

        try
        {
            account.Withdraw(500);
            account.Withdraw(800); // This will throw InsufficientBalanceException
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Argument Exception: {ex.Message}");
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine($"Insufficient Balance Exception: {ex.Message}");
        }

        account.CheckBalance();
    }

    // Function 4: Scholarship Calculation
    public static void Scholarship()
    {
        Console.WriteLine("Scholarship Calculation");

        Console.WriteLine("Enter marks:");
        int marks = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter fees:");
        double fees = double.Parse(Console.ReadLine());

        double scholarshipAmount = CalculateScholarship(marks, fees);
        Console.WriteLine($"Scholarship Amount: {scholarshipAmount:C}");
    }

    // Helper function for Scholarship Calculation
    private static double CalculateScholarship(int marks, double fees)
    {
        if (marks >= 70 && marks <= 80)
        {
            return 0.2 * fees; // 20% scholarship
        }
        else if (marks > 80 && marks <= 90)
        {
            return 0.3 * fees; // 30% scholarship
        }
        else if (marks > 90)
        {
            return 0.5 * fees; // 50% scholarship
        }
        else
        {
            return 0; // No scholarship
        }
    }

    // Function 5: Doctor Class with Properties
    public static void DoctorDetails()
    {
        Console.WriteLine("Doctor Details");

        Doctor doctor = new Doctor();
        doctor.RegnNo = 1001;
        doctor.Name = "Dr. John Doe";
        doctor.FeesCharged = 500;

        doctor.DisplayDoctorDetails();
    }

    // Main method to execute based on user choice
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Display First Name and Last Name in Upper Case");
            Console.WriteLine("2. Count occurrences of a letter in a string");
            Console.WriteLine("3. Banking System with Custom Exception");
            Console.WriteLine("4. Scholarship Calculation");
            Console.WriteLine("5. Doctor Details");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine()) ;
            
                switch (choice)
                {
                    case 1:
                        DisplayNames();
                        break;
                    case 2:
                        CountOccurrences();
                        break;
                    case 3:
                        BankingSystem();
                        break;
                    case 4:
                        Scholarship();
                        break;
                    case 5:
                        DoctorDetails();
                        break;
                    case 6:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 to 6.");
                        break;
                }
            
                    }
    }
}

// Custom Exception
public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException()
    {
    }

    public InsufficientBalanceException(string message)
        : base(message)
    {
    }

    public InsufficientBalanceException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}

// Example BankAccount class
public class BankAccount
{
    private double balance;

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive.");
        }

        balance += amount;
        Console.WriteLine($"Deposited {amount}. New balance: {balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive.");
        }

        if (balance < amount)
        {
            throw new InsufficientBalanceException("Insufficient balance.");
        }

        balance -= amount;
        Console.WriteLine($"Withdrawn {amount}. New balance: {balance}");
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Current balance: {balance}");
    }
}

// Example Doctor class
public class Doctor
{
    private int regnNo;
    private string name;
    private double feesCharged;

    public int RegnNo
    {
        get { return regnNo; }
        set { regnNo = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double FeesCharged
    {
        get { return feesCharged; }
        set { feesCharged = value; }
    }

    public void DisplayDoctorDetails()
    {
        Console.WriteLine($"Registration Number: {regnNo}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Fees Charged: {feesCharged:C}");
    }
}
