﻿using System;


namespace equal
{
    class Program
    {
        static void Main(string[] args)
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
            Console.ReadLine();

        }
    }
}
