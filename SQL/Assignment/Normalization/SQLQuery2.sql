create database Normalization_01
 
use Normalization
 
create table client_renting_1NF(
c_number varchar(50),
c_name varchar(50),
propertyNo varchar(50),
p_address varchar(50),
rent_start date,
rent_finish date,
rent int,
owner_no varchar(50),
ownerName varchar(50)
)
------------------------------------------------------------------------------------
insert into client_renting_1NF
values
('CR76','John Kay','PG4','6 Lawrence','2003-07-09','2001-09-01',350,'CO40','tina murphy'),
('CR76','John Kay','PG16','5 novar dr glass grow','2001-09-02','2001-09-02',450,'CO93','tony shaw'),
('CR56','Aline stewart','PG4','6 Lawrence','1999-09-01','2000-09-01',350,'CO40','tina murphy '),
('CR56','Aline stewart','PG36','2 manor rd, glass gow','2000-10-10','2001-12-01',370,'CO93','tony shaw'),
('CR56','Aline stewart','PG16','5 novar dr glass grow','2002-11-01','2003-08-01',450,'CO93','tony shaw')
---------------------------------------------------------------------------------
------------1NF------------------------------------------------------------------
select * from client_renting_1NF
 
-------------------------------Table for 2NF----------------------------------------------------------
 
-------------Create a Clients table:-----
create table clients_2nf(
c_number varchar(50) Primary key,
c_name varchar(50)
)
 
-- Insert values into the Clients table
insert into clients_2nf(c_number,c_name)
values
    ('CR76', 'John Kay'),
    ('CR56', 'Aline Stewart')
 
------------Create a Properties table:-----
create table Properties_2nf(
propertyNo varchar(50) Primary Key,
p_address varchar(50),
owner_no varchar(50),
ownerName varchar(50)
)
 
-- Insert values into the Properties table
INSERT INTO Properties_2nf(propertyNo, p_address, owner_no, ownerName)
VALUES
    ('PG4', '6 Lawrence', 'CO40', 'Tina Murphy'),
    ('PG16', '5 Novar Dr Glass Grow', 'CO93', 'Tony Shaw'),
    ('PG36', '2 Manor Rd, Glass Gow', 'CO93', 'Tony Shaw')
 
---------------Create the Rentals table
create table Rentals_2nf(
    c_number varchar(50) references Clients_2nf(c_number),
    propertyNo varchar(50) references Properties_2nf(propertyNo),
    rent_start DATE,
    rent_finish DATE,
    rent int,
    primary key (c_number, propertyNo),
)
 
-- Insert values into the Rentals table
insert into Rentals_2nf(c_number, propertyNo, rent_start, rent_finish, rent)
values
    ('CR76', 'PG4', '2003-07-09', '2001-09-01', 350),
    ('CR76', 'PG16', '2001-09-02', '2001-09-02', 450),
    ('CR56', 'PG4', '1999-09-01', '2000-09-01', 350),
    ('CR56', 'PG36', '2000-10-10', '2001-12-01', 370),
    ('CR56', 'PG16', '2002-11-01', '2003-08-01', 450)
	------------Fetching the tables of 2NF ------------------------------------------------------------------
select * from clients_2nf
select * from Properties_2nf
select * from Rentals_2nf
 
------------------- Table for 3rd Nf ----------------------------------------
 
create table clients_3nf(
    c_number varchar(50) primary key,
    c_name varchar(50)
)
 
-- Insert values into the Clients table
insert into clients_3nf(c_number, c_name)
values
    ('CR76', 'John Kay'),
    ('CR56', 'Aline Stewart')
 
-- Create a PropertyOwners table to store owner information
create table p_owners_3nf(
    owner_no varchar(50) primary key,
    ownerName varchar(50)
)
 
-- Insert values into the PropertyOwners table
insert into p_owners_3nf(owner_no, ownerName)
values
    ('CO40', 'Tina Murphy'),
    ('CO93', 'Tony Shaw')
 
-- Update the Properties table to reference PropertyOwners
create table properties_3nf (
    propertyNo varchar(50) primary key,
    p_address varchar(50),
    owner_no varchar(50) references p_owners_3nf(owner_no)
)
 
-- Insert values into the Properties table
insert into properties_3nf(propertyNo, p_address, owner_no)
values
    ('PG4', '6 Lawrence', 'CO40'),
    ('PG16', '5 Novar Dr Glass Grow', 'CO93'),
    ('PG36', '2 Manor Rd, Glass Gow', 'CO93')
 
------- Creating table Rental--------
 
create table Rental_3nf (
    c_number varchar(50),
    propertyNo varchar(50),
    rent_start DATE,
    rent_finish DATE,
    rent int,
    primary key (c_number, propertyNo),
    foreign key (c_number) references Clients_3nf(c_number),
    foreign key (propertyNo) references Properties_3nf(propertyNo)
)
 
-- Insert values into the Rentals table
insert into Rental_3nf(c_number, propertyNo, rent_start, rent_finish, rent)
values
    ('CR76', 'PG4', '2003-07-09', '2001-09-01', 350),
    ('CR76', 'PG16', '2001-09-02', '2001-09-02', 450),
    ('CR56', 'PG4', '1999-09-01', '2000-09-01', 350),
    ('CR56', 'PG36', '2000-10-10', '2001-12-01', 370),
    ('CR56', 'PG16', '2002-11-01', '2003-08-01', 450)
 
 
------------fetching the tables of 3NF-------------------------------------------------------------------
select * from clients_3nf
select * from properties_3nf
select * from p_owners_3nf
select * from Rental_3nf
has context menu


has context menu