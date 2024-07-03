using System;

public class MainProgram
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Calculate Points in IPL");
            Console.WriteLine("2. Add Boxes");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice (1-3): ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    PointsCalculation();
                    break;
                case "2":
                    AddBoxes();
                    break;
                case "3":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                    break;
            }

            Console.WriteLine();
        }
    }

    // Method for Question 1: Points Calculation in IPL
    public static void PointsCalculation()
    {
        Console.WriteLine("You selected to calculate Points in IPL.");

        int numberOfMatches = int.parse("Enter the number of matches: ", "Invalid input. Please enter a valid number.");

        if (numberOfMatches <= 0)
        {
            Console.WriteLine("Number of matches must be greater than zero.");
            return;
        }

        int[] scores = new int[numberOfMatches];
        int sum = 0;

        for (int i = 0; i < numberOfMatches; i++)
        {
            scores[i] = GetIntInput($"Enter score for match {i + 1}: ", "Invalid input. Please enter a valid number.");
            sum += scores[i];
        }

        double average = (double)sum / numberOfMatches;

        Console.WriteLine($"Sum of scores: {sum}");
        Console.WriteLine($"Average score: {average:F2}");
    }

    // Method for Question 2: Adding Boxes
    public static void AddBoxes()
    {
        Console.WriteLine("You selected to add Boxes.");

        Box box1 = GetBoxDetails("Box 1");
        Box box2 = GetBoxDetails("Box 2");

        Box box3 = box1 + box2;

        Console.WriteLine("\nResulting Box (Box 3):");
        Console.WriteLine(box3);
    }

    // Helper method to get integer input from user
    private static int GetIntInput(string prompt, string errorMessage)
    {
        int result;
        bool isValidInput;

        do
        {
            Console.Write(prompt);
            isValidInput = int.TryParse(Console.ReadLine(), out result);

            if (!isValidInput)
            {
                Console.WriteLine(errorMessage);
            }

        } while (!isValidInput);

        return result;
    }

    // Helper method to get Box details from user
    private static Box GetBoxDetails(string boxName)
    {
        Console.WriteLine($"Enter details for {boxName}:");
        double length = GetDoubleInput("Enter length of the box: ", "Invalid input. Length should be a positive number.");
        double breadth = GetDoubleInput("Enter breadth of the box: ", "Invalid input. Breadth should be a positive number.");

        return new Box(length, breadth);
    }

    // Helper method to get double input from user
    private static double GetDoubleInput(string prompt, string errorMessage)
    {
        double result;
        bool isValidInput;

        do
        {
            Console.Write(prompt);
            isValidInput = double.TryParse(Console.ReadLine(), out result);

            if (!isValidInput || result <= 0)
            {
                Console.WriteLine(errorMessage);
                isValidInput = false;
            }

        } while (!isValidInput);

        return result;
    }
}

// Box class for Question 2
public class Box
{
    public double Length { get; set; }
    public double Breadth { get; set; }

    public Box(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }

    public static Box operator +(Box box1, Box box2)
    {
        double newLength = box1.Length + box2.Length;
        double newBreadth = box1.Breadth + box2.Breadth;
        return new Box(newLength, newBreadth);
    }

    public override string ToString()
    {
        return $"Length: {Length}, Breadth: {Breadth}";
    }
}
