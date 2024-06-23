using System;

public class Saledetails
{
    // Data members/fields
    private int SalesNo;
    private int ProductNo;
    private double Price;
    private DateTime DateofSale;
    private int Qty;
    private double TotalAmount;

    // Constructor to initialize the sales details
    public Saledetails(int salesNo, int productNo, double price, int qty, DateTime dateofSale)
    {
        this.SalesNo = salesNo;
        this.ProductNo = productNo;
        this.Price = price;
        this.Qty = qty;
        this.DateofSale = dateofSale;

        // Calculate total amount based on initial values
        Sales();
    }

    // Method to update TotalAmount based on Qty and Price
    public void Sales()
    {
        TotalAmount = Qty * Price;
    }

    // Method to display sale details
    public void ShowData()
    {
        Console.WriteLine($"Sales Number: {SalesNo}");
        Console.WriteLine($"Product Number: {ProductNo}");
        Console.WriteLine($"Price per unit: {Price:C}");
        Console.WriteLine($"Quantity: {Qty}");
        Console.WriteLine($"Date of Sale: {DateofSale.ToShortDateString()}");
        Console.WriteLine($"Total Amount: {TotalAmount:C}");
        Console.ReadLine();
    }

    // Main method for testing
    public static void Main(string[] args)
    {
        // Input variables
        int salesNo, productNo, qty;
        double price;
        DateTime dateofSale;

        // Get input from user for sale details
        Console.WriteLine("Enter Sales Number:");
        salesNo = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Product Number:");
        productNo = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Price per unit:");
        price = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Quantity:");
        qty = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Date of Sale (MM/DD/YYYY):");
        if (!DateTime.TryParse(Console.ReadLine(), out dateofSale))
        {
            Console.WriteLine("Invalid date format. Please use MM/DD/YYYY format.");
            return;
        }

        // Create an instance of Saledetails
        Saledetails sale = new Saledetails(salesNo, productNo, price, qty, dateofSale);

        // Display sale details
        sale.ShowData();
    }
}
