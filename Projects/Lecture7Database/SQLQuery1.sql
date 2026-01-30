create database Eraasoft

-- 1
Create Table Employees
(
ID int ,
[Name] varchar(50),
Salary  Decimal
)

go

--2

Alter Table Employees
Add Department varchar(50)

--3

Alter Table Employees
drop column Salary

--4

Alter table Employees


--5

Create Table Projects
(
ProjectID int ,
ProjectName varchar(50)
)

--6

Alter Table Employees
Add Constraint ID primary key