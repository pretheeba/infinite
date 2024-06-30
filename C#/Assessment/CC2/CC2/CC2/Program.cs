using System;
using System.Collections.Generic;

public abstract class Student
{
    public string Name { get; set; }
    public int StudentId { get; set; }
    public double Grade { get; set; }

    public abstract bool IsPassed(double grade);
}

public class Undergraduate : Student
{
    public override bool IsPassed(double grade)
    {
        return grade > 70.0;
    }
}

public class Graduate : Student
{
    public override bool IsPassed(double grade)
    {
        return grade > 80.0;
    }
}

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }
}

public class ProductPriceComparer : IComparer<Product>
{
    public int Compare(Product x, Product y)
    {
        return x.Price.CompareTo(y.Price);
    }
}

class Program
{
    static void ProcessNumber(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Number cannot be negative.");
        }

        Console.WriteLine($"Processing number: {number}");
    }

    static void Main()
    {
        Undergraduate undergrad = new Undergraduate();

        Console.WriteLine("Enter Undergraduate Student details:");
        Console.Write("Name: ");
        undergrad.Name = Console.ReadLine();

        Console.Write("Student ID: ");
        undergrad.StudentId = int.Parse(Console.ReadLine());

        Console.Write("Grade: ");
        undergrad.Grade = double.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine($"Undergraduate Student: {undergrad.Name}, ID: {undergrad.StudentId}");
        Console.WriteLine($"Grade: {undergrad.Grade}, Passed: {undergrad.IsPassed(undergrad.Grade)}");

        Console.WriteLine();

        Graduate grad = new Graduate();

        Console.WriteLine("Enter Graduate Student details:");
        Console.Write("Name: ");
        grad.Name = Console.ReadLine();

        Console.Write("Student ID: ");
        grad.StudentId = int.Parse(Console.ReadLine());

        Console.Write("Grade: ");
        grad.Grade = double.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine($"Graduate Student: {grad.Name}, ID: {grad.StudentId}");
        Console.WriteLine($"Grade: {grad.Grade}, Passed: {grad.IsPassed(grad.Grade)}");

        Console.WriteLine();

        List<Product> products = new List<Product>();

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Enter details for Product {i}:");

            Product product = new Product();

            product.ProductId = i;

            Console.Write("Enter Product Name: ");
            product.ProductName = Console.ReadLine();


            Console.Write("Enter Product price: ");
            product.Price = int.Parse(Console.ReadLine());

            products.Add(product);

            Console.WriteLine();
        }

        products.Sort(new ProductPriceComparer());

        Console.WriteLine("Sorted Products based on Price:");
        Console.WriteLine("-----------------------------");
        foreach (var product in products)
        {
            Console.WriteLine($"Product ID: {product.ProductId}");
            Console.WriteLine($"Product Name: {product.ProductName}");
            Console.WriteLine($"Price: {product.Price}");
            Console.WriteLine();
        }

        Console.WriteLine();

        try
        {
            Console.Write("Enter a number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            ProcessNumber(inputNumber);
        }
        catch (FormatException)
        {
            Console.WriteLine("Input must be a valid integer.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }

        Console.ReadLine();
    }
}
