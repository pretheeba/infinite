// VehicleFactory.cs
using System;

namespace AbstractFactoryPattern.VehicleFactory
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle GetVehicle(string vehicleType);

        public static VehicleFactory CreateVehicleFactory(string factoryType)
        {
            if (factoryType.Equals("Bike"))
            {
                return new BikeFactory();
            }
            else if (factoryType.Equals("Car"))
            {
                return new CarFactory();
            }
            else
            {
                return null;
            }
        }
    }
}
