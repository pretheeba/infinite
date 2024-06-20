using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remove
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = { "Python", "Python", "Python" };
            int[] positions = { 1, 0, 4 };
            for (int i = 0; i < inputs.Length; i++)
            {
                string result = RemoveCharacterAt(inputs[i], positions[i]);
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
        static string RemoveCharacterAt(string input, int position)
        {
            return input.Remove(position, 1);
        }

    }
}
