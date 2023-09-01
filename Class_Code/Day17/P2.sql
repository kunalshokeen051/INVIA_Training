
-- Declaring Variable of Int type 'temp'
DECLARE @temp int
SET @temp=12
PRINT @temp

-- Declaring Variable of string type 'name'
DECLARE @name varChar(20)
SET @name='Kunal Shokeen'
PRINT @name

-- Adding conditions to the variables
DECLARE @age int
SET @age=22
IF(@age <= 23)
 BEGIN
   PRINT @age
END
ELSE
BEGIN
 PRINT 'not correct'
END