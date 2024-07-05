// Program.cs
using AbstractFactoryPattern.VehicleFactory;
using System;
using AbstractFactoryPattern.VehicleFactory;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle = null;
            VehicleFactory.VehicleFactory vehicleFactory = null;

            // Choose factory type
            Console.WriteLine("Enter the Factory Type (Bike/Car):");
            string factoryType = Console.ReadLine();

            // Create respective factory object
            vehicleFactory = VehicleFactory.VehicleFactory.CreateVehicleFactory(factoryType);

            Console.WriteLine();

            // Create vehicle object
            if (factoryType.Equals("Bike"))
            {
                Console.WriteLine("Enter Regular/Sports bike:");
                string reqVehicle = Console.ReadLine();

                vehicle = vehicleFactory.GetVehicle(reqVehicle);

                Console.WriteLine($"The Chosen Vehicle is : {vehicle.GetType().Name}");

                vehicle.Drive();
            }
            else if (factoryType.Equals("Car"))
            {
                Console.WriteLine("Enter Regular/Sports car:");
                string reqVehicle = Console.ReadLine();

                vehicle = vehicleFactory.GetVehicle(reqVehicle);

                Console.WriteLine($"The Chosen Vehicle is : {vehicle.GetType().Name}");

                vehicle.Drive();
            }
            else
            {
                Console.WriteLine("Please choose correct vehicle type (Bike/Car)");
            }

            Console.Read();
        }
    }
}
