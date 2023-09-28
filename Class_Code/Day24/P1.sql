create Database Day24
use Day24

create table student(
id int identity(1,1),
std_fname varchar(100),
std_lname varchar(100),
std_add_num int,
std_Age int,
std_city varchar(100)
)

INSERT INTO student (std_fname, std_lname, std_add_num, std_Age, std_city)
VALUES
    ('Amit', 'Sharma', 101, 22, 'Delhi'),
    ('Priya', 'Patel', 202, 20, 'Mumbai'),
    ('Rajesh', 'Kumar', 303, 23, 'Bangalore'),
    ('Sneha', 'Gupta', 404, 21, 'Kolkata'),
    ('Vikram', 'Singh', 505, 24, 'Chennai'),
    ('Ananya', 'Mishra', 606, 19, 'Hyderabad'),
    ('Neha', 'Verma', 707, 22, 'Pune'),
    ('Rahul', 'Yadav', 808, 20, 'Ahmedabad'),
    ('Meera', 'Joshi', 909, 23, 'Jaipur'),
   ('Sanjay', 'Malik', 1010, 21, 'Lucknow');

select * from student


declare    @fn varchar(20),   @age int declare Mycollection cursorfor select std_fname,std_Age from Studentopen Mycollection	WHILE @@FETCH_STATUS = 0	begin	fetch next from Mycollection into @fn, @age	PRINT @fn + CAST(@age AS varchar)	endclose Mycollectiondeallocate Mycollection




-- CURSOR TO FETCH ID from student table
declare 
@id int;

declare fetch_id_cursor cursor
for select std_add_num from student

open fetch_id_cursor
fetch next from fetch_id_cursor into @id
while @@FETCH_STATUS = 0 
begin
print 'Id:' + ' ' + cast(@id as varchar)
fetch next from fetch_id_cursor into @id
end

close fetch_id_cursor
deallocate fetch_id_cursor










