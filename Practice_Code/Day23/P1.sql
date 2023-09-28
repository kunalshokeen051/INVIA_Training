use Day23

CREATE TABLE Student_Data (
    StudentID INT PRIMARY KEY IDENTITY(1,1),
    StudentName VARCHAR(255),
    StudentClass VARCHAR(50),
    StudentAdmissionNo VARCHAR(20) UNIQUE,
    StudentFeesStatus VARCHAR(20)
);

CREATE TABLE Fees_Record (
    StudentID INT PRIMARY KEY,
    FOREIGN KEY (StudentID) REFERENCES Student_Data(StudentID),
    AdmissionNumber VARCHAR(20),
    Fees DECIMAL(10, 2),
    Class VARCHAR(50)
);

CREATE TABLE Audit_Log (
    AuditID INT PRIMARY KEY IDENTITY(1,1),
    Action VARCHAR(10),
    TableName VARCHAR(50),
    RecordID INT,
    Timestamp DATETIME
);

INSERT INTO Student_Data (StudentName, StudentClass, StudentAdmissionNo, StudentFeesStatus)
VALUES
    ('rahul sharma', 'Grade 10', 'AD12345', 'Paid'),
    ('rahul yadav', 'Grade 11', 'AD23456', 'Paid'),
    ('rahul', 'Grade 9', 'AD34567', 'Unpaid'),
    ('pankaj sharma', 'Grade 10', 'AD45678', 'Paid'),
    ('pankaj yadav', 'Grade 11', 'AD56789', 'Unpaid'),
    ('pankaj', 'Grade 9', 'AD67890', 'Paid'),
    ('pankaj gupta', 'Grade 10', 'AD78901', 'Paid'),
    ('pankaj negi', 'Grade 11', 'AD89012', 'Unpaid'),
    ('himanshu sharma', 'Grade 9', 'AD90123', 'Paid'),
    ('himanshu yadav', 'Grade 10', 'AD01234', 'Unpaid');


INSERT INTO Fees_Record (StudentID, AdmissionNumber, Fees, Class)
VALUES
    (1, 'AD12345', 500.00, 'Grade 10'),
    (2, 'AD23456', 600.00, 'Grade 11'),
    (3, 'AD34567', 450.00, 'Grade 9'),
    (4, 'AD45678', 500.00, 'Grade 10'),
    (5, 'AD56789', 600.00, 'Grade 11'),
    (6, 'AD67890', 450.00, 'Grade 9'),
    (7, 'AD78901', 500.00, 'Grade 10'),
    (8, 'AD89012', 600.00, 'Grade 11'),
    (9, 'AD90123', 450.00, 'Grade 9'),
    (10, 'AD01234',500.00, 'Grade 10');


CREATE TRIGGER insert_student_data
ON Student_Data
for INSERT
AS
BEGIN
-- Adding a condition to not add student with unpaid fees
   if exists( select 1 from inserted where StudentFeesStatus = 'Unpaid')
   begin
   print 'Cannot insert a student with unpaid fees'
   rollback transaction
   end
   else
   print 'Student record Added'
    INSERT INTO Audit_Log (Action, TableName, RecordID, Timestamp)
    SELECT 'INSERT', 'Student_Data', I.StudentID, GETDATE()
    FROM INSERTED I;
   commit
END

--UPDATE_TRIGGER
CREATE TRIGGER after_update_student_data
ON Student_Data
AFTER UPDATE
AS
BEGIN
    INSERT INTO Audit_Log (Action, TableName, RecordID, Timestamp)
    SELECT 'UPDATE', 'Student_Data', StudentID, GETDATE()
    FROM INSERTED;
END;


-- DELETE_TRIGGER
CREATE TRIGGER after_delete_student_data
ON Student_Data
AFTER DELETE
AS
BEGIN
    INSERT INTO Audit_Log (Action, TableName, RecordID, Timestamp)
    SELECT 'DELETE', 'Student_Data', StudentID, GETDATE()
    FROM DELETED;
END;

-- INSTEAD OF INSERT TRIGGER
CREATE TRIGGER instead_of_insert_student_data
ON Student_Data
INSTEAD OF INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM INSERTED
        WHERE StudentFeesStatus = 'Unpaid'
    )
    BEGIN
        print'Cannot insert students with unpaid fees.'
        ROLLBACK TRANSACTION 
    END;
END

-- drop trigger instead_of_insert_student_data
-----------------------------------------------------------------------------------------------

insert into Student_Data values ('Kunal Shokeen', 'Grade 12', 'AD12346', 'Unpaid')
delete from Student_Data where StudentName = 'Kunal shokeen'
delete from Audit_Log where RecordID = 18

-- getdate() is a function to get current date eg. 2023-09-11 15:26:38.267

insert into Student_Data values ('Kunal Shokeen', 'Grade 12', 'AD12346', 'Paid')

select * from Audit_Log
select * from Student_Data

delete from Student_Data where  StudentName = 'kunal sharma'
update Student_Data set StudentName = 'kunal sharma' where StudentName = 'kunal shokeen'




