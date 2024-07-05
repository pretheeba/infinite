// CarFactory.cs
using AbstractFactoryPattern.ConcreteClasses;
using System;

namespace AbstractFactoryPattern.VehicleFactory
{
    public class CarFactory : VehicleFactory
    {
        public override IVehicle GetVehicle(string vehicleType)
        {
            if (vehicleType.Equals("Regular"))
            {
                return new Car();
            }
            else if (vehicleType.Equals("Sports"))
            {
                return new SportsCar();
            }
            else
            {
                return null;
            }
        }
    }
}
