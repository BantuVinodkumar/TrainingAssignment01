create database sqlExam02;
use sqlExam02;
create table Emp8(
Empid int not null,
Name varchar(55),
Salary int,
Deptno int);
insert into Emp8 values(1,'vinod',5000,10);
insert into Emp8 values(2,'ramu',12000,20);
insert into Emp8 values(3,'sita',50000,30);
select * from Emp8;