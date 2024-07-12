create database Assignment_02

CREATE TABLE EMP (
    empno INT PRIMARY KEY,
    ename VARCHAR(50),
    job VARCHAR(50),
    mgr_id INT,
    hiredate DATE,
    sal DECIMAL(10, 2),
    comm DECIMAL(10, 2),
    deptno INT
);
CREATE TABLE DEPT (
    deptno INT PRIMARY KEY,
    dname VARCHAR(50),
    loc VARCHAR(50)
);

INSERT INTO EMP (empno, ename, job, mgr_id, hiredate, sal, comm, deptno)
VALUES (7369, 'SMITH', 'CLERK', 7902, '1980-12-17', 800, NULL, 20);

INSERT INTO EMP (empno, ename, job, mgr_id, hiredate, sal, comm, deptno)
VALUES (7499, 'ALLEN', 'SALESMAN', 7698, '1981-02-20', 1600, 300, 30);

INSERT INTO EMP (empno, ename, job, mgr_id, hiredate, sal, comm, deptno)
VALUES (7521, 'WARD', 'SALESMAN', 7698, '1981-02-22', 1250, 500, 30);

INSERT INTO EMP (empno, ename, job, mgr_id, hiredate, sal, comm, deptno)
VALUES (7566, 'JONES', 'MANAGER', 7839, '1981-04-02', 2975, NULL, 20);

INSERT INTO EMP (empno, ename, job, mgr_id, hiredate, sal, comm, deptno)
VALUES (7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250, 1400, 30);

INSERT INTO EMP (empno, ename, job, mgr_id, hiredate, sal, comm, deptno)
VALUES (7698, 'BLAKE', 'MANAGER', 7839, '1981-05-01', 2850, NULL, 30);

INSERT INTO EMP (empno, ename, job, mgr_id, hiredate, sal, comm, deptno)
VALUES (7782, 'CLARK', 'MANAGER', 7839, '1981-06-09', 2450, NULL, 10);

INSERT INTO EMP (empno, ename, job, mgr_id, hiredate, sal, comm, deptno)
VALUES (7788, 'SCOTT', 'ANALYST', 7566, '1987-04-19', 3000, NULL, 20);

INSERT INTO EMP (empno, ename, job, mgr_id, hiredate, sal, comm, deptno)
VALUES (7839, 'KING', 'PRESIDENT', NULL, '1981-11-17', 5000, NULL, 10);

INSERT INTO EMP (empno, ename, job, mgr_id, hiredate, sal, comm, deptno)
VALUES (7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500, 0, 30);

INSERT INTO EMP (empno, ename, job, mgr_id, hiredate, sal, comm, deptno)
VALUES (7876, 'ADAMS', 'CLERK', 7788, '1987-05-23', 1100, NULL, 20);

INSERT INTO EMP (empno, ename, job, mgr_id, hiredate, sal, comm, deptno)
VALUES (7900, 'JAMES', 'CLERK', 7698, '1981-12-03', 950, NULL, 30);

INSERT INTO EMP (empno, ename, job, mgr_id, hiredate, sal, comm, deptno)
VALUES (7902, 'FORD', 'ANALYST', 7566, '1981-12-03', 3000, NULL, 20);

INSERT INTO EMP (empno, ename, job, mgr_id, hiredate, sal, comm, deptno)
VALUES (7934, 'MILLER', 'CLERK', 7782, '1982-01-23', 1300, NULL, 10);



INSERT INTO DEPT (deptno, dname, loc)
VALUES (10, 'ACCOUNTING', 'NEW YORK');

INSERT INTO DEPT (deptno, dname, loc)
VALUES (20, 'RESEARCH', 'DALLAS');

INSERT INTO DEPT (deptno, dname, loc)
VALUES (30, 'SALES', 'CHICAGO');

INSERT INTO DEPT (deptno, dname, loc)
VALUES (40, 'OPERATIONS', 'BOSTON');


--1. List all employees whose name begins with 'A'. 
SELECT *
FROM EMP
WHERE ename LIKE 'A%';

--2. Select all those employees who don't have a manager. 
SELECT *
FROM EMP
WHERE mgr_id IS NULL;

--3. List employee name, number and salary for those employees who earn in the range 1200 to 1400. 
SELECT ename, empno, sal
FROM EMP
WHERE sal >= 1200 AND sal <= 1400;

--4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise. 


--Retrieve Details Before the Pay Rise
SELECT *
FROM EMP;

--Apply the 10% Pay Rise
UPDATE EMP
SET sal = sal * 1.1;  

--Retrieve Details After the Pay Rise

-- After the pay rise
SELECT *
FROM EMP;

--5. Find the number of CLERKS employed. Give it a descriptive heading. 

SELECT COUNT(*) AS "Number of CLERKS employed"
FROM EMP
WHERE job = 'CLERK';

--6. Find the average salary for each job type and the number of people employed in each job. 

SELECT job,
       COUNT(*) AS "Number of Employees",
       AVG(sal) AS "Average Salary"
FROM EMP
GROUP BY job;

--7. List the employees with the lowest and highest salary. 

-- Employees with the lowest salary
SELECT *
FROM EMP
WHERE sal = (SELECT MIN(sal) FROM EMP);

-- Employees with the highest salary
SELECT *
FROM EMP
WHERE sal = (SELECT MAX(sal) FROM EMP);

--8. List full details of departments that don't have any employees. 

SELECT D.*
FROM DEPT D
LEFT JOIN EMP E ON D.deptno = E.deptno
WHERE E.deptno IS NULL;

--9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. 

SELECT ename, sal
FROM EMP
WHERE job = 'ANALYST' 
  AND sal > 1200
  AND deptno = 20
ORDER BY ename ASC;

--10. For each department, list its name and number together with the total salary paid to employees in that department. 

SELECT D.deptno, D.dname, SUM(E.sal) AS "Total Salary"
FROM DEPT D
LEFT JOIN EMP E ON D.deptno = E.deptno
GROUP BY D.deptno, D.dname
ORDER BY D.deptno;

--11. Find out salary of both MILLER and SMITH.
SELECT ename, sal
FROM EMP
WHERE ename IN ('MILLER', 'SMITH');

--12. Find out the names of the employees whose name begin with ‘A’ or ‘M’. 
SELECT ename
FROM EMP
WHERE ename LIKE 'A%' OR ename LIKE 'M%';

--13. Compute yearly salary of SMITH. 

SELECT ename, sal, sal * 12 AS "Yearly Salary"
FROM EMP
WHERE ename = 'SMITH';

--14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
SELECT ename, sal
FROM EMP
WHERE sal < 1500 OR sal > 2850;

--15. Find all managers who have more than 2 employees reporting to them

SELECT M.ename AS manager_name, COUNT(*) AS num_reports
FROM EMP E
JOIN EMP M ON E.mgr_id = M.empno
GROUP BY M.ename
HAVING COUNT(*) > 2;





