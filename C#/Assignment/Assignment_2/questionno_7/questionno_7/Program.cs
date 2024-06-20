using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionno_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word :");
            string  first_word = Console.ReadLine();
            Console.WriteLine("Enter second word :");
            string second_word = Console.ReadLine();

            for (int i=0; i<first_word.Length;i++ )
            {
                if(first_word[i] != second_word[i])
                {
                    Console.WriteLine("Both are different");
                    Console.ReadLine();
                }
                
                
            }
            Console.WriteLine(" both are Same");
            Console.ReadLine();
        }
    }
}
