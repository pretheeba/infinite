// Bike.cs
using System;

namespace AbstractFactoryPattern.ConcreteClasses
{
    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding the bike");
            Console.ReadLine();
        }
    }
    
}
