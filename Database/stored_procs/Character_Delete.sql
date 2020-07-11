CREATE PROCEDURE [dbo].[Character_Delete]
	@id int
AS
/*

DECLARE @_id INT = 7;
EXEC [Character_Delete]
	@_id
SELECT * FROM [dbo].[Character]

*/
BEGIN
	DELETE FROM [dbo].[Character]
	WHERE Id = @id
END