use Day19

create Table Employee 
(
  EmpId int primary key,
  EmpName varchar(20),
  EmpAge int
)

select * from Employee

create proc AddEmployee
@ID int,
@Name varchar(20),
@Age int
as
 begin
  insert into Employee(EmpId, EmpName, EmpAge) values (@ID,@Name,@Age)
 end

 create proc UpdateEmployee
@ID int,
@Age int
as
 begin
  update employee set EmpAge = @Age
  Where EmpId = @ID
 end

create proc DeleteEmployee
@ID int
as
 begin
  delete from Employee
 Where EmpId = @ID
 end

exec dbo.AddEmployee 1,'Kunal shokeen',22
exec dbo.UpdateEmployee 1, 24
exec dbo.DeleteEmployee 1
							 

-- Search Record using ID and return name
create proc SearchName
@ID int,
@name varchar(20) output   --to return any datatype other than Int 
as                         --we uses Output 
 begin
  select @name= EmpName from Employee where EmpId =@ID
 end


 declare @n varchar(20)
 exec SearchName 1, @n output      -- Function Name -> SearchName  
 print @n                          -- Input -> 1
                                  -- Program Output --> In 'n' variable


-- Search Record using ID and return Name and Age
create proc SearchData
@ID int,
@name varchar(20) output ,
@ag int output
as                         
 begin
  select @name= EmpName, @ag=EmpAge from Employee where EmpId =@ID
 end


  declare @n varchar(20)
  declare @a int
 exec SearchData 1, @n output , @a output    
 print @n 
 print @a

 --returning All records
create proc DisplayData
as                         
 begin
  select * from Employee
 end

 exec DisplayData