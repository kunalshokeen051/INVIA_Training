
--While Loop
DECLARE @ctr INT
 SET @ctr = 1
 WHILE(@ctr<10)
  BEGIN 
   PRINT @ctr
   SET @ctr = @ctr+1
  END

--Creating Function
CREATE FUNCTION walk()
RETURNS INT        -- returns the type of the return data
AS
BEGIN
  DECLARE @temp1 INT
  SET @temp1=10
  RETURN @temp1     -- return tells about the data to be returned
END

PRINT dbo.walk()

--Altering values in Function
ALTER FUNCTION walk()
RETURNS INT       
AS
BEGIN
  DECLARE @temp1 INT
  SET @temp1=12
  RETURN @temp1    
END
PRINT dbo.walk()

--passing parameter iun Function
CREATE FUNCTION fact(@ctr int)      -- Declare keyword not allowed in function parameter
RETURNS INT
AS
 BEGIN
  RETURN @CTR
 END
PRINT dbo.fact(1)


-- Complex function execution
CREATE FUNCTION MyFunc()
RETURNS INT
AS
 BEGIN
 DECLARE @CTR INT
 SET @CTR = 12
   RETURN @CTR
 END


DECLARE @result INT
 SET @result = dbo.MyFunc()
if(@result < 13)
 BEGIN
   PRINT 'quit'
 END

ELSE
 BEGIN
 PRINT 'welcome'
 END












