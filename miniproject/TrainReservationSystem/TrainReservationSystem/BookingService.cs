using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TrainReservationSystem.Models;

namespace TrainReservationSystem.Services
{
    public class BookingService
    {
        private readonly string _connectionString;

        public BookingService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void BookTicket(Booking booking)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Bookings (UserId, TrainNumber, CoachId, PassengerName, PassengerAge, BookingDate, JourneyDate) VALUES (@UserId, @TrainNumber, @CoachId, @PassengerName, @PassengerAge, @BookingDate, @JourneyDate)", connection);
                command.Parameters.AddWithValue("@UserId", booking.UserId);
                command.Parameters.AddWithValue("@TrainNumber", booking.TrainNumber);
                command.Parameters.AddWithValue("@CoachId", booking.CoachId);
                command.Parameters.AddWithValue("@PassengerName", booking.PassengerName);
                command.Parameters.AddWithValue("@PassengerAge", booking.PassengerAge);
                command.Parameters.AddWithValue("@BookingDate", booking.BookingDate);
                command.Parameters.AddWithValue("@JourneyDate", booking.JourneyDate);

                command.ExecuteNonQuery();
            }
        }

        public List<Booking> GetAllBookings()
        {
            var bookings = new List<Booking>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Bookings", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bookings.Add(new Booking
                        {
                            BookingId = (int)reader["BookingId"],
                            UserId = (int)reader["UserId"],
                            TrainNumber = (string)reader["TrainNumber"],
                            CoachId = (int)reader["CoachId"],
                            PassengerName = (string)reader["PassengerName"],
                            PassengerAge = (int)reader["PassengerAge"],
                            BookingDate = (DateTime)reader["BookingDate"],
                            JourneyDate = (DateTime)reader["JourneyDate"]
                        });
                    }
                }
            }
            return bookings;
        }

        public void CancelBooking(int bookingId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM Bookings WHERE BookingId = @BookingId", connection);
                command.Parameters.AddWithValue("@BookingId", bookingId);

                command.ExecuteNonQuery();
            }
        }

        public List<Booking> GetBookingsByUser(int userId)
        {
            var bookings = new List<Booking>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Bookings WHERE UserId = @UserId", connection);
                command.Parameters.AddWithValue("@UserId", userId);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bookings.Add(new Booking
                        {
                            BookingId = (int)reader["BookingId"],
                            UserId = (int)reader["UserId"],
                            TrainNumber = (string)reader["TrainNumber"],    
                            CoachId = (int)reader["CoachId"],
                            PassengerName = (string)reader["PassengerName"],
                            PassengerAge = (int)reader["PassengerAge"],
                            BookingDate = (DateTime)reader["BookingDate"],
                            JourneyDate = (DateTime)reader["JourneyDate"]
                        });
                    }
                }
            }
            return bookings;
        }
    }
}
