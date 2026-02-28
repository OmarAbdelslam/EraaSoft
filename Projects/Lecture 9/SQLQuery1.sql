
Create Database  Lecture9

use Lecture9

Create Table Employee
(
ID   int primary Key ,
FirstName   NVarchar(50)  ,
LastName    NVarchar(50)  ,
Salary      Money   
)

Create PROC GetAllEmployeeid
as
Select * from Employee

Create PROC GETHIGHSALARYEMPLOYEES(@MinSalary Money)
as
Select * from Employee
Where Salary > @MinSalary

Alter proc AddEmployees(@ID int,@FirstName varchar(50),@LastName varchar(50),@Salary Money )
as
Begin try
insert into Employee(ID,FirstName,LastName,Salary)
values(@ID,@FirstName,@LastName,@Salary)
return 100
end try
begin catch
return 200
end catch




DECLARE @Result int

EXEC @Result = AddEmployees 
    4,'Omar','Abdelsalam',5000.50

SELECT @Result

select * from Employee

Create Table EmployeeLog
(
id int identity(1,1),
Employeeid  varchar(50), 
[Action]    varchar(100),
ActionDate  datetime  default(sysDatetime())
)

create trigger EmployeeAfterInsert
on Employee
After insert
as 
begin
INSERT INTO EmployeeLog(Employeeid,[Action])
    SELECT ID , 'Added'
    FROM inserted
end

select * from EmployeeLog

