// Car.cs
using System;

namespace AbstractFactoryPattern.ConcreteClasses
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving the car");
            Console.ReadLine();
        }
    }
}
