use Day24

--table schema refernce
--id int identity(1,1),
--std_fname varchar(100),
--std_lname varchar(100),
--std_add_num int,
--std_Age int,
--std_city varchar(100)

CREATE PROCEDURE GetStudentName
AS
BEGIN
    declare @f_name varchar(50)
    declare @l_name varchar(50)
	 declare @ctr int=0 


    DECLARE Mycollection CURSOR FOR
    SELECT std_fname, std_lname FROM Student

    OPEN Mycollection

    WHILE (@ctr <(select count(*) from student))
    BEGIN
        FETCH NEXT FROM Mycollection INTO @f_name, @l_name 
        PRINT @f_name + ' ' + @l_name 
		set @ctr = @ctr + 1
    END

    CLOSE Mycollection
    DEALLOCATE Mycollection
END

exec GetStudentName


