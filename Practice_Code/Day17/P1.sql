-- Palidrome Number Program 
CREATE FUNCTION Palidrome(@num INT)
RETURNS VARCHAR(200)    
AS
BEGIN
DECLARE @temp VARCHAR(100)
IF(num=REVERSE(@num))
BEGIN
SET @temp= 'IS PALIDROME'
END
ELSE 
BEGIN
SET @temp= 'IS NOT Palidrome'
RETURN  @temp
END
END

PRINT dbo.Palidrome(1221)