GO
CREATE DATABASE Lab5

GO
USE Lab5

CREATE TABLE [user]
(
    ID INT PRIMARY KEY,
    Name VARCHAR(50),
    Age INT
)

INSERT INTO [user] (ID, Name, Age)
VALUES	(1, 'Ho Huu An', 20),
		(2, 'John Doe', 25),
		(3, 'Jane Smith', 30),
		(4, 'Tom Johnson', 35);



-- Exercise 4
GO
CREATE PROCEDURE InsertUser
    @ID int,
    @Name nvarchar(50),
    @Age int
AS
BEGIN
    INSERT INTO [User] (ID, Name, Age) VALUES (@ID, @Name, @Age)
END

GO
CREATE PROCEDURE UpdateUser
    @ID int,
    @Name nvarchar(50),
    @Age int
AS
BEGIN
    UPDATE [User] SET Name = @Name, Age = @Age WHERE ID = @ID
END

GO
CREATE PROCEDURE RetrieveUsers
AS
BEGIN
    SELECT * FROM [User]
END

GO
CREATE PROCEDURE GetUsersByID
    @ID int
AS
BEGIN
    SELECT * FROM [User] WHERE ID = @ID
END


--Exercise 5
GO
CREATE PROCEDURE DeleteUser
    @ID INT
AS
BEGIN
    DELETE FROM [User] WHERE ID = @ID;
END

