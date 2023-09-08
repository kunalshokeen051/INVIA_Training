
select * from Student
select * from fee

create Proc SearchData
@admID int 
as
begin
    select student.admission_no,
    student.first_name,
    student.last_name,
    fee.course,
    fee.amount_paid
    from student
    inner join fee
    on student.admission_no = fee.admission_no
	where student.admission_no = @admID
end

create Proc GetData
@admID int 
as
begin
    select student.admission_no,
    student.first_name,
    student.last_name,
    fee.course,
    fee.amount_paid
    from student
    inner join fee
    on student.admission_no = fee.admission_no
end

exec SearchData 3354
exec GetData

create view ViewGetData
as
   select student.admission_no,
    student.first_name,
    student.last_name,
    fee.course,
    fee.amount_paid
    from student
    inner join fee
    on student.admission_no = fee.admission_no
 
 create function FGetData()
returns table
as
return
(
    select student.admission_no,
    student.first_name,
    student.last_name,
    fee.course,
    fee.amount_paid
    from student
    inner join fee
    on student.admission_no = fee.admission_no
)


create function FGetData2(@aNo int)
returns table
as
return
(
    select student.admission_no,
    student.first_name,
    student.last_name,
    fee.course,
    fee.amount_paid
    from student
    inner join fee
    on student.admission_no = fee.admission_no
	where student.admission_no = @aNo
)


select * from ViewGetData
select * from FGetData()
select * from FGetData2(10)

