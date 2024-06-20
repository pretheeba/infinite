using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remove
{
    class multiplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number :");
            int number = int.Parse(Console.ReadLine());
            PrintMultiplicationTable(number);
        }

        static void PrintMultiplicationTable(int number)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
            Console.ReadLine();

        }
    }
}
