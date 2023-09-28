use day23

select * from fee

create table fee(
admission_no int primary key,
course varchar(20),
amount_paid int
)


Create trigger AddmissionTrigger
on Student
for insert
as
begin
   declare @co varchar(20)
   declare @amd int
   declare @amt int
   set @co='Database'
   set @amt=10000
   select @amd=I.admission_no from inserted I
   insert into fee (admission_no,course,amount_paid) values (@amd,@co,@amt)

end

