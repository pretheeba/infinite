using System;
using System.Collections.Generic;
using System.IO;
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
            switch (choice)
            {
                case 1:
                    age();
                    break;
                case 2:
                    Console.WriteLine("enter a number :");
                    int num = int.Parse(Console.ReadLine());
                    space(num);
                    break;
                case 3:
                    Console.WriteLine("enter a number :");
                    num = int.Parse(Console.ReadLine());
                    num_space(num);
                    break;
                case 4:
                    Console.WriteLine("Enter celsius :");
                    int celsius = int.Parse(Console.ReadLine());
                    temp(celsius);
                    break;
                case 5:
                    remove();
                    break;
                case 6:
                    replace();
                    break;
                case 7:
                    add();
                    break;
                case 8:
                    check();
                    break;
                case 9:
                    equal();
                    break;
                case 10:
                    equaldouble();
                    break;
                case 11:
                    great();
                    break;
                //case 12:
                //    CheckNumberRange();
                //    break;
                case 13:
                    lower();
                    break;
                case 14:
                    odd();
                    break;
                case 15:
                    prime();
                    break;
                case 16:
                    digit();
                    break;
                case 17:
                    file();
                    break;
                case 18:
                    LastFour();
                    break;
                case 19:
                    three();
                    break;
                case 20:
                    start();
                    break;
                case 21:
                    First();
                    break;
                case 22:
                    number();
                    break;
                case 23:
                    hp();
                    break;
                case 24:
                    large();
                    break;
                case 25:
                    twenty();
                    break;
                case 26:
                    upper();
                    break;
                case 27:
                    even();
                    break;
                case 28:
                    count();
                    break;
                case 29:
                    find();
                    break;
                case 30:
                    sum();
                    break;
                case 31:
                    first();
                    break;
                case 32:
                    reverse();
                    break;
                case 34:
                    rotate();
                    break;
                case 33:
                    largest();
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
        public static void space(int num)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0} {0} {0} {0}", num);
                Console.WriteLine("{0}{0}{0}{0}", num);
            }
            Console.ReadLine();
        }
        public static void num_space(int num)
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("{0}{0}{0}", num);
                Console.WriteLine("{0} {0}", num);
                Console.WriteLine("{0} {0}", num);
                Console.WriteLine("{0} {0}", num);
                Console.WriteLine("{0}{0}{0}", num);
            }
            Console.ReadLine();
        }
        public static void temp(int celsius)
        {
            int fahrenheit = (celsius * 18 / 10 + 32);
            int kelvin = celsius + 273;
            Console.WriteLine("Fahrenheit : " + fahrenheit);
            Console.WriteLine("Kelvin : " + kelvin);
            Console.ReadLine();
        }
        public static void remove()
        {
            Console.WriteLine("Enter a word : ");
            String word = Console.ReadLine();
            Console.WriteLine(word.Remove(0, 1));
            Console.ReadLine();
        }
        public static void replace()
        {
            Console.WriteLine("Enter a word");
            String sen = Console.ReadLine();
            char firstword = sen[0];
            char lastword = sen[sen.Length - 1];
            String mid = sen.Substring(1, (sen.Length - 1));
            Console.WriteLine("The replaced string is : {0}{1}{2}", lastword, mid, firstword);
            Console.WriteLine(firstword);
            Console.ReadLine();
        }
        public static void add()
        {
            Console.WriteLine("Enter a word");
            String sentence = Console.ReadLine();
            char first = sentence[0];
            Console.WriteLine(first + sentence + first);
            Console.ReadLine();
        }
        public static void check()
        {
            Console.WriteLine("\nInput first integer:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second integer:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Check if one is negative and one is positive:");

            Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
            Console.ReadLine();
        }
        public static void equal()
        {
            Console.WriteLine("Enter two values : ");
            int v1 = int.Parse(Console.ReadLine());
            int v2 = int.Parse(Console.ReadLine());
            if (v1 == v2)
            {
                Console.WriteLine((v1 + v2) * 3);
            }
            Console.WriteLine(v1 == v2 ? (v1 + v2) * 3 : v1 + v2);
            Console.ReadLine();
        }
        public static void equaldouble()
        {
            Console.WriteLine("Enter two values : ");
            int v1 = int.Parse(Console.ReadLine());
            int v2 = int.Parse(Console.ReadLine());

            Console.WriteLine(v1 > v2 ? (v1 - v2) * 2 : v2 - v1);
            Console.ReadLine();
        }
        public static void great()
        {
            Console.WriteLine("Enter two values : ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            bool result = (n1 + n2 == 20) || (n1 == 20) || (n2 == 20);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        //public static void CheckNumberRange()
        //{
        //    Console.WriteLine("Input an integer:");
        //    int num = int.Parse(Console.ReadLine());

        //    bool result = (num >= 80 && num <= 120) || (num >= 180 && num <= 220);

        //    Console.WriteLine(result);
        //    Console.ReadLine();

        //}
        public static void lower()
        {
            string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            Console.WriteLine(line.ToLower());
            Console.ReadLine();
        }
        //24. Write a C# program to find the longest word in a string.

        public static void odd()
        {
            for (int i = 1; i <= 99; i++)
            {
                if ((i % 2) != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
        public static void prime()
        {
            for (int i = 2; i <= 500; i++)
            {
                bool isPrime = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
        public static void digit()
        {
            Console.WriteLine("Enter a number : ");
            int digit = int.Parse(Console.ReadLine());
            int sum = 0;
            while (digit != 0)
            {
                sum += digit % 10;
                digit /= 10;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        //28. Write a C# program to reverse the words of a sentence.
        //Sample Output:
        //Original String: Display the pattern like pyramid using the alphabet.
        //Reverse String: alphabet.the using pyramid like pattern the Display
        public static void file()
        {
            FileInfo f = new FileInfo("/home/students/abc.txt");
            Console.WriteLine("\nSize of a file: " + f.Length.ToString());
            Console.ReadLine();
        }
        public static void AddArray()
        {
            int[] first_array = { 1, 3, -5, 4 };
            int[] second_array = { 1, 4, -5, -2 };
            for (int i = 0; i < first_array.Length; i++)
            {
                Console.Write(first_array[i] * second_array[i] + " ");
            }
            Console.ReadLine();
        }
        public static void LastFour()
        {
            Console.WriteLine("Enter sentence : ");
            String last = Console.ReadLine();
            if (last.Length < 4)
            {
                Console.WriteLine(last);
                Console.ReadLine();
            }
            else
            {
                string lastFourChars = last.Substring(last.Length - 4); 
                Console.WriteLine(string.Concat(lastFourChars, lastFourChars, lastFourChars, lastFourChars));
                Console.ReadLine();
            }
        }
        public static void three()
        {
            Console.WriteLine("Enter number : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine((n % 3 == 0) || (n % 7 == 0));
            Console.ReadLine();
        }
        public static void start()
        {
            Console.WriteLine("Enter a sentence : ");
            String m = Console.ReadLine();
            Console.WriteLine(m.StartsWith("Hello"));
            Console.ReadLine();
        }
        public static void First()
        {
            Console.WriteLine("Enter first number :");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number :");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine( (num1 < 100 && num2 > 200) );
            Console.ReadLine();
        }
        public static void number()
        {
            Console.WriteLine("Enter number :");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine((num >= -10 && num <= 10));
            Console.ReadLine();
        }
        public static void hp()
        {
            Console.WriteLine("Enter a sentence : ");
            String m = Console.ReadLine();
            Console.WriteLine((m.Substring(1, 2).Equals("HP"))?m.Remove(1,2):m);
            Console.ReadLine();
        }
        public static void large()
        {
            Console.WriteLine("Enter 1st value : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd value : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd value : ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Largest of three: " + Math.Max(a, Math.Max(b , c)));
            Console.WriteLine("Lowest of three: " + Math.Min(a, Math.Min(b, c)));
            Console.ReadLine();
        }
        public static void twenty()
        {
            Console.WriteLine("Enter 1st value : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd value : ");
            int b = int.Parse(Console.ReadLine());
            int n = 20;
            Console.WriteLine(a == b ? 0 : (a > b) ? a : b);
            Console.ReadLine();
        }
        public static void upper()
        {
            Console.WriteLine("Enter String : ");
            string a = Console.ReadLine();
            int count = a.Count();
            Console.WriteLine(count < 4 ? a.ToUpper() : a.ToLower());
            Console.ReadLine();
        }
        public static void even()
        {
            Console.WriteLine("Enter string : ");
            string str = Console.ReadLine();
            String result = String.Empty;
           
            for (var i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                    result += str[i];
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static void count()
        {
            int[] arr = new int[5];
            for (int i = 0; i <= arr.Length-1;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter a value : ");
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for(int i = 0;i<arr.Length;i++)
            {
                if(arr[i] == n)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
        public static void find()
        {
            Console.WriteLine("Enter number of elements in an array : ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i <= arr.Length- 1; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter a number to find :");
            int f = int.Parse(Console.ReadLine());

            if(n>1)
            {
               if(arr.Length == f)
                {
                    Console.WriteLine("true");
                }
            }
            Console.WriteLine("false");
            Console.ReadLine();
        }
        public static void sum()
        {
            int[] arr = new int[5];
            int sum = 0;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                sum+=arr[i];
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        } 
        public static void first()
        {
            int[] arr = new int[5];
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine((arr[0] == arr[arr.Length-1]));
            Console.ReadLine();
        }
        public static void reverse()
        {
            int[] arr = new int[] { 1, 2, 3, 4 };
            int first = 0;
            int last = arr.Length - 1;
            while(first < last)
            {
                int temp = arr[first];
                arr[first] = arr[last];
                arr[last]= temp;
                first++;
                last--;
            }
            
            Console.WriteLine("Reversed array:");
            foreach (int element in arr)
            {
                Console.WriteLine(element + " ");
            }
            Console.ReadLine();
        }
        public static void rotate()
        {
                int[] arr = new int[] { 1, 2, 3};
                int temp = arr[0];
                for(int i=0;i<arr.Length-1;i++)
                {
                arr[i] = arr[i+1];
                }
            arr[arr.Length - 1] = temp;
                Console.WriteLine("Rotated array:");
                foreach (int element in arr)
                {
                    Console.WriteLine(element + " ");
                }
                Console.ReadLine();
            }
        public static void largest()
        {
            int[] arr = new int[]{ 1, 2, 3 };
            int max = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]>max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
    
