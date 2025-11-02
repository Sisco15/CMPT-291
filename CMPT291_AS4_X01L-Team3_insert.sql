USE Assignment4;

DELETE FROM AppearedIn;
DELETE FROM Actor;
DELETE EmployeePhone;
DELETE Employee;
DELETE CustomerPhone;
DELETE Customer;
DELETE Movie;

INSERT INTO Movie (MovieID, MovieName, MovieType, Fee, NumOfCopy)
	VALUES( NEXT VALUE FOR Movie_MovieID_Seq, 'The Fantastic Four: First Steps', 'Action', 5.0, 10);

INSERT INTO Movie (MovieID, MovieName, MovieType, Fee, NumOfCopy)
	VALUES( NEXT VALUE FOR Movie_MovieID_Seq, 'Top Gun: Maverick', 'Action', 7.0, 3);


INSERT INTO Customer(LastName, FirstName, Address, City, State, ZipCode, AccountNumber ,EmailAddress, CreditCardNumber)
	Values('Smith', 'John', '123456 test St.', 'Edmonton', 'Alberta', 'abc 1b2', NEXT VALUE FOR Customer_AccountNumber_Seq,'test@gmail.com', '1234 5678 91029 1293')

INSERT INTO CustomerPhone(CustomerID, PhoneNum, PhoneType)
	values( (SELECT CustomerID FROM Customer WHERE AccountNumber = '1000'), '7807654321', 'Home')

INSERT INTO Employee (SSN, LastName, FirstName, Address, City, State, ZipCode, StartDate)
	VALUES ('123456789', 'Smith', 'John','123456 test St.', 'Edmonton', 'Alberta', 'DEF 1C2', '2024-10-29');

INSERT INTO EmployeePhone (EmployeeID, PhoneNum, PhoneType)
	VALUES( (SELECT EmployeeID FROM Employee WHERE SSN = '123456789'),
		'7807635232', 'Home' )

INSERT INTO Actor (ActorName, Gender, DoB)
	VALUES ('Chris Evans', 'M', '1981-06-13');

INSERT INTO Actor (ActorName, Gender, DoB)
	VALUES ('Scarlett Johansson', 'F', '1984-11-22');

INSERT INTO Actor (ActorName, Gender, DoB)
	VALUES ('Tom Cruise', 'M', '1962-07-03');

INSERT INTO Actor (ActorName, Gender, DoB)
	VALUES ('Miles Teller', 'M', '1987-02-20');

INSERT INTO AppearedIn (ActorID, MovieID)
	VALUES (
		(SELECT ActorID FROM Actor WHERE ActorName = 'Chris Evans'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'The Fantastic Four: First Steps')
	);

INSERT INTO AppearedIn (ActorID, MovieID)
	VALUES (
		(SELECT ActorID FROM Actor WHERE ActorName = 'Tom Cruise'),
		(SELECT MovieID FROM Movie WHERE MovieName = 'Top Gun: Maverick')
	);

INSERT INTO AppearedIn (ActorID, MovieID)
VALUES (
    (SELECT ActorID FROM Actor WHERE ActorName = 'Miles Teller'),
    (SELECT MovieID FROM Movie WHERE MovieName = 'Top Gun: Maverick')
);
