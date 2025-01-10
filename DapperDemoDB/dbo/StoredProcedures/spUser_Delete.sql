CREATE PROCEDURE [dbo].[spUser_Delete]
  @Id UNIQUEIDENTIFIER
AS
BEGIN
  delete
  from dbo.[User]
  where Id = @Id;
END
