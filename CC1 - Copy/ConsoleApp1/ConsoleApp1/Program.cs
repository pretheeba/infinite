using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remove
{
    class replacing
    {
        static void Main(string[] args)
        {
            string input = "Python";
            string result = ExchangeFirstandLastCharacter(input);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static string ExchangeFirstandLastCharacter(string input)
        {
            if (input.Length <= 1)
            {
                return input;
            }
            char firstchar = input[0];
            char lastchar = input[input.Length - 1];
            string middle = input.Substring(1, input.Length - 2);
            String result = lastchar + middle + firstchar;
            return result;
        }



    }

}
