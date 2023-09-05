create database TrainingDB

use TrainingDB

Create table std_Att(
id int NOT NULL primary key,
att int NOT NULL,
)

insert into std_Att(id,att) values 
(001 ,100),(002 ,98),(003 ,34),(004 ,12),(005 ,78),(006,67)

create table College(
id int Not Null primary key,
Std_Count int Not Null
)

create table StudentsData(
stud_id int PRIMARY KEY Foreign key references std_att(id),
stud_name varchar(100) NOT NULL,
stud_address text  NOT NULL,
SSN int UNIQUE,
dept_id int not null Foreign Key References College(id),
)

insert into College(id,Std_Count) values 
(121,567),(111,567),(511,567),(234,567),(555,567),(231,567)

insert into StudentsData(stud_name, stud_id, stud_address, SSN, dept_id) values 
('Kunal Shokeen',001 ,'GURGAON sector -39',123456,121),
('pankaj',002 ,'noida sector -59',123458,111),
('Nilanshu',003 ,'noida sector-05',NULL,511),
('pankaj sharma',004 ,'noida sector-12',123459,234),
('Nilanshu sharma',005 ,'noida sector -10',1234,555),
('Deepak',006,'noida sector-02',1234560,231)


select * from StudentsData
