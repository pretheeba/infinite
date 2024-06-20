using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionno_4
{
    class Program
    {
        static void Main()
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
            int total = 0;
            foreach (int num in array)
            {
                total += num;
            }

            double average = array.Average();

            int min = array[0];
            int max = array[0];

            foreach (int num in array)
            {
                if (num < min)
                    min = num;
                if (num > max)
                    max = num;
            }

            Console.WriteLine("The total mark is : " + total);
            Console.WriteLine($"Average mark of array elements: {average}");
            Console.WriteLine($"Minimum mark in the array: {min}");
            Console.WriteLine($"Maximum mark in the array: {max}");

            Array.Sort(array);
            Console.WriteLine("The marks in Ascending order..");
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
            Array.Reverse(array);
            Console.WriteLine("The marks in Descending order..");
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
