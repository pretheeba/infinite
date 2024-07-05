using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the radius for the circle : ");
        int radius = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the width for the circle : ");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height for the circle : ");
        int height = int.Parse(Console.ReadLine());


        IShape circle = new Circle(radius);
        Console.WriteLine($"Circle - Area: {circle.CalculateArea()}, Perimeter: {circle.CalculatePerimeter()}");

        IShape rectangle = new Rectangle(width, height);
        Console.WriteLine($"Rectangle - Area: {rectangle.CalculateArea()}, Perimeter: {rectangle.CalculatePerimeter()}");

        Console.ReadKey();
    }
}
