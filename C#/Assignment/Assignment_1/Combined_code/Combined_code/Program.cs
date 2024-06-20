using System;

namespace CombinedProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Check if two integers are equal");
                Console.WriteLine("2. Check if an integer is positive, negative, or zero");
                Console.WriteLine("3. Perform arithmetic operations");
                Console.WriteLine("4. Swap two numbers");
                Console.WriteLine("5. Print number in patterns");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CheckEqualIntegers();
                        break;
                    case 2:
                        CheckPositiveNegativeZero();
                        break;
                    case 3:
                        PerformArithmeticOperations();
                        break;
                    case 4:
                        SwapNumbers();
                        break;
                    case 5:
                        PrintNumberPatterns();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please enter a valid choice.");
                        break;
                }
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }

        static void CheckEqualIntegers()
        {
            Console.Write("Enter the First Integer: ");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second Integer: ");
            int secondnumber = int.Parse(Console.ReadLine());

            if (firstnumber == secondnumber)
            {
                Console.WriteLine("Two integers are equal");
            }
            else
            {
                Console.WriteLine("Two integers are not equal");
            }
        }

        static void CheckPositiveNegativeZero()
        {
            Console.Write("Enter the Integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The number is zero");
            }
        }

        static void PerformArithmeticOperations()
        {
            Console.Write("Enter the First Integer: ");
            double firstnumber = double.Parse(Console.ReadLine());
            Console.Write("Enter the Second Integer: ");
            double secondnumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose an arithmetic operator:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter the number corresponding to the operation: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    double addition = firstnumber + secondnumber;
                    Console.WriteLine($"Addition: {firstnumber} + {secondnumber} = {addition}");
                    break;
                case 2:
                    double subtraction = firstnumber - secondnumber;
                    Console.WriteLine($"Subtraction: {firstnumber} - {secondnumber} = {subtraction}");
                    break;
                case 3:
                    double multiplication = firstnumber * secondnumber;
                    Console.WriteLine($"Multiplication: {firstnumber} * {secondnumber} = {multiplication}");
                    break;
                case 4:
                    if (secondnumber != 0)
                    {
                        double division = firstnumber / secondnumber;
                        Console.WriteLine($"Division: {firstnumber} / {secondnumber} = {division}");
                    }
                    else
                    {
                        Console.WriteLine("Dividing by Zero is not allowed");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice, please enter a valid choice.");
                    break;
            }
        }

        static void SwapNumbers()
        {
            Console.Write("Enter 1st number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("First number before swap: " + first);
            Console.WriteLine("Second number before swap: " + second);

            int temp = first;
            first = second;
            second = temp;

            Console.WriteLine("First number after swap using temp: " + first);
            Console.WriteLine("Second number after swap using temp: " + second);

            Console.Write("Enter 1st number again: ");
            first = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number again: ");
            second = int.Parse(Console.ReadLine());

            first = first + second;
            second = first - second;
            first = first - second;

            Console.WriteLine("First number after swap without using temp: " + first);
            Console.WriteLine("Second number after swap without using temp: " + second);
        }

        static void PrintNumberPatterns()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0} {0} {0} {0}", num);
                Console.WriteLine("{0}{0}{0}{0}", num);
            }
        }
    }
}
