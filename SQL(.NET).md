create database bit3rdsem
use bit3rdsem
go

*************create table***********
create table Student(
id int not null primary key identity(1,1),
name nvarchar(255) not null,
address nvarchar(255) not null,
contact nvarchar(25) not null
)

************ADD table*************
Alter table romiya add college nvarchar(255) NULL

***********insert table************
INSERT INTO romiya(name,address,contact)values
('sony','Manamaiju','9745332324'),
('sama','lalitpur','987654321'),
('hawana','bhaktapur','9745332324');

SELECT * FROM romiya

***********select table*************
SELECT * FROM romiya WHERE id >=2
""(used in mysql) => ''(used in sql)

SELECT * FROM romiya WHERE name ='sama'

***********update table**************
UPDATE table_name set column_name='column_data',column_name2='column_data' where id =2
UPDATE romiya SET name='Ram',contact='9841182606' WHERE id=2
SELECT * FROM romiya

**************delete table************
DELETE from romiya where condition----
DELETE FROM romiya where id=2
select * from romiya

******************************************************************************************************************
-------Create new table and try insert,select,update,delete--------------
create table student(
id int not null primary key identity(1,1),
name nvarchar(255) not null,
address nvarchar(255) not null
)

INSERT INTO student(name,address) values
('Shyam','patan'),
('hari','lalitpur'),
('purna','kalanki');
SELECT * FROM student

SELECT * FROM student WHERE  id=2 

Update student SET name ='laxmi'where name ='purna';

Delete from student where address='patan';
