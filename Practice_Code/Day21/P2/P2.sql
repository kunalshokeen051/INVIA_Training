-- Create the department_details table
CREATE TABLE department_details (
    department_id INT PRIMARY KEY,
    department_name VARCHAR(255)
);

-- Insert 20 entries into the department_details table
INSERT INTO department_details (department_id, department_name)
VALUES
    (1, 'Computer Science'),
    (2, 'Mathematics'),
    (3, 'Biology'),
    (4, 'Physics'),
    (5, 'Chemistry'),
    (6, 'History'),
    (7, 'English'),
    (8, 'Psychology'),
    (9, 'Economics'),
    (10, 'Engineering');

-- Create the students_details table
CREATE TABLE students_details (
    student_id INT PRIMARY KEY,
    student_name VARCHAR(255),
    birthdate DATE,
    department_id INT,
    FOREIGN KEY (department_id) REFERENCES department_details(department_id)
);

-- Insert 20 entries into the students_details table
INSERT INTO students_details (student_id, student_name, birthdate, department_id)
VALUES
    (1, 'Amit Patel', '2000-01-15', 1),
    (2, 'Priya Sharma', '2001-03-20', 2),
    (3, 'Rahul Singh', '1999-07-10', 1),
    (4, 'Neha Verma', '2002-05-05', 3),
    (5, 'Ravi Kumar', '2000-11-30', 4),
    (6, 'Sneha Gupta', '2003-02-18', 5),
    (7, 'Vikas Rajput', '2001-08-22', 6),
    (8, 'Anjali Mishra', '1998-12-12', 7),
    (9, 'Rajesh Tiwari', '2002-04-25', 8),
    (10, 'Suman Joshi', '2000-09-07', 9),
    (11, 'Aruna Singh', '2001-06-14', 10),
    (12, 'Sanjay Pandey', '1999-10-08', 1),
    (13, 'Meena Sharma', '2003-03-03', 2),
    (14, 'Alok Yadav', '2000-07-19', 3),
    (15, 'Pooja Gupta', '2002-01-27', 4),
    (16, 'Rajiv Kumar', '2001-04-09', 5),
    (17, 'Anita Verma', '1999-09-02', 6),
    (18, 'Ramesh Singh', '2003-06-16', 7),
    (19, 'Nisha Yadav', '2000-12-05', 8),
    (20, 'Deepak Sharma', '2002-02-28', 9);


