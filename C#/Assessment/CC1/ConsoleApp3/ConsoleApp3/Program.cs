using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remove
{
    class Largest
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int largest = FindLargestNumber(num1, num2, num3);
            Console.WriteLine(largest);
            Console.ReadLine();
        }
        static int FindLargestNumber(int a, int b, int c)
        {
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            return max;
        }
    }
}


