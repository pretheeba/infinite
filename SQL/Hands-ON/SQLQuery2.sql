create database infiniteDB

use infiniteDB

create table dept
(  
dept_no int primary key,
dept_name varchar(15) not null ,
budget int,
);

select * from dept;

create table employees
(
empid int primary key,
empname varchar(15),
gender varchar,
salary float,
dept_no int references dept(dept_no),
)

alter table employees
add mobile_no varchar(10) unique

insert into dept values(1,'pretheeba',200000)

delete from dept where dept_no = 1; 

insert into dept values
(1,'IT',20000),(2,'HR',null),
(5,'Testing',1000000),(3,'Admin',3000000),(4,'Operations',null)

insert into dept(dept_name,dept_no)values('Accounts',6)

alter table dept
add Loc nvarchar(20) 

update dept set Loc = 'pune' where dept_no = 6

alter table dept 
add constraint con_uniq_loc unique(loc)

