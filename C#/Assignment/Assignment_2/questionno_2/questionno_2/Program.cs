using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionno_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int num = int.Parse(Console.ReadLine());

            switch(num)
            {
                case 1:
                    Console.WriteLine("Monday");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    Console.ReadLine();

                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    Console.ReadLine();

                    break;
                case 4:
                    Console.WriteLine("Thrusday");
                    Console.ReadLine();

                    break;
                case 5:
                    Console.WriteLine("Friday");
                    Console.ReadLine();

                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    Console.ReadLine();

                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    Console.ReadLine();

                    break;

                default:
                    Console.WriteLine("Enter a valid number");
                    Console.ReadLine();
                    break;



            }
        }
    }
}
