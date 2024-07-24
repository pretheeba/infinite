CREATE DATABASE Employeemanagement;


USE Employeemanagement;

CREATE TABLE Employee_Details (
    Empno INT PRIMARY KEY,
    EmpName VARCHAR(50) NOT NULL,
    Empsal NUMERIC(10,2) CHECK (Empsal >= 25000),
    Emptype CHAR(1) CHECK (Emptype IN ('F', 'P'))
);

-- stored procedure


select * from Employee_Details

CREATE PROCEDURE AddEmployee
    @EmpName VARCHAR(50),
    @Empsal NUMERIC(10,2),
    @Emptype CHAR(1)
AS
BEGIN
    DECLARE @Empno INT;
    -- Find the maximum Empno in the table and increment it by 1
 
	select @Empno = case
	   when max(Empno) is null then 0
	   else max(Empno)
	   end
	   from Employee_Details
	   -- we will increment the @maxsaleid by 1, to avoid Pk violation
	    set @Empno = @Empno + 1
    -- Insert new employee details
    INSERT INTO Employee_Details (Empno, EmpName, Empsal, Emptype)
    VALUES (@Empno, @EmpName, @Empsal, @Emptype);
END