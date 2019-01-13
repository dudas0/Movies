ALTER PROC AddingUser
@FirstName varchar(50),
@LastName varchar(50),
@Email varchar(50),
@UserName varchar(50),
@Password varchar(50)
AS
	INSERT INTO tableUser(FirstName,LastName,Email,UserName,Password)
	VALUES (@FirstName,@LastName,@Email,@UserName,@Password)