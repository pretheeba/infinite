using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionno_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word :");
            string word = Console.ReadLine();
            int count = 0;

            for (int i =0;i<word.Length;i++)
            {
                
                count++;
            }
            Console.WriteLine("The length of the word is :"+count);
            Console.ReadLine();
        }
    }
}
