use EmployeeDb

select * from Employees
select * from Salaries

SET IDENTITY_INSERT salaries Off

SELECT Employees.Name, Employees.Email
FROM Employees
JOIN Salaries ON Salaries.Employee_id = Employees.Employee_id;
                                   
​

insert into Salaries(Salary_Id,ctc,Basic_Pay,ESIC,EPF,Allowance,Bonus,Income_Tax,Mis_Deductions,Employee_id) values (101,500000,350000,0,0,0,0,0,0,4)
insert into Salaries(Salary_Id,ctc,Basic_Pay,ESIC,EPF,Allowance,Bonus,Income_Tax,Mis_Deductions,Employee_id) values (102,600000,350000,0,0,0,0,0,0,5)