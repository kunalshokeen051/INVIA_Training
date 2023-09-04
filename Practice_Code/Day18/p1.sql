select * from Users

create Function AccountValidater(@usr varChar(20), @pw varChar(10))
returns int
as
begin
 if exist (select * from Users where UserName = @usr and Pwd = @pw)
 begin
 print 'You are SuccessFully logged in'
 end
 else
 begin
 print 'User not found'
 end

end

select dbo.AccountValidater('kunal',12345)  