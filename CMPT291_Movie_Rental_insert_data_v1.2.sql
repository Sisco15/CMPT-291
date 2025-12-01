USE CMPT291_proj;

--
-- Remove test data
--

DELETE ActorRate;
DELETE RentalRecord;
DELETE ActorAppear;
DELETE Actor;
DELETE CustomerQueue;
DELETE Movie;
DELETE CustomerPhone;
DELETE Customer;
DELETE EmployeePhone;
DELETE Employee;
DELETE User_log;



--
-- Add test data
--

--INSERT INTO <target_table> SELECT <columns> FROM <source_table>
--INSERT INTO table_name (column1, column2, column3, ...)
	--VALUES (value1, value2, value3, ...),
	--	(value1, value2, value3, ...);
--select getDate();

INSERT INTO User_log (EmployeeID, username, pass_word, SSN)
	VALUES (NEXT VALUE FOR Employee_EmployeeID_Seq, 'John', '81dc9bdb52d04dc20036dbd8313ed055', '111222333');

INSERT INTO Employee (EmployeeID, SSN, LastName, FirstName, StartDate)
	VALUES ((select EmployeeID from User_log where SSN = '111222333' and username = 'John' ), '111222333', 'Smith', 'John', '2024-10-29');

INSERT INTO EmployeePhone (EmployeeID, PhoneNum, PhoneType)
	VALUES( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		'7807654321', 'Home' );

INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, 
		PostalCode, Email, AccountNum, CreditCardNum, CreditCardExp, CreditCardCvv)
	VALUES ( NEXT VALUE FOR Customer_CustomerID_Seq, 'Customer1', 'Last1', 
		'11101 111st', 'Edmonton', 'AB', 'A1A1A1', 'cust1@gmail.com', 'ABC001', 
		'1111222233334444', '1027', '111');
		INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, 
		PostalCode, Email, AccountNum, CreditCardNum, CreditCardExp, CreditCardCvv)
	VALUES ( NEXT VALUE FOR Customer_CustomerID_Seq, 'last2', 'customer2', 
		'11101 111st', 'Edmonton', 'AB', 'A1A1A1', 'cust2@gmail.com', 'ABC001', 
		'1111222233334444', '1027', '111');
INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, 
		PostalCode, Email, AccountNum, CreditCardNum, CreditCardExp, CreditCardCvv)
	VALUES ( NEXT VALUE FOR Customer_CustomerID_Seq, 'last3', 'Customer3', 
		'11101 111st', 'Edmonton', 'AB', 'A1A1A1', 'cust3@gmail.com', 'ABC002', 
		'1111222233334444', '1027', '111');
INSERT INTO Customer (CustomerID, LastName, FirstName, Address, City, Province, 
		PostalCode, Email, AccountNum, CreditCardNum, CreditCardExp, CreditCardCvv)
	VALUES ( NEXT VALUE FOR Customer_CustomerID_Seq, 'last4', 'Customer4', 
		'11101 111st', 'Edmonton', 'AB', 'A1A1A1', 'cust4@gmail.com', 'ABC003', 
		'1111222233334444', '1027', '111');


INSERT INTO CustomerPhone (CustomerID, PhoneNum, PhoneType)
	VALUES ( (SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com'),
		'7801111111', 'Home' );


INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy, MovieAveRate)
	VALUES ( 'Die Hard', 'Action', 3.5, 5, 3);

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy, MovieAveRate)
	VALUES ('Die Hard 2', 'Action', 4.5, 4, 4);

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy, MovieAveRate)
	VALUES ( 'Die Hard 3', 'Action', 5.5, 3, 5);

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy, MovieAveRate)
	VALUES ( 'DeadPool', 'Action', 5.5, 3, 5);

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy, MovieAveRate)
	VALUES ( 'BOOM', 'Action', 5.5, 3, 5);

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy, MovieAveRate)
	VALUES ( 'POOOOWWW', 'Action', 5.5, 3, 5);

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy, MovieAveRate)
	VALUES ( 'Army2', 'Action', 5.5, 3, 3);

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy, MovieAveRate)
	VALUES ( 'Titanic', 'Drama', 5.5, 3, 5);

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy, MovieAveRate)
	VALUES ( 'Blowup', 'Action', 3.5, 5, 3);

INSERT INTO Movie (MovieName, MovieType, Fee, NumOfCopy, MovieAveRate)
	VALUES ( 'Guns and Things', 'Action', 5.5, 3, 3);


INSERT INTO Actor (Name, Gender, DateOfBrith)
	VALUES ( 'Bruce Wills', 'M', '1955-03-19' )

