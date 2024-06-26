﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionno_3
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

            Console.WriteLine($"Average mark of array elements: {average}");
            Console.WriteLine($"Minimum mark in the array: {min}");
            Console.WriteLine($"Maximum mark in the array: {max}");

            Console.ReadLine();
        }
    }
}
