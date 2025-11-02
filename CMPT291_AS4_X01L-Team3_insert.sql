USE Assignment4;

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