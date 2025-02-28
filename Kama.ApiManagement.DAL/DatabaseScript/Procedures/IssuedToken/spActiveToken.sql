USE [Kama.Aro.Organization]
GO

IF EXISTS(SELECT 1 FROM sys.procedures WHERE [object_id] = OBJECT_ID('atu.spActiveToken'))
	DROP PROCEDURE atu.spActiveToken
GO

CREATE PROCEDURE atu.spActiveToken
	@AUserID UNIQUEIDENTIFIER
--WITH ENCRYPTION
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @UserID UNIQUEIDENTIFIER  = @AUserID
	
	
	;With Token AS
	(
		SELECT
			DISTINCT TOP 100 
			refresh.ID
			, refresh.IssuedDate 
			, refresh.ExpireDate 
			, refresh.SsoTicket 
			--, refresh.OS 
			--, refresh.OSVersion
			--, refresh.Browser 
			--, refresh.BrowserVersion 
			--, refresh.DeviceType 
			, clt.ApplicationID, 
			ROW_NUMBER() OVER(Partition BY refresh.SsoTicket, clt.ApplicationID ORDER BY refresh.IssuedDate desc) RowNumber
		FROM org.RefreshToken refresh
		INNER JOIN org.IssuedToken issued ON issued.RefreshTokenID  = refresh.ID
		INNER JOIN org.Client clt ON issued.ClientID = clt.ID
		WHERE refresh.UserID = @UserID
			AND refresh.ExpireDate > GETDATE()
	)
	SELECT * FROM Token where RowNumber = 1
	ORDER BY IssuedDate
END

