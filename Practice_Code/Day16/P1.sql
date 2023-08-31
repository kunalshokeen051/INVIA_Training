CREATE DATABASE MyDb;

use MyDb;

CREATE TABLE Customers (
    Customer_id int NOT NULL PRIMARY KEY,
    Customer_Name varchar(20),
    Contact_Number int,
);
SELECT * from Customers

INSERT INTO Customers(Customer_id,Customer_Name,Contact_Number)VALUES(01,'Kunal shokeen',123145);
INSERT INTO Customers(Customer_id,Customer_Name,Contact_Number)VALUES(02,'Nilanshu Yadav',123454);
INSERT INTO Customers(Customer_id,Customer_Name,Contact_Number)VALUES(03,'Pankaj Negi',123475);
INSERT INTO Customers(Customer_id,Customer_Name,Contact_Number)VALUES(04,'Pankaj Sharma',123445);
INSERT INTO Customers(Customer_id,Customer_Name,Contact_Number)VALUES(05,'Aman Gupta',123475);


SELECT * FROM Customers WHERE Customer_id!=3;
SELECT * FROM Customers WHERE Customer_id<=3;

SELECT * FROM Customers ORDER BY Customer_Name;
SELECT * FROM Customers ORDER BY Customer_Name DESC;

SELECT * FROM Customers ORDER BY Customer_Name, Customer_id;

SELECT * FROM Customers WHERE Customer_id<=5 AND Customer_Name LIKE 'p%';



DROP TABLE Customers


					  