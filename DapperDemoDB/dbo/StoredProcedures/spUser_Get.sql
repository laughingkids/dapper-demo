CREATE PROCEDURE [dbo].[spUser_Get]
  @Id UNIQUEIDENTIFIER
AS
BEGIN
  select Id, FirstName, LastName
  from dbo.[User]
  where Id = @Id;
END
