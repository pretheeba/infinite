using System;
using System.Linq;

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
                Console.WriteLine("1. Calculate sum or triple sum if numbers are equal");
                Console.WriteLine("2. Print day of the week");
                Console.WriteLine("3. Calculate average, min, and max of marks");
                Console.WriteLine("4. Calculate total, average, min, max, and sort marks");
                Console.WriteLine("5. Copy elements from one array to another");
                Console.WriteLine("6. Calculate length of a word");
                Console.WriteLine("7. Compare two words character by character");
                Console.WriteLine("8. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        SumOrTripleSum();
                        break;
                    case 2:
                        PrintDayOfWeek();
                        break;
                    case 3:
                        CalculateMarksStats(false);
                        break;
                    case 4:
                        CalculateMarksStats(true);
                        break;
                    case 5:
                        CopyArrayElements();
                        break;
                    case 6:
                        CalculateWordLength();
                        break;
                    case 7:
                        CompareWords();
                        break;
                    case 8:
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please enter a valid choice.");
                        break;
                }
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }

        static void SumOrTripleSum()
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            if (num1 == num2)
            {
                sum *= 3;
            }
            Console.WriteLine("Result: " + sum);
        }

        static void PrintDayOfWeek()
        {
            Console.WriteLine("Enter a number (1-7):");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Enter a valid number");
                    break;
            }
        }

        static void CalculateMarksStats(bool includeSort)
        {
            Console.Write("Enter the number of marks in the array: ");
            int numElements = int.Parse(Console.ReadLine());

            int[] array = new int[numElements];

            for (int i = 0; i < numElements; i++)
            {
                Console.Write($"Enter mark {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("=================================");

            int total = array.Sum();
            double average = array.Average();
            int min = array.Min();
            int max = array.Max();

            Console.WriteLine("Total marks: " + total);
            Console.WriteLine("Average mark of array elements: " + average);
            Console.WriteLine("Minimum mark in the array: " + min);
            Console.WriteLine("Maximum mark in the array: " + max);

            if (includeSort)
            {
                Array.Sort(array);
                Console.WriteLine("Marks in Ascending order:");
                foreach (int num in array)
                {
                    Console.WriteLine(num);
                }
                Array.Reverse(array);
                Console.WriteLine("Marks in Descending order:");
                foreach (int num in array)
                {
                    Console.WriteLine(num);
                }
            }
        }

        static void CopyArrayElements()
        {
            Console.Write("Enter the number of marks in the array: ");
            int numElements = int.Parse(Console.ReadLine());

            int[] source_array = new int[numElements];
            int[] destination_array = new int[numElements];

            for (int i = 0; i < numElements; i++)
            {
                Console.Write($"Enter mark {i + 1}: ");
                source_array[i] = int.Parse(Console.ReadLine());
            }
            Array.Copy(source_array, destination_array, numElements);

            Console.WriteLine("The elements in the source array:");
            foreach (int num in source_array)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("The elements in the destination array:");
            foreach (int num in destination_array)
            {
                Console.WriteLine(num);
            }
        }

        static void CalculateWordLength()
        {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();
            int count = word.Length;
            Console.WriteLine("The length of the word is: " + count);
        }

        static void CompareWords()
        {
            Console.WriteLine("Enter the first word:");
            string first_word = Console.ReadLine();
            Console.WriteLine("Enter the second word:");
            string second_word = Console.ReadLine();

            if (first_word.Length != second_word.Length)
            {
                Console.WriteLine("Both are different");
                return;
            }

            for (int i = 0; i < first_word.Length; i++)
            {
                if (first_word[i] != second_word[i])
                {
                    Console.WriteLine("Both are different");
                    return;
                }
            }
            Console.WriteLine("Both are the same");
        }
    }
}
