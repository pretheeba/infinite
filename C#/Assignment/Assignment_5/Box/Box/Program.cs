using System;

public class Box
{
    public double Length { get; set; }
    public double Breadth { get; set; }

    public Box(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }

    public void Display()
    {
        Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
    }

    public static Box Add(Box box1, Box box2)
    {
        double newLength = box1.Length + box2.Length;
        double newBreadth = box1.Breadth + box2.Breadth;
        return new Box(newLength, newBreadth);
    }
}

public class Test
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter dimensions for Box 1:");
        Console.Write("Length: ");
        double length1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Breadth: ");
        double breadth1 = Convert.ToDouble(Console.ReadLine());
        Box box1 = new Box(length1, breadth1);

        Console.WriteLine("\nEnter dimensions for Box 2:");
        Console.Write("Length: ");
        double length2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Breadth: ");
        double breadth2 = Convert.ToDouble(Console.ReadLine());
        Box box2 = new Box(length2, breadth2);

        Box box3 = Box.Add(box1, box2);

        Console.WriteLine("\nBox 1:");
        box1.Display();
        Console.WriteLine();

        Console.WriteLine("Box 2:");
        box2.Display();
        Console.WriteLine();

        Console.WriteLine("Box 3 (Result of Addition):");
        box3.Display();

        Console.ReadLine();
    }
}
