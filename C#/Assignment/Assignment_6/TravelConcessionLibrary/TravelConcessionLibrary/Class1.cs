using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelConcessionLibrary
{
    public class TicketBooking
    {
        private const decimal TotalFare = 500.0m;

        public string Name { get; private set; }
        public int Age { get; private set; }

        public TicketBooking(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void CalculateConcession()
        {
            if (Age <= 5)
            {
                Console.WriteLine("Little Champs - Free Ticket");
            }
            else if (Age > 60)
            {
                decimal concessionAmount = TotalFare * 0.3m;
                decimal discountedFare = TotalFare - concessionAmount;
                Console.WriteLine($"Senior Citizen - Discounted Fare: {discountedFare:C}");
            }
            else
            {
                Console.WriteLine($"Ticket Booked - Fare: {TotalFare:C}");
            }
        }
    }
}
