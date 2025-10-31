Use Assignment4

Drop SEQUENCE IF EXISTS Customer_AccountNumber_Seq;

DROP TABLE IF EXISTS CustomerPhone;
DROP TABLE IF EXISTS Customer;
DROP TABLE IF EXISTS EmployeePhone;
DROP TABLE IF EXISTS Employee;

CREATE TABLE Employee (
EmployeeID INT IDENTITY(1,1),
SSN NCHAR(9) NOT NULL,
LastName VARCHAR(40) NOT NULL,
FirstName VARCHAR(40) NOT NULL,
Address VARCHAR(35) NOT NULL,
City VARCHAR(50) NOT NULL,
State VARCHAR (50) NOT NULL,
ZipCode VARCHAR(10) NOT NULL,
StartDate DATE NOT NULL DEFAULT(getdate()),
PRIMARY KEY( EmployeeID ),
UNIQUE ( SSN ),
);

CREATE TABLE EmployeePhone (
EmployeeID INT NOT NULL,
PhoneNum NCHAR(10) NOT NULL,
PhoneType VARCHAR(10) NOT NULL,
PRIMARY KEY( EmployeeID, PhoneNum),
FOREIGN KEY ( EmployeeID ) REFERENCES Employee( EmployeeID ),
);



CREATE TABLE Customer (
CustomerID INT IDENTITY(1,1),
LastName VARCHAR(40) NOT NULL,
FirstName VARCHAR(40) NOT NULL,
Address VARCHAR(35) NOT NULL,
City VARCHAR(50) NOT NULL,
State VARCHAR (50) NOT NULL,
ZipCode VARCHAR(10) NOT NULL,
AccountNumber INT NOT NULL,
EmailAddress VARCHAR(50) NOT NULL,
AccountCreateDate DATE NOT NULL DEFAULT(getdate()),
CreditCardNumber VARCHAR(20) NOT NULL,
PRIMARY KEY( CustomerID ),
UNIQUE( AccountNumber ),
);
CREATE SEQUENCE Customer_AccountNumber_Seq start with 1000 INCREMENT by 1;

CREATE TABLE CustomerPhone (
CustomerID INT NOT NULL,
PhoneNum NCHAR(10) NOT NULL,
PhoneType VARCHAR(10) NOT NULL,
PRIMARY KEY( CustomerID, PhoneNum),
FOREIGN KEY ( CustomerID ) REFERENCES Customer( CustomerID ),
);