INSERT INTO ActorAppear 
	VALUES ( (SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard'),
		(SELECT ActorID FROM Actor WHERE Name = 'Bruce Wills') )

INSERT INTO ActorAppear 
	VALUES ( (SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 2'),
		(SELECT ActorID FROM Actor WHERE Name = 'Bruce Wills') )

INSERT INTO ActorAppear 
	VALUES ( (SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 3'),
		(SELECT ActorID FROM Actor WHERE Name = 'Bruce Wills') )


INSERT INTO Customerqueue
	VALUES ( (SELECT CustomerID FROM Customer WHERE LastName = 'Customer1'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 2'), 2)

INSERT INTO Customerqueue
	VALUES ( (SELECT CustomerID FROM Customer WHERE LastName = 'Customer1'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 3'), 3)


INSERT INTO RentalRecord (EmployeeID, CustomerID, MovieID, MovieRate)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard'), 5 )

INSERT INTO RentalRecord (EmployeeID, CustomerID, MovieID, MovieRate)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'POOOOWWW'), 5 )


INSERT INTO RentalRecord (EmployeeID, CustomerID, MovieID, MovieRate)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Titanic'), 5 )

INSERT INTO RentalRecord (EmployeeID, CustomerID, MovieID, MovieRate)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 2'), 4 )

INSERT INTO RentalRecord (EmployeeID, CustomerID, MovieID, MovieRate)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE Email = 'cust2@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 2'), 4 )


INSERT INTO RentalRecord (EmployeeID, CustomerID, MovieID, MovieRate)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE Email = 'cust2@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 2'), 4 )

INSERT INTO RentalRecord (EmployeeID, CustomerID, MovieID, MovieRate)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE Email = 'cust2@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 2'), 4 )

INSERT INTO RentalRecord (EmployeeID, CustomerID, MovieID, MovieRate)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE Email = 'cust3@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 2'), 4 )

INSERT INTO RentalRecord (EmployeeID, CustomerID, MovieID, MovieRate)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE Email = 'cust4@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 2'), 4 )

INSERT INTO RentalRecord (EmployeeID, CustomerID, MovieID, MovieRate)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'DeadPool'), 4 )

INSERT INTO RentalRecord (EmployeeID, CustomerID, MovieID, MovieRate)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Boom'), 4 )

INSERT INTO RentalRecord (EmployeeID, CustomerID, MovieID, CheckoutTime,MovieRate)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 3'), 
		'2025-8-19 21:42:14.38',3 )
INSERT INTO RentalRecord (EmployeeID, CustomerID, MovieID, CheckoutTime,MovieRate)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE Email = 'cust2@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 3'), 
		'2025-8-19 21:42:14.38',3 )
INSERT INTO RentalRecord (EmployeeID, CustomerID, MovieID, CheckoutTime,MovieRate)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard 3'), 
		'2025-8-19 21:42:14.38',3 )

INSERT INTO RentalRecord (EmployeeID, CustomerID, MovieID, CheckoutTime,MovieRate)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Guns and Things'), 
		'2025-10-19 21:42:14.38',3 )

INSERT INTO RentalRecord (EmployeeID, CustomerID, MovieID, CheckoutTime,MovieRate)
	VALUES ( (SELECT EmployeeID FROM Employee WHERE SSN = '111222333'),
		(SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Blowup'), 
		'2025-9-19 21:42:14.38',3 )

--INSERT INTO ActorRate (RentalRecordID, ActorID, ActorRate)
--	VALUES ( (SELECT RentalRecordID FROM RentalRecord
--		WHERE EmployeeID = (SELECT EmployeeID FROM Employee WHERE SSN = '111222333')
--		AND CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com')
--		AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard') ),
--		(SELECT ActorID FROM Actor WHERE Name = 'Bruce Wills'), 5 )

INSERT INTO ActorRate (RentalRecordID, ActorID, ActorRate)
	VALUES ( (SELECT RentalRecordID FROM RentalRecord
		WHERE EmployeeID = (SELECT EmployeeID FROM Employee WHERE SSN = '111222333')
		AND CustomerID = (SELECT CustomerID FROM Customer WHERE Email = 'cust1@gmail.com')
		AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard') ),
		(SELECT ActorID FROM ActorAppear  
		WHERE ActorID = (SELECT ActorID from Actor WHERE Name = 'Bruce Wills')
		AND MovieID = (SELECT MovieID FROM Movie WHERE MovieName = 'Die Hard')), 
		5 )
;

--SELECT * FROM EmployeePhone;
--SELECT * FROM Customer;
--SELECT * FROM CustomerPhone;
--SELECT * FROM Movie;
--SELECT * FROM CustomerQueue;
--SELECT * FROM Actor;
--SELECT * FROM ActorAppear;
--SELECT * FROM RentalRecord;
--SELECT * FROM ActorRate;
--SELECT * FROM User_log;



