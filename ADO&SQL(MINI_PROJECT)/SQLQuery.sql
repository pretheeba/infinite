create database Miniproject

 use Miniproject;
GO

-- Create Users table
CREATE TABLE Users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(50) NOT NULL,
    IsAdmin BIT NOT NULL
);
GO

-- Create Trains table
-- Create Trains table with TrainNumber as the primary key
CREATE TABLE Trains (
    TrainNumber NVARCHAR(50)  PRIMARY KEY,
    TrainName NVARCHAR(100) NOT NULL,
    Source NVARCHAR(50) NOT NULL,
    Destination NVARCHAR(50) NOT NULL,
    AcTicketPrice DECIMAL(10, 2) NOT NULL,
    GeneralTicketPrice DECIMAL(10, 2) NOT NULL
);
GO

-- Create Coaches table
CREATE TABLE Coaches (
    CoachId INT IDENTITY(1,1) PRIMARY KEY,
    TrainNumber NVARCHAR(50) FOREIGN KEY REFERENCES Trains(TrainNumber),
    CoachType NVARCHAR(10) NOT NULL,
    SeatCount INT NOT NULL,
    AvailableSeats INT NOT NULL
);
GO

-- Create Bookings table
CREATE TABLE Bookings (
    BookingId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT FOREIGN KEY REFERENCES Users(UserId),
    TrainNumber NVARCHAR(50) FOREIGN KEY REFERENCES Trains(TrainNumber),
    CoachId INT FOREIGN KEY REFERENCES Coaches(CoachId),
    PassengerName NVARCHAR(100) NOT NULL,
    PassengerAge INT NOT NULL,
    BookingDate DATETIME NOT NULL,
    JourneyDate DATETIME NOT NULL
);
GO


select * from users
select * from Trains
select * from Coaches
select * from bookings
select * from Cancellations