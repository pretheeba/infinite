create database Normalization_task
 
use Normalization_task
 
create table client_1NF(
c_number varchar(45),
c_name varchar(45),
propertyNo varchar(45),
p_address varchar(45),
rent_start date,
rent_finish date,
rent int,
owner_no varchar(45),
ownerName varchar(45)
)
INSERT INTO client_1NF
VALUES
    ('CR89', 'Alice Johnson', 'PG4', '10 Park Avenue', '2004-05-15', '2004-07-01', 380, 'CO40', 'Tina Murphy'),
    ('CR89', 'Alice Johnson', 'PG16', '15 Elm Street', '2004-07-02', '2004-08-15', 460, 'CO93', 'Tony Shaw'),
    ('CR72', 'Michael Davis', 'PG36', '25 Maple Road', '2003-12-10', '2004-01-15', 400, 'CO62', 'Emily Brown'),
    ('CR72', 'Michael Davis', 'PG4', '10 Park Avenue', '2004-02-01', '2004-03-15', 380, 'CO40', 'Tina Murphy'),
    ('CR72', 'Michael Davis', 'PG16', '15 Elm Street', '2004-03-16', '2004-05-01', 460, 'CO93', 'Tony Shaw');

select * from client_1NF
 
 
create table client_2NF(
c_number varchar(45) Primary key,
c_name varchar(45)
)
 
insert into client_2NF(c_number,c_name)
values
    ('CR89', 'Alice Johnson'),
    ('CR72', 'Alice Johnson')

	select * from client_2NF

 
create table Properties_2NF(
propertyNo varchar(45) Primary Key,
p_address varchar(45),
owner_no varchar(45),
ownerName varchar(45)
)
 
INSERT INTO Properties_2NF(propertyNo, p_address, owner_no, ownerName)
VALUES
    ('PG4', '6 Lawrence', 'CO40', 'Tina Murphy'),
    ('PG16', '5 Novar Dr Glass Grow', 'CO93', 'Tony Shaw'),
    ('PG36', '2 Manor Rd, Glass Gow', 'CO93', 'Tony Shaw')

	select * from Properties_2NF

 
create table Rentals_2NF(
    c_number varchar(45 references Clients_2nf(c_number),
    propertyNo varchar(45) references Properties_2nf(propertyNo),
    rent_start DATE,
    rent_finish DATE,
    rent int,
    primary key (c_number, propertyNo),
)
 
insert into Rentals_2NF(c_number, propertyNo, rent_start, rent_finish, rent)
values
    ('CR89', 'PG4', '2003-07-09', '2001-09-01', 350),
    ('CR89', 'PG16', '2001-09-02', '2001-09-02', 450),
    ('CR72', 'PG4', '1999-09-01', '2000-09-01', 350),
    ('CR72', 'PG36', '2000-10-10', '2001-12-01', 370),
    ('CR72', 'PG16', '2002-11-01', '2003-08-01', 450)
select * from Rentals_2NF
 
 
create table client_3NF(
    c_number varchar(45) primary key,
    c_name varchar(45)
)
 
insert into client_3NF(c_number, c_name)
values
    ('CR76', 'Alice Johnson'),
    ('CR56', 'Michael Davis')

	select * from client_3NF


 
create table owner_3NF(
    owner_no varchar(45) primary key,
    ownerName varchar(45)
)
 
insert into owner_3NF(owner_no, ownerName)
values
    ('CO40', 'Tina Murphy'),
    ('CO93', 'Tony Shaw')

	
select * from owners_3NF

 
create table properties_3NF (
    propertyNo varchar(45) primary key,
    p_address varchar(45),
    owner_no varchar(45) references p_owners_3nf(owner_no)
)
 
insert into properties_3NF(propertyNo, p_address, owner_no)
values
    ('PG4', '6 Lawrence', 'CO40'),
    ('PG16', '5 Novar Dr Glass Grow', 'CO93'),
    ('PG36', '2 Manor Rd, Glass Gow', 'CO93')

	
select * from properties_3NF

 
 
create table Rental_3NF (
    c_number varchar(45),
    propertyNo varchar 45),
    rent_start DATE,
    rent_finish DATE,
    rent int,
    primary key (c_number, propertyNo),
    foreign key (c_number) references Clients_3nf(c_number),
    foreign key (propertyNo) references Properties_3nf(propertyNo)
)
 
insert into Rental_3NF(c_number, propertyNo, rent_start, rent_finish, rent)
values
    ('CR89', 'PG4', '2003-07-09', '2001-09-01', 350),
    ('CR89', 'PG16', '2001-09-02', '2001-09-02', 450),
    ('CR72', 'PG4', '1999-09-01', '2000-09-01', 350),
    ('CR72', 'PG36', '2000-10-10', '2001-12-01', 370),
    ('CR72', 'PG16', '2002-11-01', '2003-08-01', 450)
 
 
select * from Rental_3NF


