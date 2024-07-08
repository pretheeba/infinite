using System;
using TravelConcessionLibrary;

namespace TravelConcessionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Accepting input from the user
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter age: ");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Invalid age entered.");
                return;
            }

            // Create an instance of TicketBooking
            TicketBooking booking = new TicketBooking(name, age);

            // Call CalculateConcession method
            booking.CalculateConcession();

            Console.ReadLine(); // Keep console window open
        }
    }
}
