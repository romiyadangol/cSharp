//employee details
--create database emp_details
use emp_details
go
*****************************
create table employee
(id int not null primary key identity(1,1),
name nvarchar(255) not null,
address nvarchar(255) not null,
salary nvarchar(10) not null
)

Insert into employee(name,address,salary)values
('Romiya','Manamaiju','15000'),
('Soniya','Nuwakot','25000'),
('Purna','Lalitpur','35000'),
('Laxmi','Gongabu','30000');

Select * from employee

