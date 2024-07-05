// BikeFactory.cs
using AbstractFactoryPattern.ConcreteClasses;
using System;

namespace AbstractFactoryPattern.VehicleFactory
{
    public class BikeFactory : VehicleFactory
    {
        public override IVehicle GetVehicle(string vehicleType)
        {
            if (vehicleType.Equals("Regular"))
            {
                return new Bike();
            }
            else if (vehicleType.Equals("Sports"))
            {
                return new SportsBike();
            }
            else
            {
                return null;
            }
        }
    }
}
