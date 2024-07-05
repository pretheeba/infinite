// SportsBike.cs
using System;

namespace AbstractFactoryPattern.ConcreteClasses
{
    public class SportsCar : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding the sportscar"); // Corrected message
            Console.ReadLine();
        }
    }
}
