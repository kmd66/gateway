USE [Kama.Aro.Organization]
GO

IF EXISTS(SELECT 1 FROM sys.procedures WHERE [object_id] = OBJECT_ID('atu.spAddIssuedToken'))
	DROP PROCEDURE atu.spAddIssuedToken
GO


CREATE PROCEDURE atu.spAddIssuedToken
	@AID UNIQUEIDENTIFIER,
	@AUserID UNIQUEIDENTIFIER,
	@ARefreshTokenID UNIQUEIDENTIFIER,
	@AClientID UNIQUEIDENTIFIER,
	@AIssuedDate DATETIME,
	@AExpireDate DATETIME,
	@AToken VARCHAR(4000)
--WITH ENCRYPTION
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE 
		@ID UNIQUEIDENTIFIER = @AID,
		@RefreshTokenID UNIQUEIDENTIFIER = @ARefreshTokenID,
		@UserID UNIQUEIDENTIFIER = @AUserID,
		@ClientID UNIQUEIDENTIFIER = @AClientID,
		@IssuedDate DATETIME = @AIssuedDate,
		@ExpireDate DATETIME = @AExpireDate,
		@Token VARCHAR(4000) = LTRIM(RTRIM(@AToken ))

	BEGIN TRY
		BEGIN TRAN
			
			INSERT INTO org.IssuedToken
				(ID, UserID, IssuedDate, [ExpireDate], Token, ClientID, RefreshTokenID)
			VALUES
				(@ID, @UserID, @IssuedDate, @ExpireDate, @Token, @ClientID, @RefreshTokenID)

		COMMIT
	END TRY
	BEGIN CATCH
		;THROW
	END CATCH
	
END