create database day23

use day23

-- Create the department_details table
CREATE TABLE Employee (
    Emp_id INT PRIMARY KEY identity(1,1),
    Emp_Name VARCHAR(255),
	Emp_Age  int
);

Insert into Employee(Emp_Name,Emp_Age) values
('Kunal',23),
('Pankaj',25),
('Nilanshi',20)

select * from Employee

	create Trigger EmployeeEntryRules
	on Employee 
	for Insert
	as
	begin
	Declare @age int
	select @age = I.Emp_Age from inserted I
	if(@age < 10)
	begin
	  print 'Age Violation'
	  rollback tran
	end
	else
	begin
	print 'Entry Allowed'
	commit
	end
	end

insert into Employee values
('Sandeep Yadav',12)

