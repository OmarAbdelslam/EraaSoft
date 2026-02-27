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
[Date]  DateTime  Default (SysDateTime()) not null ,
FK_ID  int  not null ,
Quantity  int  ,
FK_UR_Number int ,

Constraint FK_ID_Doc Foreign key (FK_ID)
References Doctor (ID) ,
Constraint FK_ID_Pati Foreign key (FK_UR_Number)
References Patient (UR_Number) ,

Constraint PK_DateAndID primary key ([Date],FK_ID)
)

Create Table Company
(
[Name]  varchar(100) primary key ,
[Address]   varchar(200)  ,
Phone  varchar(20)
)


Create Table Drug
(
[Name] varchar(100) ,
[FK_Company_Name] varchar(100)  ,
Strength  varchar(50)  ,
FK_Doctor_ID  int  ,

Constraint FK_Company foreign key ([FK_Company_Name])
References Company ([Name])
on Delete cascade  ,

Constraint FK_Doctor_ID foreign key (FK_Doctor_ID)
References Doctor (ID)
on Delete set null  ,

Constraint Composite_PK primary key ([Name],[FK_Company_Name])
)

Create Table [Patient Drugs]
(
UR_Number  int  ,
[FK_Drug_Name]  varchar(100)  ,
[FK_Company_Name]  varchar(100)  ,

Constraint FK_Drug foreign key ([FK_Drug_Name],[FK_Company_Name])
References Drug ([Name],[FK_Company_Name])
on Delete cascade  ,

Constraint FK_Patient Foreign Key (UR_Number)
References Patient (UR_Number),

Constraint Composite_PK_PatientDrug primary key (UR_Number,[FK_Drug_Name],[FK_Company_Name])

)


-- SELECT: Retrieve all columns from the Doctor table.

Select * From Doctor

--ORDER BY: List patients in the Patient table in ascending order of their ages.

Select * from Patient
order by Patient.Age  ASC

-- OFFSET FETCH: Retrieve the first 10 patients from the Patient table, starting from the 5th record.

SELECT *
FROM Patient
ORDER BY UR_Number ASC
OFFSET 5 ROWS
FETCH NEXT 5 ROWS ONLY;

-- SELECT TOP: Retrieve the top 5 doctors from the Doctor table

Select Top 5 *
From Doctor

-- SELECT DISTINCT: Get a list of unique address from the Patient table.

Select Distinct *
From Patient

-- WHERE: Retrieve patients from the Patient table who are aged 25.

Select *
From Patient
Where Age = 25 ;

-- NULL: Retrieve patients from the Patient table whose email is not provided.

Select * 
From Patient
Where Email is null

-- AND: Retrieve doctors from the Doctor table who have experience greater than 5 years and specialize in 'Cardiology'.

Select * From Doctor
Where Doctor.[Year Of Experience] < 5 And Doctor.Description = 'Cardiology'

-- IN: Retrieve doctors from the Doctor table whose speciality is either 'Dermatology' or 'Oncology'.

Select * From Doctor
Where Description = 'Dermatology' or Description = 'Oncology'
-- BETWEEN: Retrieve patients from the Patient table whose ages are between 18 and 30.

Select * From Patient
Where Age between 18 And 30

Select * from Patient
Where Age >= 18 And  Age < = 30
-- LIKE: Retrieve doctors from the Doctor table whose names start with 'Dr.'.

Select * from Doctor
Where Doctor.Name Like '%Dr.'
-- Column & Table Aliases: Select the name and email of doctors, aliasing them as 'DoctorName' and 'DoctorEmail'.

Select [Name] as DoctorName,Email as DoctorEmail
From Doctor

Select [Name]+'  '+Email as [Doctor Name And Email in One Line]
From Doctor
-- Joins: Retrieve all prescriptions with corresponding patient names.

Select pa.Name , pr.FK_UR_Number
From Patient as pa join Prescriptions as pr
on pa.UR_Number = pr.FK_UR_Number


-- GROUP BY: Retrieve the count of patients grouped by their cities.

Select * from Patient

Select Count(UR_Number) as [Count Patients ID] , [Address]
From Patient
Group by [Address]
-- HAVING: Retrieve cities with more than 3 patients.

Select Count(UR_Number) as [Count Patients ID] , [Address]
From Patient
Group by [Address]
Having Count(UR_Number) > 3
-- EXISTS: Retrieve patients who have at least one prescription.

SELECT *
FROM Patient p
WHERE EXISTS (
    SELECT 1
    FROM Prescriptions pr
    WHERE pr.FK_UR_Number = p.UR_Number
);
 
-- UNION: Retrieve a combined list of doctors and patients.
-- INSERT: Insert a new doctor into the Doctor table.
-- INSERT Multiple Rows: Insert multiple patients into the Patient table.
-- UPDATE: Update the phone number of a doctor.
-- UPDATE JOIN: Update the city of patients who have a prescription from a specific doctor.
-- DELETE: Delete a patient from the Patient table.
-- Transaction: Insert a new doctor and a patient, ensuring both operations succeed or fail together.
