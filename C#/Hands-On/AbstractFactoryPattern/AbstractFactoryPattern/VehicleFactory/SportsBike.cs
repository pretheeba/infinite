// SportsBike.cs
using System;

namespace AbstractFactoryPattern.ConcreteClasses
{
    public class SportsBike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding the sportsbike"); // Corrected message
            Console.ReadLine();
        }
    }
}
