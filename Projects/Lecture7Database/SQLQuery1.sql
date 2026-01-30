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
Alter Column ID int not null ;

Alter Table Employees
Add Constraint ID_Primarykey primary key (ID);

--7

Alter Table Employees
Add Constraint AddUniqueConstraint Unique ([Name])

--8

Create Table Customers
(
CustomerID int ,
FirstName varchar(50) ,
LastName  varchar(50) ,
Email varchar(100) ,
[Status] varchar(50)
)

--9

Alter Table Customers
Add Constraint DoubleUniqueConstraint unique (FirstName,LastName)

--10

Create Table Orders
(
OrderID int ,
CustomerID int ,
OrderDate DateTime ,
TotalAmount decimal
)

--11


Alter Table Orders
Add Constraint CheckConstraintTotalAmount Check(TotalAmount > 0)

--12

Create Schema Sales ;


ALTER SCHEMA Sales 
    TRANSFER dbo.Orders

--13

EXEC sp_rename 'Sales.Orders', 'SalesOrders'



