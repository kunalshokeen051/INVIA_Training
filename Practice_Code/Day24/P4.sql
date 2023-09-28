use Day24

--table schema refernce
--id int identity(1,1),
--std_fname varchar(100),
--std_lname varchar(100),
--std_add_num int,
--std_Age int,
--std_city varchar(100)

select GETDATE()

declare @date date
declare @year int
set @date = GETDATE()
set @year = cast(year(GETDATE()) as int)

print @year + 1
select DATEDIFF ( yyyy, '1999/11/25',@date)  as Age


CREATE TABLE SampleData (
    ID INT PRIMARY KEY,
    DataValue VARCHAR(50),
    CreatedDate DATETIME
);

create PROCEDURE InsertData
    @ID INT,
    @DataValue VARCHAR(50)
AS
BEGIN
BEGIN TRANSACTION
    BEGIN TRY
        DECLARE @CurrentDate DATETIME = GETDATE()
		if(@ID > 0)
		begin
        INSERT INTO SampleData (ID, DataValue, CreatedDate)
        VALUES (@ID, @DataValue, @CurrentDate)
        COMMIT
		end
		else
		begin;
		throw 50000, 'ID value cannot be less than 0',0  -- Error code, error_message and error state
		end;
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'An error occurred: ' + ERROR_MESSAGE()
    END CATCH
END;

drop proc InsertData

exec InsertData  -1,'kunal shokeen'

select * from SampleData





