create database EmployeeDFA

use EmployeeDFA

drop table EMPLOYEE_DETAILS

create table EMPLOYEE_DETAILS (
	employee_id INT primary key,
	first_name VARCHAR(50),
	last_name VARCHAR(50),
	age INT,
	email VARCHAR(50),
	department VARCHAR(9),
);	

insert into EMPLOYEE_DETAILS (employee_id, first_name, last_name, age, email, department) values (1, 'Kaitlin', 'Comi', 25, 'kcomi0@loc.gov', 'Finance');
insert into EMPLOYEE_DETAILS (employee_id, first_name, last_name, age, email, department) values (2, 'Neils', 'De Stoop', 34, 'ndestoop1@technorati.com', 'Finance');
insert into EMPLOYEE_DETAILS (employee_id, first_name, last_name, age, email, department) values (3, 'Isidor', 'Roxbee', 39, 'iroxbee2@nps.gov', 'Finance');
insert into EMPLOYEE_DETAILS (employee_id, first_name, last_name, age, email, department) values (4, 'Annette', 'Streatley', 18, 'astreatley3@foxnews.com', 'IT');
insert into EMPLOYEE_DETAILS (employee_id, first_name, last_name, age, email, department) values (5, 'Husein', 'Lozano', 22, 'hlozano4@aol.com', 'Finance');
insert into EMPLOYEE_DETAILS (employee_id, first_name, last_name, age, email, department) values (6, 'Rustin', 'Grice', 35, 'rgrice5@google.ca', 'Sales');
insert into EMPLOYEE_DETAILS (employee_id, first_name, last_name, age, email, department) values (7, 'Annecorinne', 'Aitchison', 54, 'aaitchison6@ycombinator.com', 'Finance');
insert into EMPLOYEE_DETAILS (employee_id, first_name, last_name, age, email, department) values (8, 'Revkah', 'Meadowcraft', 23, 'rmeadowcraft7@eventbrite.com', 'Finance');
insert into EMPLOYEE_DETAILS (employee_id, first_name, last_name, age, email, department) values (9, 'Bastian', 'Braizier', 46, 'bbraizier8@army.mil', 'Finance');
insert into EMPLOYEE_DETAILS (employee_id, first_name, last_name, age, email, department) values (10, 'Sunny', 'Jameson', 32, 'sjameson9@usnews.com', 'IT');

-- SALARY  TABLE


create table SALARY (
    ID int identity(1,1) primary key not null, 
    Employee_ID int,
	CTC money,
	Basic_Salary money,
	House_Rent_Allowance money,
	Dearness_Allowance money,
	Conveyance_Allowance money,
	Medical_Allowance money,
	Mobile_Allowance money,
	Bonus_VARCHAR money,
	Gratuity money,
	Income_Tax money,
	Provident_Fund money,
	Professional_Tax money,
	National_Pension_Scheme money,
	Other_Deductions money,
	FOREIGN KEY (Employee_ID) REFERENCES employee_details(employee_id)
);
	
insert into SALARY VALUES (1,30000,10000,2000,1200,800,4000,200,2000,245,2345,212,101,56,2000)
insert into SALARY VALUES (2,40000,20000,3000,1400,800,4000,200,2000,445,2445,312,201,86,2000)
insert into SALARY VALUES (3,50000,30000,4000,1300,800,4000,200,2000,545,2545,412,301,86,2000)
insert into SALARY VALUES (4,60000,40000,5000,1100,800,4000,200,2000,645,2645,512,401,86,2000)
insert into SALARY VALUES (5,65000,40000,5000,1100,800,4000,200,2000,645,2645,512,401,86,2000)
insert into SALARY VALUES (6,70000,40000,5000,1100,800,4000,200,2000,645,2645,512,401,86,2000)
insert into SALARY VALUES (7,80000,40000,5000,1100,800,4000,200,2000,645,2645,512,401,86,2000)
insert into SALARY VALUES (8,90000,40000,5000,1100,800,4000,200,2000,645,2645,512,401,86,2000)
insert into SALARY VALUES (9,100000,40000,5000,1100,800,4000,200,2000,645,2645,512,401,86,2000)
insert into SALARY VALUES (10,110000,40000,5000,1100,800,4000,200,2000,645,2645,512,401,86,2000)

select * from SALARY
select * from EMPLOYEE_DETAILS
