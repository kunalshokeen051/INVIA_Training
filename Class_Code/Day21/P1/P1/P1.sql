create database Day21
use Day21

create table Employee(
emp_id int primary key,
emp_name varchar(50),
phone int unique,
emp_add varchar(255)
)

create table Salary(
emp_id int primary key,
salary int
)

Insert into Employee(emp_id,emp_name,phone,emp_add) values 
(01,'kunal shokeen',12345,'gurgaon'),
(02,'pankaj negi',12346,'Noida'),
(03,'Nilanshu yadav',12341,'Noida'),
(04,'Gulshan Kumar',12342,'Noida')

Insert into Salary(emp_id,salary) values 
(01,55000),
(02,52000),
(03,51000),
(04,25000)

select * from Employee
select * from Salary

-- Inner Join
select  Employee.emp_id,Employee.emp_name,Salary.salary
from Salary
inner join Employee on Employee.emp_id = Salary.emp_id 

-- Left Join
select Employee.emp_name, Employee.phone
from Employee
left join Salary on Employee.emp_id = salary.emp_id

-- Right Join
select  salary.salary
from Salary
right join Employee on Employee.emp_id = salary.emp_id

-- Full outer Join (Natural join)
select  Employee.emp_id,Employee.emp_name,Salary.salary
from Salary
full outer join Employee on Salary.emp_id = Employee.emp_id

--self join 
select  E1.emp_name as Employee1 ,
E2.emp_name as Employee2,
E1.emp_add
from Employee E1 , Employee E2
where E1.emp_add = E2.emp_add

