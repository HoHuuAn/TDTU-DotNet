CREATE DATABASE Lab5_Ex7;

GO
USE Lab5_Ex7;

GO
CREATE TABLE students (
    id INT PRIMARY KEY,
    name VARCHAR(50),
    age INT,
    score DECIMAL(3, 1),
    email VARCHAR(100)
);

GO
INSERT INTO students (id, name, age, score, email)
VALUES
    (1, 'Ho Huu An', 20, 9.5, '521H0489@student.tdtu.edu.vn'),
    (2, 'John Doe', 20, 8.5, 'john.doe@example.com'),
    (3, 'Jane Smith', 22, 9.2, 'jane.smith@example.com'),
    (4, 'Michael Johnson', 21, 7.9, 'michael.johnson@example.com'),
    (5, 'Emily Davis', 19, 9.1, 'emily.davis@example.com'),
    (6, 'David Wilson', 23, 8.7, 'david.wilson@example.com');

-- Displays a list of all students
GO
CREATE PROCEDURE SelectAllStudents
AS
BEGIN
    SELECT * FROM students;
END;

-- add a new student
GO
CREATE PROCEDURE InsertStudent
    @id INT,
    @name VARCHAR(50),
    @age INT,
    @score DECIMAL(3, 1),
    @email VARCHAR(100)
AS
BEGIN
    INSERT INTO students (id, name, age, score, email)
    VALUES (@id, @name, @age, @score, @email);
END;

--Search for students by any criteria in that student's attributes
GO
CREATE PROCEDURE SearchStudentsByCriteria
    @searchCriteria NVARCHAR(MAX)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    SET @sql = N'SELECT * FROM students WHERE ' + @searchCriteria;

    EXEC sp_executesql @sql;
END;

-- Sort the student list by a certain criterion
GO
CREATE PROCEDURE SortStudentsByCriterion
    @criterion VARCHAR(50)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);

    SET @sql = N'SELECT * FROM students ORDER BY ' + QUOTENAME(@criterion);

    EXEC sp_executesql @sql;
END;

--Delete a student by id
GO
CREATE PROCEDURE DeleteStudentByID
    @id INT
AS
BEGIN
    DELETE FROM students WHERE id = @id;
END;


INSERT INTO students (id, name, age, score, email)
VALUES
    (6, 'David Wilson', 23, 8.7, 'david.wilson@example.com');