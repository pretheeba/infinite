using System;

namespace OOPs
{
    class Program
    {
        static void Main(string[] args)
        {
            var tit = 6764_845_8495;
            Console.WriteLine(tit);

            Structeg eg = new Structeg();
            eg.UseStruct();

            basic b = new basic();
            Console.WriteLine(b.name = "Pretheeba");
            Console.WriteLine(b.age = 21);

            basic.Welcome("Pretheeba");

            inherit.shape s = new inherit.shape();
            inherit.circle c = new inherit.circle();

            s.draw();
            c.draw();

            local_function();

            constructer cs = new constructer();
            cs.print();  // Check if this prints "HIi"
            Console.WriteLine("Calling sum method...");
            cs.sum(2, 3);  // Check if this prints the sum of 2 and 3
            Console.WriteLine("Sum method called.");  // Check if this is reached
            Console.ReadLine();
        }

        public static void local_function()
        {
            int a = 10, b = 3;
            int tot = sum(a, b);
            Console.WriteLine("The sum is:" + tot);
            Console.ReadLine();

            int sum(int x, int y)
            {
                return x + y;
            }

            int result = sum(2, 3);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
