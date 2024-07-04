using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice:");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    name();
                    break;
                case 2:
                    sum();
                    break;
                case 3:
                    divide();
                    break;
                case 4:
                    Console.WriteLine("Enter four value :");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int c = int.Parse(Console.ReadLine());
                    int d = int.Parse(Console.ReadLine());
                    operation(a,b,c,d);
                    break;
                case 5:
                    swap(1, 2);
                    break;
                case 6:
                    Console.WriteLine("Enter first number : ");
                    int fir = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Second number : ");
                    int sec = int.Parse(Console.ReadLine()); 
                    arithmetic( fir, sec);
                    break;
                case 7:
                    Console.WriteLine("Enter first number : ");
                    int var1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Second number : ");
                    int var2 = int.Parse(Console.ReadLine());
                    arithmetic(var1, var2);
                    break;
                case 8:
                    Console.WriteLine("Enter a value :");
                    int e = int.Parse(Console.ReadLine());
                    multiplication(e);
                    break;
                case 9:
                    average();
                    break;


                default:
                    Console.WriteLine("Enter valid choice");
                    break;



            }
        }
        public static void name()
        {
            Console.WriteLine("Enter your name :");
            String name = Console.ReadLine();
            Console.WriteLine("Hii");
            Console.WriteLine(name);
            Console.ReadLine();
        }
        public static void sum()
        {
            Console.WriteLine("Enter first number : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum is : " + (a + b));
            Console.ReadLine();
        }
        public static void divide()
        {
            Console.WriteLine("Enter first number : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum is : " + (a / b));
            Console.ReadLine();
        }
        public static void operation(int a,int b,int c,int d)
        {
            System.Console.WriteLine(-a + b * c); 
            System.Console.WriteLine((a + b) % c);
            System.Console.WriteLine(a + -b * c / d); 
            Console.ReadLine();
        }
        public static void swap(int a,int b)
        {
            Console.WriteLine("Before swaping");
            Console.WriteLine("The value of a : " + a);
            Console.WriteLine("The value of b : " + b);
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swaping");
            Console.WriteLine("The value of a : " + a);
            Console.WriteLine("The value of b : " + b);

            Console.ReadLine();
        }
        public static void arithmetic(int a,int b)
        {
            Console.WriteLine("Enter your choice :");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("The sum is : " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("The sum is : " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("The sum is : " + (a * b));
                    break;
                case 4:
                    Console.WriteLine("The sum is : " + (a / b));
                    break;
                default:
                    Console.WriteLine("valid choice");
                    break;
            }
            Console.ReadLine();
        }
        public static void multiplication(int n)
        {
            for(int i=0;i<=10;i++)
            {
                Console.WriteLine(i + "*" + n + "=" + (i * n));
            }
            Console.ReadLine();
        }
        public static void average()
        {
            Console.WriteLine("Enter first number : ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number : ");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number : ");
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fourth number : ");
            int fourth = int.Parse(Console.ReadLine());
            Console.WriteLine((first + second + third + fourth) / 4);
            Console.ReadLine();

        }
    }
}
