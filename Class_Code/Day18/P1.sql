use tempdb

create table Users
(
  UserName varChar(20) Primary Key,
  Pwd varChar(10) Not Null,
  Age int Not Null
)

insert into Users(UserName, Pwd, Age) values 
('Kunal',12345 ,23),
('pankaj',12346 ,25),
('Nilanshu',1345 ,21),
('pankajs',12346 ,25),
('Nilanshus',1345 ,45),
('Deepak',1345 ,55)

select * from Users

create Function AccountValidate(@usr varChar(20), @pw varChar(10))
returns int
as
begin
 declare @ctr int
 select @ctr = count(*) from Users Where UserName = @usr and Pwd= @pw
 return @ctr
end

 -- Show the Output 1 if entry found and 0 if not found
select dbo.AccountValidate('kunal',12345)  

declare @temp int
set @temp = dbo.AccountValidate('kunal',12345)
if(@temp = 0)
begin 
 print 'Does not Exist'
end 
else 
begin
 print 'Log in Successfully'
end

-- group by Keyword
select UserName,Age
from Users
Group By Age,UserName

-- order by Keyword
select UserName,Age
from Users
Group By Age,UserName
Order by Age DESC  
--use either ASC or DESC to sort in ascending or descending order


--If exist Keyword (Return type boolean)
if exists (select * from Users where userName = 'kunal')
begin
print 'User Exists'
End
Else
begin
insert into Users(UserName, Pwd, Age) values ('Kunal',12345 ,23)
end

--Like operator
select * from users 
where UserName Like 'k%' OR UserName Like '%k'
-- % for Multi-character and _ for single character


--having operator in sql
select UserName,Age
from Users
Group By Age,UserName
Having Age < 30
Order by Age DESC 


