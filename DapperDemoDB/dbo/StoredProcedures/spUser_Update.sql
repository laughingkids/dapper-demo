CREATE PROCEDURE [dbo].[spUser_Update]
  @Id UNIQUEIDENTIFIER,
  @FirstName VARCHAR(50),
  @LastName VARCHAR(50)
AS
BEGIN
  update dbo.[User]
  set FirstName = @FirstName, LastName = @LastName
  where Id = @Id
END
