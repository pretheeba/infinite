
use normalization


create table client
(
clientNo int primary key,
cName varchar(30)
)

create table propertydetails
(
PropertyNumber int primary key,
Paddress varchar(30),
rent int
)
create table Owner
(
OwnerNumber int primary key,
OwnerName varchar(30)
)

create table property
(
clientNo int,PropertyNumber int,rent_start date,
rent_end date,owner_number int,primary key(clientNo,PropertyNumber),FOREIGN KEY(clientNo)
references client(clientNo),FOREIGN KEY(owner_number)
references Owner(OwnerNumber),foreign key(PropertyNumber) references propertydetails(PropertyNumber)
)

INSERT INTO client (clientNo, cName) VALUES
(1, 'John Doe'),
(2, 'Jane Smith'),
(3, 'Emily Davis');

INSERT INTO propertydetails (PropertyNumber, Paddress, rent) VALUES
(101, '123 Maple Street', 1200),
(102, '456 Oak Avenue', 1500),
(103, '789 Pine Road', 1800);

INSERT INTO Owner (OwnerNumber, OwnerName) VALUES
(1001, 'Alice Johnson'),
(1002, 'Bob Brown');

INSERT INTO property (clientNo, PropertyNumber, rent_start, rent_end, owner_number) VALUES
(1, 101, '2024-01-01', '2024-12-31', 1001),
(2, 102, '2024-02-01', '2024-12-31', 1002),
(3, 103, '2024-03-01', '2024-12-31', 1001);

select * from client
select * from property