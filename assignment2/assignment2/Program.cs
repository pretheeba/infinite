﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.Write("Enter the Integer: ");
                int number = int.Parse(Console.ReadLine());

                if (number > 0)
                {
                    Console.WriteLine("The number is positive");
                }
                else if(number < 0 )
                {
                    Console.WriteLine("The number is negative");
                }
            else
            {
                Console.WriteLine("The number is zero");
            }
                Console.ReadLine();

            }
        }
    }


