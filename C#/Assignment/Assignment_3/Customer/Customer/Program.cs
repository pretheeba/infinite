using System;

public class Customer
{
    // Data members/fields
    private int customerId;
    private string name;
    private int age;
    private string phone;
    private string city;

    // Constructor with no arguments
    public Customer()
    {
        // Default constructor
    }

    // Constructor with all information
    public Customer(int customerId, string name, int age, string phone, string city)
    {
        this.customerId = customerId;
        this.name = name;
        this.age = age;
        this.phone = phone;
        this.city = city;
    }

    // Method to display customer information
    public void DisplayCustomer()
    {
        Console.WriteLine($"Customer ID: {customerId}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Phone: {phone}");
        Console.WriteLine($"City: {city}");
        Console.ReadLine();
    }

    // Destructor
    ~Customer()
    {
        Console.WriteLine($"Destructor called for Customer {customerId}");
        Console.ReadLine();
    }

    // Static method to display customer information without object
    public static void DisplayCustomerInfo(int customerId, string name, int age, string phone, string city)
    {
        Console.WriteLine($"Customer ID: {customerId}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Phone: {phone}");
        Console.WriteLine($"City: {city}");
        Console.ReadLine();
    }

    // Main method for testing
    public static void Main(string[] args)
    {
        // Create an instance of Customer using constructor with all information
        Customer customer1 = new Customer(1, "John Doe", 30, "123-456-7890", "New York");

        // Display customer information using instance method
        Console.WriteLine("Displaying customer information using instance method:");
        customer1.DisplayCustomer();
        Console.WriteLine();

        // Display customer information using static method (without object)
        Console.WriteLine("Displaying customer information using static method:");
        DisplayCustomerInfo(2, "Jane Smith", 25, "987-654-3210", "Los Angeles");
        Console.WriteLine();

        // Demonstrate destructor
        Console.WriteLine("Demonstrating destructor:");
        Customer customer2 = new Customer(3, "Michael Johnson", 45, "456-789-0123", "Chicago");
        customer2 = null; // Setting reference to null to invoke destructor
        GC.Collect(); // Triggering garbage collection to ensure destructor is called
    }
}
