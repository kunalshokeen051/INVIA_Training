use Day19

select * from Employee

INSERT into Employee(EmpId,EmpName,EmpAge)values
(1,'Kunal shokeen',23),
(2,'Kunal sharma',21),
(3,'Kunal Gupta',20),
(4,'Kunal',19)

CREATE FUNCTION AgeLimit()  
RETURNS TABLE  
AS  
RETURN  
    SELECT *
    FROM Employee
    WHERE EmpAge > 20   

select * from dbo.AgeLimit()