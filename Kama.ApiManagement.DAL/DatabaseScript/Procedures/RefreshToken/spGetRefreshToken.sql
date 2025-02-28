USE [Kama.Aro.Organization]
GO

IF EXISTS(SELECT 1 FROM sys.procedures WHERE [object_id] = OBJECT_ID('atu.spGetRefreshToken'))
	DROP PROCEDURE atu.spGetRefreshToken
GO

CREATE PROCEDURE atu.spGetRefreshToken
	@AID UNIQUEIDENTIFIER
--WITH ENCRYPTION
AS
BEGIN
	SET NOCOUNT ON;
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;

	DECLARE 
		@ID UNIQUEIDENTIFIER = @AID
	
	SELECT 
		ID,
		UserID,
		IssuedDate,
		[ExpireDate],
		ProtectedTicket,
		SsoTicket
	FROM org.RefreshToken
	WHERE ID = @ID 

END