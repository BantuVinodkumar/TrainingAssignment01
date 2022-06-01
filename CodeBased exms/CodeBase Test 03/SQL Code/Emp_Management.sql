create database EmployeeManagement
use EmployeeManagement

create table Employee
(EmpNo int primary key,
EmpName varchar(50) not null,
EmpSal numeric(10,2) check (EmpSal >= 25000),
EmpType varchar(1) check (EmpType in ('C','P')))


create or alter procedure Add_New_Employee @ename varchar(50), @esal numeric(10,2), @etype varchar(1)
as
 begin 
  declare @eid int = (select max(EmpNo) from Employee)
  if(@eid is null)
  begin
    set @eid = 0;
    declare @empid int = @eid + 1;
    insert into Employee values(@empid, @ename, @esal, @etype)
  end
  else
  begin
   declare @empid1 int = @eid + 1;
   insert into Employee values(@empid1, @ename, @esal, @etype)
  end
end
