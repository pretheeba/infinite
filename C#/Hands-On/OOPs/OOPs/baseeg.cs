using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class parent
    {
        int x;
        public parent(int i)
        {
            x = i;
            Console.WriteLine("The parent value is :" + x);
        }
    }
    class baseclass
    {
        public static void main(String[]args)
        {
            parent p = new parent(10);
            
        }
    }
}
