USE [Kama.Aro.Organization]
GO

IF EXISTS(SELECT 1 FROM sys.procedures WHERE [object_id] = OBJECT_ID('atu.spUpdateRefreshTokensExpireDate'))
	DROP PROCEDURE atu.spUpdateRefreshTokensExpireDate
GO

CREATE PROCEDURE atu.spUpdateRefreshTokensExpireDate
	@AID UNIQUEIDENTIFIER,
	@AExpireDate DATETIME,
	@ASsoTicket CHAR(32)

--WITH ENCRYPTION
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE 
		@ID UNIQUEIDENTIFIER = @AID,
		@ExpireDate DATETIME = @AExpireDate,
		@SsoTicket CHAR(32) = TRIM(@ASsoTicket)

	IF @SsoTicket IS NOT NULL
	BEGIN
		UPDATE org.[RefreshToken]
		SET [ExpireDate] = @ExpireDate
		WHERE [SsoTicket] = @SsoTicket
	END
	ELSE
	BEGIN
		UPDATE org.[RefreshToken]
		SET [ExpireDate] = @ExpireDate
		WHERE ID = @ID
	END

END