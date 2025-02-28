USE [Kama.Aro.Organization]
GO

IF EXISTS(SELECT 1 FROM sys.procedures WHERE [object_id] = OBJECT_ID('atu.spGetIssuedTokenByToken'))
	DROP PROCEDURE atu.spGetIssuedTokenByToken
GO

CREATE PROCEDURE atu.spGetIssuedTokenByToken
	@AToken VARCHAR(4000)
--WITH ENCRYPTION
AS
BEGIN
	SET NOCOUNT ON;
	SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;

	DECLARE @Token VARCHAR(4000) = LTRIM(RTRIM(@AToken))
	
	SELECT 
		ist.*,
		rft.ID RefrshTokenID,
		rft.ExpireDate RefrshTokenExpireDate
	FROM org.IssuedToken ist
	INNER JOIN org.RefreshToken rft ON ist.RefreshTokenID = rft.ID
	WHERE Token = @Token 

END