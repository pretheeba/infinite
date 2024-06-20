using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionno_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number :");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number :");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;

            if(num1 == num2)
            {
                sum *= 3;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
