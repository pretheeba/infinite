using System;

namespace OOPs
{
    class Structeg
    {
        public struct Point
        {
            public int X;
            public int Y;
        }
        

        public void UseStruct()
        {
            Point p1 = new Point { X = 2, Y = 3 };
            
            Console.WriteLine($"Point p1: ({p1.X}, {p1.Y})");
        }
    }
}