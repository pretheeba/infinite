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
            string  source_word = Console.ReadLine();
            string reversed_word = "";

            for (int i=source_word.Length-1; i>=0;i--)
            {
                reversed_word += source_word[i];
            }
            Console.WriteLine("The word entered is :" + source_word);
            Console.WriteLine("The word reversed is :"reversed_word);
            Console.ReadLine();
        }
    }
}
