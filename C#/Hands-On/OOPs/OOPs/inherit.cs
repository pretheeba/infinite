using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class inherit
    {
        public class shape
        {
            public virtual void draw()
            {
                Console.WriteLine("Drawing");
            }
        }

        public class circle : shape
        {
            public override void draw()
            {
                Console.WriteLine("Circle");
            }
        }
    }
}
