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

            if (input == "1")
            {
                PointsCalculation();
            }
            else if (input == "2")
            {
                AddBoxes();
            }
            else if (input == "3")
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
            }

            Console.WriteLine();
        }
    }

    public static void PointsCalculation()
    {
        Console.WriteLine("You selected to calculate Points in IPL.");

        int numberOfMatches = 0;
        bool isValidNumberOfMatches = false;

        while (!isValidNumberOfMatches)
        {
            Console.Write("Enter the number of matches: ");
            string input = Console.ReadLine();
            try
            {
                numberOfMatches = int.Parse(input);
                if (numberOfMatches > 0)
                {
                    isValidNumberOfMatches = true;
                }
                else
                {
                    Console.WriteLine("Number of matches must be greater than zero.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        int[] scores = new int[numberOfMatches];
        int sum = 0;

        for (int i = 0; i < numberOfMatches; i++)
        {
            bool isValidScore = false;
            while (!isValidScore)
            {
                Console.Write($"Enter score for match {i + 1}: ");
                string scoreInput = Console.ReadLine();

                try
                {
                    scores[i] = int.Parse(scoreInput);
                    isValidScore = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            sum += scores[i];
        }

        double average = (double)sum / numberOfMatches;

        Console.WriteLine($"Sum of scores: {sum}");
        Console.WriteLine($"Average score: {average:F2}");
    }

    public static void AddBoxes()
    {
        Console.WriteLine("You selected to add Boxes.");
        Console.WriteLine("Enter details for Box 1:");

        Box box1 = GetBoxDetails();
        Console.WriteLine("\nEnter details for Box 2:");

        Box box2 = GetBoxDetails();

        Box box3 = box1 + box2;

        Console.WriteLine("\nResulting Box (Box 3):");
        Console.WriteLine(box3);
    }

    private static Box GetBoxDetails()
    {
        double length = 0;
        double breadth = 0;
        bool isValidLength = false;
        bool isValidBreadth = false;

        while (!isValidLength)
        {
            Console.Write("Enter length of the box: ");
            string lengthInput = Console.ReadLine();

            try
            {
                length = double.Parse(lengthInput);
                if (length > 0)
                {
                    isValidLength = true;
                }
                else
                {
                    Console.WriteLine("Length should be a positive number.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        while (!isValidBreadth)
        {
            Console.Write("Enter breadth of the box: ");
            string breadthInput = Console.ReadLine();

            try
            {
                breadth = double.Parse(breadthInput);
                if (breadth > 0)
                {
                    isValidBreadth = true;
                }
                else
                {
                    Console.WriteLine("Breadth should be a positive number.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        return new Box(length, breadth);
    }
}

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
