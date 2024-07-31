create table book(
id int primary key,
title varchar(30),
author varchar(30),
isbn bigint unique,
publish_date DateTime )
 
 
 
insert into book(id,title,author,isbn,publish_date) values
(1, 'My First SQL book', 'Mary Parker', 981483029127, '2012-02-22 12:08:17'), 
(2, 'My Second SQL book', 'John Mayer', 857300923713, '1972-07-03 09:22:45'), 
(3, 'My Third SQL book', 'Cary Flint', 523120967812, '2015-10-18 14:05:44')
 
 



-- Query to fetch books written by authors ending with 'er'
SELECT * FROM book WHERE author LIKE '%er';

create table reviews (
    id int primary key,
    book_id int,
    reviewer_name varchar(30),
    content varchar(100),
    rating int,
    published_date DATETIME,
    foreign key (book_id) references book(id))
-- Insert the data into the reviews table
insert into reviews (id, book_id, reviewer_name, content, rating, published_date) values
(1, 1, 'John Smith', 'My first review', 4, '2017-12-10 05:50:11.1'),
(2, 2, 'John Smith', 'My second review', 5, '2017-10-13 15:05:12.6'),
(3, 2, 'Alice Walker', 'Another review', 1, '2017-10-22 23:47:10')

-- Display Title, Author, and ReviewerName
SELECT b.title, b.author, r.reviewer_name
FROM book b
JOIN reviews r ON b.id = r.book_id;

-- Display reviewer name who reviewed more than one book
SELECT reviewer_name
FROM reviews
GROUP BY reviewer_name
HAVING COUNT(*) > 1;

-- Create CUSTOMERS table
CREATE TABLE CUSTOMERS (
    ID INT PRIMARY KEY,
    NAME VARCHAR(100),
    AGE INT,
    ADDRESS VARCHAR(100),
    SALARY DECIMAL(10, 2))
 
-- Insert data into CUSTOMERS table
INSERT INTO CUSTOMERS (ID, NAME, AGE, ADDRESS, SALARY) VALUES
(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3, 'Kaushik', 27, 'Kota', 2000.00),
(4, 'Chaitali', 23, 'Mumbai', 6500.00),
(5, 'Hardik', 24, 'Bhopal', 4500.00),
(6, 'Komal', 29, 'Indore', 8500.00),
(7, 'Muffy', 25, 'MP', 10000.00)

 
-- Display customer name with address containing 'o'
SELECT name
FROM customers
WHERE address LIKE '%o%';
-- Create ORDERS table
CREATE TABLE ORDERS (
    OID INT PRIMARY KEY,
    DATE DATETIME,
    CUSTOMER_ID INT,
    AMOUNT DECIMAL(10, 2),
    FOREIGN KEY (CUSTOMER_ID) REFERENCES CUSTOMERS(ID)
);
-- Insert data into ORDERS table
INSERT INTO ORDERS (OID, DATE, CUSTOMER_ID, AMOUNT) VALUES
(101, '2009-10-08 00:00:00', 1, 3000.00),
(102, '2009-10-08 00:00:00', 2, 1560.00),
(103, '2009-11-20 00:00:00', 3, 1500.00),
(104, '2008-05-20 00:00:00', 4, 2060.00),
(105, '2009-10-08 00:00:00', 5, 4500.00),
(106, '2009-11-20 00:00:00', 6, 8500.00)

-- Display Date and total customers on the same date
SELECT date, COUNT(distinct CUSTOMER_ID) AS total_customers
FROM orders
GROUP BY date;

CREATE TABLE Employee (
    ID INT PRIMARY KEY,
    NAME VARCHAR(100),
    AGE INT,
    ADDRESS VARCHAR(100),
    SALARY DECIMAL(10, 2)
);
 
INSERT INTO Employee (ID, NAME, AGE, ADDRESS, SALARY) VALUES
(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3, 'Kaushik', 27, 'Kota', 2000.00),
(4, 'Chaitali', 23, 'Mumbai', NULL),
(5, 'Hardik', 25, 'Bhopal', 6500.00),
(6, 'Komal', 27, 'MP', 8500.00),
(7, 'Muffy', 24, 'Indore', NULL);
 

-- Display employee names in lowercase with null salary
SELECT LOWER(name) AS name
FROM employee
WHERE salary IS NULL;


CREATE TABLE Studentdetails (
    RegisterNo INT PRIMARY KEY,
    Name VARCHAR(100),
    Age INT,
    Qualification VARCHAR(50),
    MobileNo VARCHAR(15),
    Mail_id VARCHAR(100),
    Location VARCHAR(100),
    Gender CHAR(1)
);
 
INSERT INTO Studentdetails (RegisterNo, Name, Age, Qualification, MobileNo, Mail_id, Location, Gender) VALUES
(1, 'Sai', 22, 'B.E', '9952836777', 'Sai@gmail.com', 'Chennai', 'M'),
(2, 'Kumar', 20, 'BSC', '7890125648', 'Kumar@gmail.com', 'Madurai', 'M'),
(3, 'Selvi', 22, 'B.Tech', '8904567342', 'selvi@gmail.com', 'Selam', 'F'),
(4, 'Nisha', 25, 'M.E', '7834672310', 'Nisha@gmail.com', 'Theni', 'F'),
(5, 'Sai Saran', 21, 'B.A', '7890345678', 'saran@gmail.com', 'Madurai', 'F'),
(6, 'Tom', 23, 'BCA', '8901234675', 'Tom@gmail.com', 'Pune', 'M');

-- Display gender and count of male and female employees
select Gender, count(*) as Total from Studentdetails
group by Gender
