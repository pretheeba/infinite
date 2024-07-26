-- Create the database
CREATE DATABASE EmployeeDB;

-- Use the new database
USE EmployeeDB;

-- Create the Employee table
CREATE TABLE Employee (
    EmployeeID INT PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Title NVARCHAR(50),
    DOB DATE,
    DOJ DATE,
    City NVARCHAR(50)
);

-- Insert the data
INSERT INTO Employee (EmployeeID, FirstName, LastName, Title, DOB, DOJ, City)
VALUES
(1001, 'pretheeba', 'udhayakumar', 'Manager', '1984-11-16', '2011-06-08', 'Mumbai'),
(1002, 'sajana', 'preetha', 'AsstManager', '1984-08-20', '2012-07-07', 'Mumbai'),
(1003, 'vaishu', 'raji', 'Consultant', '1987-11-14', '2015-04-12', 'Pune'),
(1004, 'kajal', 'shukla', 'SE', '1990-06-03', '2016-02-02', 'Pune'),
(1005, 'dharshini', 'udhayakumar', 'SE', '1991-03-08', '2016-02-02', 'Mumbai'),
(1006, 'pradeep', 'vijyakumar', 'Consultant', '1989-11-07', '2014-08-08', 'Chennai'),
(1007, 'sumathi', 'udhayakumar', 'Consultant', '1989-12-02', '2015-06-01', 'Mumbai'),
(1008, 'udhai', 'manoharan', 'Associate', '1993-11-11', '2014-11-06', 'Chennai'),
(1009, 'kumar', 'manoharan', 'Associate', '1992-08-12', '2014-12-03', 'Chennai'),
(1010, 'hari', 'radha', 'Manager', '1991-04-12', '2016-01-02', 'Pune');
