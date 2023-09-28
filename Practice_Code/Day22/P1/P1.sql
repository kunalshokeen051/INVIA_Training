use Day22

create table salary(ID int, Amount int) 

-- Trigger(special Type of stored Procedure)
--(DML Operation)


create table NewEmployees(Id int, Name varchar(100))

create trigger InsertTrigger on table1
for insert
as
begin
print 'Welcome Onboard !'
end

create trigger DeleteTrigger on Table1
after Delete
as
begin
print 'Best of Luck!'
end

create trigger UpdateTrigger on Table1
for update
as
begin
print 'Record successfully updated'
end

insert into Table1(ID,Name) values
(21,'kunal shokeen')

delete from Table1 
where Table1.Name = 'kunal shokeen'  

UPDATE Table1
SET Name = 'Kunal shokeen'
WHERE ID = 5

select * from Table1





