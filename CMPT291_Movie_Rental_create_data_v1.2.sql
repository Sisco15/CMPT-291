USE Proj2025F;

--
-- Clean up DB schema
--

DROP SEQUENCE IF EXISTS Customer_CustomerID_Seq;
DROP SEQUENCE IF EXISTS Employee_EmployeeID_Seq;

DROP TABLE IF EXISTS ActorRate;
DROP TABLE IF EXISTS RentalRecord;
DROP TABLE IF EXISTS ActorAppear;
DROP TABLE IF EXISTS Actor;
DROP TABLE IF EXISTS CustomerQueue;
DROP TABLE IF EXISTS Movie;
DROP TABLE IF EXISTS CustomerPhone;
DROP TABLE IF EXISTS Customer;
DROP TABLE IF EXISTS EmployeePhone;
DROP TABLE IF EXISTS Employee;
DROP TABLE IF EXISTS User_log;

--
-- Create tables
-- https://www.w3schools.com/sql/sql_create_db.asp
-- https://learn.microsoft.com/en-us/sql/t-sql/data-types/data-types-transact-sql?view=sql-server-ver16
-- https://learn.microsoft.com/en-us/sql/relational-databases/tables/unique-constraints-and-check-constraints?view=sql-server-ver16
--

CREATE TABLE User_log(
EmployeeID INT,
username VARCHAR(40) NOT NULL,
pass_word VARCHAR(40) NOT NULL,
PRIMARY KEY( EmployeeID )
);

CREATE TABLE Employee (
EmployeeID INT,
SSN NCHAR(9) NOT NULL,
LastName VARCHAR(40) NOT NULL,
FirstName VARCHAR(40) NOT NULL,
Address VARCHAR(40),
City VARCHAR(40),
Province NCHAR(2),
PostalCode NCHAR(6),
StartDate DATE NOT NULL,
PRIMARY KEY( EmployeeID )
);


CREATE SEQUENCE Employee_EmployeeID_Seq START WITH 1000 INCREMENT BY 1;


CREATE TABLE EmployeePhone (
EmployeeID INT NOT NULL,
PhoneNum NCHAR(10) NOT NULL,
PhoneType VARCHAR(10) NOT NULL,
StartTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
EndTime DATETIME,
PRIMARY KEY( EmployeeID, PhoneNum, StartTime ),
FOREIGN KEY ( EmployeeID ) REFERENCES Employee( EmployeeID ),
CONSTRAINT EmpPhonePeriod CHECK (StartTime < EndTime)
);


CREATE TABLE Customer (
CustomerID INT,
LastName VARCHAR(40) NOT NULL,
FirstName VARCHAR(40) NOT NULL,
Address VARCHAR(40),
City VARCHAR(40),
Province NCHAR(2),
PostalCode NCHAR(6),
Email VARCHAR(40) NOT NULL,
AccountNum NCHAR(10) NOT NULL,
CreditCardNum NCHAR(16) NOT NULL,
CreditCardExp NCHAR(4) NOT NULL,
CreditCardCvv NCHAR(3) NOT NULL,
CreationDate DATE NOT NULL DEFAULT CURRENT_TIMESTAMP,
PRIMARY KEY( CustomerID )
);

CREATE SEQUENCE Customer_CustomerID_Seq START WITH 1000 INCREMENT BY 1;

CREATE TABLE CustomerPhone (
CustomerID INT NOT NULL,
PhoneNum NCHAR(10) NOT NULL,
PhoneType VARCHAR(10) NOT NULL,
StartTime DATETIME NOT NULL DEFAULT(getdate()),
EndTime DATETIME,
PRIMARY KEY( CustomerID, PhoneNum, StartTime ),
FOREIGN KEY ( CustomerID ) REFERENCES Customer( CustomerID ),
CONSTRAINT CustPhonePeriod CHECK (StartTime < EndTime)
);


CREATE TABLE Movie (
MovieID INT NOT NULL IDENTITY(1,1),
MovieName VARCHAR(40) NOT NULL,
MovieType VARCHAR(10) NOT NULL
	CHECK( MovieType='Comedy' or MovieType='Drama' or MovieType='Action' or MovieType='Foreign' ),
Fee NUMERIC(6,2) NOT NULL,
NumOfCopy INT NOT NULL,
MovieAveRate INT NOT NULL,
PRIMARY KEY( MovieID )
);


CREATE TABLE CustomerQueue (
CustomerID INT NOT NULL,
MovieID INT NOT NULL,
SortNum INT NOT NULL,
PRIMARY KEY ( CustomerID, MovieID ),
UNIQUE ( CustomerID, SortNum ),
FOREIGN KEY ( CustomerID ) REFERENCES Customer( CustomerID ),
FOREIGN KEY ( MovieID ) REFERENCES Movie( MovieID )
);



CREATE TABLE Actor (
ActorID INT IDENTITY(1,1),
Name VARCHAR(100) NOT NULL,
Gender NCHAR(1) NOT NULL CHECK( Gender='M' or Gender='F' ),
DateOfBrith Date NOT NULL,
PRIMARY KEY( ActorID )
);

CREATE TABLE ActorAppear (
MovieID INT NOT NULL,
ActorID INT NOT NULL,
PRIMARY KEY ( MovieID, ActorID ),
FOREIGN KEY ( MovieID ) REFERENCES Movie( MovieID ),
FOREIGN KEY ( ActorID ) REFERENCES Actor( ActorID )
);



CREATE TABLE RentalRecord (
RentalRecordID INT IDENTITY(1,1),
EmployeeID INT NOT NULL,
CustomerID INT NOT NULL,
MovieID INT NOT NULL,
CheckoutTime DATETIME NOT NULL DEFAULT(getdate()),
ReturnTime DATETIME,
MovieRate INT,
PRIMARY KEY( RentalRecordID ),
FOREIGN KEY ( EmployeeID ) REFERENCES Employee( EmployeeID ),
FOREIGN KEY ( CustomerID ) REFERENCES Customer( CustomerID ),
FOREIGN KEY ( MovieID ) REFERENCES Movie( MovieID )
);


CREATE TABLE ActorRate (
RentalRecordID INT NOT NULL,
ActorID INT NOT Null,
ActorRate INT,
FOREIGN KEY ( RentalRecordID ) REFERENCES RentalRecord( RentalRecordID ),
FOREIGN KEY ( ActorID ) REFERENCES Actor( ActorID )
);

