-- View in SQL
Create Database Day20
use Day20

create table Users
(
  UserName varChar(20) Primary Key,
  Pwd varChar(10),
  Age int 
)

insert into Users(UserName, Pwd, Age) values 
('Kunal',12345 ,23),
('pankaj',12346 ,25),
('Nilanshu',1345 ,21),
('pankajs',12346 ,25),
('Nilanshus',1345 ,45),
('Deepak',1345 ,55)


-- Creating a View for the Users Table
create view User_View    
-- View and table has a call_by_reference
as
select UserName from Users 
Where UserName Like '%k' 
or
UserName Like 'k%' 

select * from User_View
select * from Users

--Updating UserName in the view
update User_View set UserName = 'Kunal Shokeen'
where UserName = 'kunal'


--deleting User in the view
delete User_View where UserName = 'pankaj'
SELECT UserName, Age
FROM Users

--Adding in View
Insert into User_View (UserName) values ('pankag kumar')

--Indexes in SQL server
CREATE TABLE Bookstore
(
ISBN_NO    VARCHAR(15) NOT NULL PRIMARY KEY,   -- By default a Clustered index is formed here
 PRICE      FLOAT, 
 temp       int
 INDEX MyIndex(ISBN_NO, PRICE)          --Non-clustered Composite Index on column ISBN_NO and Price
);

insert into Bookstore (ISBN_NO,PRICE,temp) values
(1,12.50,1),
(2,45.23,2),
(3,22.50,3),
(4,15.23,4)

SELECT * from Bookstore

EXEC sp_helpindex 'Bookstore'

drop table Bookstore

create clustered index MyIndex2 on Bookstore(temp)
-- select UserName from Users
