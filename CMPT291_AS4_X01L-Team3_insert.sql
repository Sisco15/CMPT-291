USE Assignment4;

DELETE Movie;

INSERT INTO Movie (MovieID, MovieName, MovieType, Fee, NumOfCopy)
	VALUES( NEXT VALUE FOR Movie_MovieID_Seq, 'The Fantastic Four: First Steps', 'Action', 5.0, 10);

INSERT INTO Movie (MovieID, MovieName, MovieType, Fee, NumOfCopy)
	VALUES( NEXT VALUE FOR Movie_MovieID_Seq, 'Top Gun: Maverick', 'Action', 7.0, 3);
