use tempdb

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