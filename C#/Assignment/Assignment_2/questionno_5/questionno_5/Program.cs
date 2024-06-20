using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionno_5
{
    class Program
    {
        static void Main()
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
            for (int i=0; i< numElements; i++)
            {
                destination_array[i] = source_array[i];
            }

            Console.WriteLine("The elements in source array");
            foreach (int num in source_array)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("The elements in destination array");

            foreach (int nums in destination_array)
            {
                Console.WriteLine(nums);
            }
            Console.ReadLine();
        }
    }
}
