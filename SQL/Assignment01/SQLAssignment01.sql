create database SQLAssignment01
use SQLAssignment01

create table Dept
(
DeptNo int primary key,
Dname varchar(20)not null,
Loc varchar(15)
)
select * from Dept
insert into Dept values (10,'ACCOUNTING','NEW YORK'),
(20,'RESEARCH','DALLAS'),
(30 ,'SALES','CHICAGO' ),
(40,'OPERATIONS','BOSTON')



create table Emp
(
EmpNo int primary key,
Ename varchar(30) not null,
Job varchar(15),
Mgr int,
HireDate DATE,
Sal float,
Comm float,
DeptNo int foreign key references Dept(DeptNo) -- relatating fk with pk
)
select * from Emp



insert into Emp values
(7369, 'SMITH','CLERK',7902,'17-DEC-80',800,NULL,20),
(7499,'ALLEN' ,'SALESMAN',7698,'20-FEB-81',1600 ,300,30),
(7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30),
(7566,'JONES','MANAGER',7839,'02-APR-81',2975,NULL,20),
(7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30),
(7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,NULL,30),
(7782,'CLARK' ,'MANAGER',7839,'09-JUN-81',2450,NULL,10),
(7788,'SCOTT','ANALYST',7566,'19-APR-87',3000,NULL,20),
(7839,'KING' ,'PRESIDENT',NULL ,'17-NOV-81' ,5000,NULL,10),
(7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500,0,30),
(7876,'ADAMS','CLERK',7788,'23-MAY-87',1100,NULL,20),
(7900,'JAMES','CLERK',7698,'03-DEC-81',950,NULL,30),
(7902,'FORD','ANALYST',7566,'03-DEC-81',3000,NULL,20),
(7934,'MILLER','CLERK',7782 ,'23-JAN-82',1300,NULL,10)

select * from Emp

--1. List all employees whose name begins with 'A'.



select * from Emp where ENAME like 'A%'



--2. Select all those employees who don't have a manager.


select * from Emp where Mgr is null


--3. List employee name, number and salary for those employees who earn in the range 1200 to 1400.


Select Ename,EmpNo,Sal from Emp where Sal BETWEEN 1200 AND 1400


--4.Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise.


select Sal+Sal*10/100 as "10% Payrise" from Emp Where DeptNo in (select DeptNo from Dept
where Dname='RESEARCH')


--5. Find the number of CLERKS employed. Give it a descriptive heading.


select count(*) as " NUMBER OF CLERKS" from Emp where Job='CLERK'


--6. Find the average salary for each job type and the number of people employed in each job.


select avg(Sal) as "Avg sal",count(*) as "Number Of People Employed In Each Job" from Emp
group by Job



--7. List the employees with the lowest and highest salary.


select Max(Sal) as "Max Sal" ,Min(Sal) as "Min Sal" From Emp


--8. List full details of departments that don't have any employees.


select * from Dept where DeptNo not in (select DeptNo from EMP)


--9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name.


select Ename,Sal from Emp where Job ='ANALYST' AND DeptNo=20 order by Ename asc


--10. For each department, list its name and number together with the total salary paid to employees in that department.


select Job ,DeptNo, SUM(Sal) as "Total Sal" from EMP group by Job,DeptNo


--11. Find out salary of both MILLER and SMITH.


select Sal, Ename from Emp where Ename in('MILLER','SMITH')


--12. Find out the names of the employees whose name begin with ‘A’ or ‘M’.


select Ename from Emp where Ename like 'A%' or Ename like 'M%'



--13. Compute yearly salary of SMITH.


select Sal*12 as "Year sal" from Emp where Ename='SMITH'


--14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850.


select Ename ,Sal from Emp where sal between 1500 and 2850

-----end----