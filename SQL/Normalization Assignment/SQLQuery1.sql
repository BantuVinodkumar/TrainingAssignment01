create database Normalization
use normalization

create table table1(
 cID int primary key,pAddress varchar(100),propertyNo varchar(20), rent float )
 insert into table1 values(1,'6 Lawrence st,Glasgow','PG4',350),
 (2,'5 Novar Dr,Glassgow','PG36',450),
 (3,'2 Manor Rd,Glasgow','PG16',370)

 select* from table1

 create table table2(
 clientID int primary key,clintNo varchar(20), cName varchar(100),ownerNo varchar(20), oName varchar(100) )
 insert into table2 values(1,'CR76','Jhon Kay','C040','Tina Murphy'),
 (2,'CR56','Aline Stewan','C093','Tony Shaw')

 select* from table2

 create table NormalForm(
 cID int foreign key references table1(cID),clientID int foreign key references table2(clientID),rentStart varchar(10),
 rentFinish varchar(10))
 insert into NormalForm values(1,1,'1-july-00','31-aug-01'),
 (2,1,'1-sep-02','1-sep-02'),
 (1,2,'1-sep-99','10-june-00'),
 (3,2,'10-oct-00','1-dec-01'),
 (2,2,'1-nov-02','1-aug-03')

 select * from NormalForm


 --create table client(
 --ClientID int primary key,ClientNo varchar (20))
 --insert into client values (1,'CR76'),(2,'CR56')

 --select * from client

 --create table cName(
 --cNameId int primary key,cName varchar(100))
 --insert into cName values (1,'Jhon Kay'),(2,'Aline Stewan')
 --select * from cName

 -- create table PropertyNo(
 --propertyId int primary key,PropertyNo varchar(20))
 --insert into PropertyNo values (1,'PG4'),(2,'PG36'),(3,'PG16')
 --select * from PropertyNo

 -- create table pAddress(
 --pAddressId int primary key,pAddress varchar(100))
 --insert into pAddress values (1,'6 Lawrence st,Glasgow'),(2,'5 Novar Dr,Glassgow'),(3,'Manor Rd,Glasgow')
 --select * from pAddress

 -- create table rent(
 --rentId int primary key,rent float)
 --insert into rent values (1,350),(2,450),(3,370)
 --select * from rent

 --create table OwnerNo(
 --OwnerNoId int primary key,OwnerNo varchar(20))
 --insert into OwnerNo values (1,'C040'),(2,'C093')
 --select * from OwnerNo

 --create table oName(
 --oNameId int primary key,oName varchar(100))
 --insert into oName values (1,'Tina Murphy'),(2,'Tony Shaw')
 --select * from oName