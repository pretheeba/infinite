﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace space
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number : ");
            int num = int.Parse(Console.ReadLine());

            for (int i=0;i<2;i++)
            {
                Console.WriteLine("{0} {0} {0} {0}",num);
                Console.WriteLine("{0}{0}{0}{0}",num);

            }
            Console.ReadLine();
        }
    }
}
