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
(04,25000),
(05,50400),
(06,52300),
(07,51200)

select * from Employee
select * from Salary

-- Inner Join(Common portion in both)
select  Employee.emp_id,Employee.emp_name,Salary.salary
from Salary
inner join Employee on Employee.emp_id = Salary.emp_id 
where salary.salary > 50000

-- Left Join(all records from left and matched record from right)
select Employee.emp_name, Employee.phone
from Employee
left join Salary on Employee.emp_id = salary.emp_id

-- Right Join(all records from right and matched record from left)
select  salary.salary
from Salary
right join Employee on Employee.emp_id = salary.emp_id

-- Full outer Join (Natural join)(All records of both the table)
select  Employee.emp_id,Employee.emp_name,Salary.salary
from Salary
full outer join Employee on Salary.emp_id = Employee.emp_id

--self join(Conditions based self query)
--selecting employees with the same city
select distinct E1.emp_name as Employee1 ,
E2.emp_name as Employee2,
E1.emp_add
from Employee E1 , Employee E2
where E1.emp_add = E2.emp_add
order by E1.emp_name,E2.emp_name


--cross-join(Cartesian Product)
select * from Employee
Cross join Salary
