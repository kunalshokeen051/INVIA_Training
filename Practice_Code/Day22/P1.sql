create database Day22
use Day22

-- Create Table1
CREATE TABLE Table1 (
    ID INT PRIMARY KEY,
    Name VARCHAR(255)
);

-- Create Table2
CREATE TABLE Table2 (
    ID INT PRIMARY KEY,
    Description VARCHAR(255)
);

INSERT INTO Table1(ID, Name)
VALUES
   (1, 'Rajesh'),
    (2, 'Priya'),
    (3, 'Amit'),
    (4, 'Anjali'),
    (5, 'Vikram'),
    (6, 'Sneha'),
    (7, 'Rahul'),
    (8, 'Pooja'),
    (9, 'Akshay'),
    (10, 'Neha'),
    (11, 'Sanjay'),
    (12, 'Smita'),
    (13, 'Rohit'),
    (14, 'Meera'),
    (15, 'Kunal'),
    (16, 'Swati'),
    (17, 'Arun'),
    (18, 'Sarika'),
    (19, 'Prakash'),
    (20, 'Shalini');

INSERT INTO Table2 (ID, Description)
VALUES
   (1, 'Software Engineer'),
    (2, 'Data Analyst'),
    (3, 'Project Manager'),
    (4, 'Marketing Specialist'),
    (5, 'HR Manager'),
    (6, 'Financial Analyst'),
    (7, 'UI/UX Designer'),
    (8, 'Sales Executive'),
    (9, 'Quality Assurance Engineer'),
    (10, 'Business Analyst'),
    (11, 'Product Manager'),
    (12, 'Customer Support Representative'),
    (13, 'Graphic Designer'),
    (14, 'System Administrator'),
    (15, 'Operations Manager'),
    (16, 'Content Writer'),
    (17, 'Network Engineer'),
    (18, 'Legal Counsel'),
    (19, 'Database Administrator'),
    (20, 'IT Director');

    select * from Table1
	select * from Table2


-- join with procedure
CREATE PROCEDURE JoinTablesProcedure
as 
    SELECT Table1.ID, Table1.Name, Table2.Description
    FROM Table1 
    left JOIN Table2 ON Table1.ID = Table2.ID;


--join with function
CREATE FUNCTION JoinTablesFunction()
RETURNS TABLE
AS
RETURN (
    SELECT Table1.ID, Table1.Name, Table2.Description
    FROM Table1
    right JOIN Table2 ON Table1.ID = Table2.ID
);

-- Join with view
CREATE VIEW JoinedTablesView AS
SELECT Table1.ID, Table1.Name, Table2.Description
FROM Table1
right JOIN Table2 ON Table1.ID = Table2.ID;



-- SP, function and view execution
exec JoinTablesProcedure
select * from JoinTablesFunction()
select * from JoinedTablesView