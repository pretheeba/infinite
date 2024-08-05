using System;
using System.Data.SqlClient;
using TrainReservationSystem.Models;

namespace TrainReservationSystem.Services
{
    public class CoachService
    {
        private readonly string _connectionString;

        public CoachService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddCoach(Coach coach)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Coaches (TrainNumber, CoachType, SeatCount, AvailableSeats) VALUES (@TrainNumber, @CoachType, @SeatCount, @AvailableSeats)", connection);
                command.Parameters.AddWithValue("@TrainNumber", coach.TrainNumber);
                command.Parameters.AddWithValue("@CoachType", coach.CoachType);
                command.Parameters.AddWithValue("@SeatCount", coach.SeatCount);
                command.Parameters.AddWithValue("@AvailableSeats", coach.AvailableSeats);

                command.ExecuteNonQuery();
            }
        }

        public Coach GetCoachByTrainNumberAndType(string trainNumber, string coachType)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Coaches WHERE TrainNumber = @TrainNumber AND CoachType = @CoachType", connection);
                command.Parameters.AddWithValue("@TrainNumber", trainNumber);
                command.Parameters.AddWithValue("@CoachType", coachType);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Coach
                        {
                            CoachId = (int)reader["CoachId"],
                            TrainNumber = (string)reader["TrainNumber"],
                            CoachType = (string)reader["CoachType"],
                            SeatCount = (int)reader["SeatCount"],
                            AvailableSeats = (int)reader["AvailableSeats"]
                        };
                    }
                }
            }
            return null;
        }

        public void UpdateAvailableSeats(int coachId, int availableSeats)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("UPDATE Coaches SET AvailableSeats = @AvailableSeats WHERE CoachId = @CoachId", connection);
                command.Parameters.AddWithValue("@AvailableSeats", availableSeats);
                command.Parameters.AddWithValue("@CoachId", coachId);

                command.ExecuteNonQuery();
            }
        }
    }
}
