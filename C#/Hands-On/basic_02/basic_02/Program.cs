using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice : ");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    age();
                    break;
            }
        }
        public static void age()
        {
            int age;
            Console.Write("Enter your age ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("You look younger than {0} ", age);
            Console.ReadLine();
        }
    }
}
