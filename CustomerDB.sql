create database CustomerDB
go
use CustomerDB

CREATE TABLE Customers ( 
Id INT IDENTITY(1,1) PRIMARY KEY, 
Name NVARCHAR(100), 
Email NVARCHAR(100) 
); 

INSERT INTO Customers (Name, Email) VALUES 
('John Doe', 'john.doe@tdtu.com'),
('Jane Smith', 'jane.smith@tdtu.com'),
('Trung Pham', 'trung.pham@tdtu.com'), 
('Emily Davis', 'emily.davis@tdtu.com'),
('Thai Pham', 'thai.pham@etdtu.com');

drop table Customers