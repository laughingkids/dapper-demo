CREATE PROCEDURE [dbo].[spUser_Insert]
  @Id UNIQUEIDENTIFIER,
  @FirstName VARCHAR(50),
  @LastName VARCHAR(50)
AS
BEGIN
  insert into dbo.[User] (Id, FirstName, LastName)
  values (@Id, @FirstName, @LastName)
END
