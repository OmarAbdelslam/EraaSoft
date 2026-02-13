Create Database [Prescription System]

use [Prescription System]

Create Table Patient
(
UR_Number int identity(1,1) primary key,
[Name]  varchar(100)  ,
[Address]  varchar(100) ,
Age  int  ,
Email  varchar(100)  ,
Phone  varchar(20)
)


Create Table Doctor
(
ID  int  identity primary key ,
[Name]  varchar(100)   ,
Email  varchar(100)   ,
Phone  varchar(20)   ,
[Description]   text   ,
[Year Of Experience]  smallint   
)

Create Table Prescriptions
(
[Date]  DateTime  Default (SysDateTime())  ,
FK_ID  int  ,
Quantity  int  ,
FK_UR_Number int ,

Constraint FK_ID_Doc Foreign key (FK_ID)
References Doctor (ID)  ,
Constraint FK_ID_Pati Foreign key (FK_UR_Number)
References Patient (UR_Number) 
on Cuscasd ,

)

