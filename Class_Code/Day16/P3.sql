Create Database TrainingDb;

use TrainingDb;

Create Table Employee(
EmployeeCode int primary key,
EmployeeName varChar(20) not null,
Age int not null
)

select * from Employee

insert into Employee(EmployeeCode,EmployeeName,Age)
values(1,'Kunal',21)


