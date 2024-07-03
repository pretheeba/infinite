using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_2
{
    class parent
    {
        int x;
        public parent(int i)
        {
            x = i;
            Console.WriteLine("Parent class : " + x);

        }
    }
    class child : parent
    {
        int y;
        public child(int a, int b) : base(a)
        {
            Console.WriteLine("Child class");
            y = b;
            Console.WriteLine("child class : " + y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            parent p = new parent(10);
            child c = new child(2, 3);
            Console.ReadLine();
        }
    }
}
