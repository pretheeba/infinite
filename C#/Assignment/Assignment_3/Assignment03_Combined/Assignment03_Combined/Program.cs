using System;

public class CombinedProgram
{
    // Data members/fields for Accounts
    private long accountNo;
    private string customerName;
    private string accountType;
    private double balance;

    // Data members/fields for Customer
    private int customerId;
    private string customerNameCust;
    private int age;
    private string phone;
    private string city;

    // Data members/fields for SaleDetails
    private int salesNo;
    private int productNo;
    private double price;
    private DateTime dateofSale;
    private int qty;
    private double totalAmount;

    // Data members/fields for Student
    private int rollNo;
    private string name;
    private string studentClass;
    private string semester;
    private string branch;
    private int[] marks = new int[5];

    // Constructor for Accounts
    public CombinedProgram(long accountNo, string customerName, string accountType)
    {
        this.accountNo = accountNo;
        this.customerName = customerName;
        this.accountType = accountType;
        this.balance = 0; // Start with zero balance
    }

    // Constructor for Customer
    public CombinedProgram(int customerId, string name, int age, string phone, string city)
    {
        this.customerId = customerId;
        this.customerNameCust = name;
        this.age = age;
        this.phone = phone;
        this.city = city;
    }

    // Constructor for SaleDetails
    public CombinedProgram(int salesNo, int productNo, double price, int qty, DateTime dateofSale)
    {
        this.salesNo = salesNo;
        this.productNo = productNo;
        this.price = price;
        this.qty = qty;
        this.dateofSale = dateofSale;

        // Calculate total amount based on initial values
        CalculateTotalAmount();
    }

    // Constructor for Student
    public CombinedProgram(int rollNo, string name, string studentClass, string semester, string branch, int[] marks)
    {
        this.rollNo = rollNo;
        this.name = name;
        this.studentClass = studentClass;
        this.semester = semester;
        this.branch = branch;
        this.marks = marks;
    }

    // Method to calculate total amount based on Qty and Price (for SaleDetails)
    private void CalculateTotalAmount()
    {
        totalAmount = qty * price;
    }

    // Method to display account information
    public void ShowAccountData()
    {
        Console.WriteLine($"Account Number: {accountNo}");
        Console.WriteLine($"Customer Name: {customerName}");
        Console.WriteLine($"Account Type: {accountType}");
        Console.WriteLine($"Balance: {balance:C}");
        Console.WriteLine();
    }

    // Method to handle deposit (for Accounts)
    public void Credit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposit of {amount:C} successful. New balance: {balance:C}");
        Console.WriteLine();
    }

    // Method to handle withdrawal (for Accounts)
    public void Debit(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawal of {amount:C} successful. New balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient balance. Withdrawal failed.");
        }
        Console.WriteLine();
    }

    // Method to display customer information
    public void DisplayCustomer()
    {
        Console.WriteLine($"Customer ID: {customerId}");
        Console.WriteLine($"Name: {customerNameCust}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Phone: {phone}");
        Console.WriteLine($"City: {city}");
        Console.WriteLine();
    }

    // Method to display sale details
    public void ShowSaleData()
    {
        Console.WriteLine($"Sales Number: {salesNo}");
        Console.WriteLine($"Product Number: {productNo}");
        Console.WriteLine($"Price per unit: {price:C}");
        Console.WriteLine($"Quantity: {qty}");
        Console.WriteLine($"Date of Sale: {dateofSale.ToShortDateString()}");
        Console.WriteLine($"Total Amount: {totalAmount:C}");
        Console.WriteLine();
    }

    // Method to input marks for all 5 subjects (for Student)
    public void GetMarks()
    {
        Console.WriteLine($"Enter marks for {name} (Roll No: {rollNo}):");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Subject {i + 1}: ");
            marks[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
    }

    // Method to calculate average marks and display result (for Student)
    public void DisplayResult()
    {
        Console.WriteLine($"Student Name: {name} (Roll No: {rollNo})");
        Console.WriteLine($"Class: {studentClass}, Semester: {semester}, Branch: {branch}");

        Console.WriteLine("Marks:");
        foreach (int mark in marks)
        {
            Console.WriteLine($"Subject: {mark}");
        }

        bool pass = true;
        foreach (int mark in marks)
        {
            if (mark < 35)
            {
                pass = false;
                break;
            }
        }

        if (pass)
            Console.WriteLine("Result: Pass");
        else
            Console.WriteLine("Result: Fail");
        Console.WriteLine();
    }

    // Main method for testing
    public static void Main(string[] args)
    {
        // Test accounts functionality
        CombinedProgram account = new CombinedProgram(1001, "John Doe", "Savings");
        account.ShowAccountData();
        account.Credit(500);
        account.Debit(200);
        account.ShowAccountData();

        // Test customer functionality
        CombinedProgram customer = new CombinedProgram(1, "Jane Smith", 30, "123-456-7890", "New York");
        customer.DisplayCustomer();

        // Test sale details functionality
        DateTime saleDate = new DateTime(2024, 6, 24);
        CombinedProgram sale = new CombinedProgram(1, 101, 25.50, 10, saleDate);
        sale.ShowSaleData();

        // Test student functionality
        int[] studentMarks = new int[] { 80, 75, 85, 90, 78 };
        CombinedProgram student = new CombinedProgram(1001, "John Doe", "B.Tech", "Semester 4", "Computer Science", studentMarks);
        student.GetMarks();
        student.DisplayResult();
    }
}
