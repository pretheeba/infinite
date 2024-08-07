using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try
{
    class Models
{
}
}

namespace TrainReservationSystem.Models
{
    public enum CoachType
    {
        AC,
        GENERAL
    }

    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }

    public class Train
    {
        public int TrainNumber { get; set; }
        public string TrainName { get; set; }
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public decimal BasePrice { get; set; }
        public string TrainStatus { get; set; }
        public int SeatsAvailable { get; set; }
    }

    public class Coach
    {
        public int CoachId { get; set; }
        public int TrainNumber { get; set; }
        public CoachType CoachType { get; set; }
        public int SeatsAvailable { get; set; }
    }

    public class Booking
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public int TrainNumber { get; set; }
        public int CoachId { get; set; }
        public int NumberOfSeats { get; set; }
        public DateTime BookingDate { get; set; }
    }

    public class Cancellation
    {
        public int CancellationId { get; set; }
        public int BookingId { get; set; }
        public int CancelledSeats { get; set; }
        public string CancellationReason { get; set; }
        public bool RefundAvailable { get; set; }
        public DateTime CancellationDate { get; set; }
    }
}

