use Day22

create table salary(ID int, Amount int) 

-- Trigger(special Type of stored Procedure)
--(DML Operation)

create trigger Greeting on table1
for insert
as
begin
print 'Welcome to our Organisation !'
end

create trigger NewGreeting on Table1
after insert
as
begin
print 'Welcome to our Organisation 2 !'
end

create trigger DeleteRecord on Table1
for delete
as
begin
print 'Record successfully deleted'
end


insert into Table1(ID,Name) values
(21,'kunal shokeen')

delete from Table1 
where Name = 'kunal shokeen'  





