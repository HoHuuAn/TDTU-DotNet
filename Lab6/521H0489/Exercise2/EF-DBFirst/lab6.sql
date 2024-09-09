CREATE DATABASE lab6;

USE lab6;

-- Create the "Manufacture" table
CREATE TABLE Manufacture (
    ID INT PRIMARY KEY,
    Name VARCHAR(50),
    Location VARCHAR(50),
    Employee INT
);

-- Create the "Phone" table
CREATE TABLE Phone (
    ID VARCHAR(50) PRIMARY KEY,
    Name VARCHAR(50),
    Price INT,
    Color VARCHAR(50),
    Country VARCHAR(50),
    Quantity INT,
    ManufactureId INT,
    FOREIGN KEY (ManufactureId) REFERENCES Manufacture(ID)
);