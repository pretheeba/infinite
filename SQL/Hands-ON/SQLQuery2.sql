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

alter table employees
add constraint check_salary check(salary >= 6000)

CREATE FUNCTION dbo.fnmale (@empname VARCHAR(50))
RETURNS TABLE
AS
RETURN (
    SELECT gender
    FROM tblemployee
    WHERE empname = @empname
      AND gender = 'M'  -- Ensure the gender is male
);
GO
--ex 3. Write a function to add 2 numbers and return the value
 
  create or alter function addnum(@d1 float, @d2 float)
  returns float
  as
  begin
  return round(@d1+@d2,2)
  end
  select dbo.addnum(2,7) as [SUM];
 
  --ex 4. write a function to calculate the area of rectangle
 
 
create or alter function findArea(@l float,@b float)
returns float
as
begin
	return @l*@b
end
 
select dbo.findArea(5,2) as [Area]

 