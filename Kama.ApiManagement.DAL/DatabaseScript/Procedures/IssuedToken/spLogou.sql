USE [Kama.Aro.Organization]
GO

IF EXISTS(SELECT 1 FROM sys.procedures WHERE [object_id] = OBJECT_ID('atu.spLogout'))
	DROP PROCEDURE atu.spLogout
GO

CREATE PROCEDURE atu.spLogout
	@AToken VARCHAR(MAX),
	@AUndoOnlyApp BIT
--WITH ENCRYPTION
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @Token VARCHAR(MAX) = TRIM(@AToken)
		,@UndoOnlyApp BIT =@AUndoOnlyApp
		,@SsoTicket VARCHAR(MAX)
		,@ClientID UNIQUEIDENTIFIER
	
	BEGIN TRY
		BEGIN TRAN
		
		SET @SsoTicket = (
			SELECT TOP 1 refresh.SsoTicket FROM org.IssuedToken issued
			INNER JOIN  org.RefreshToken refresh ON issued.RefreshTokenID  = refresh.ID
			WHERE Token = @Token
		);

		IF @UndoOnlyApp = 1
		BEGIN
			DECLARE @t TABLE (ID UNIQUEIDENTIFIER )

			SET @ClientID = (
				SELECT TOP 1 issued.ClientID FROM org.IssuedToken issued
				INNER JOIN  org.RefreshToken refresh ON issued.RefreshTokenID  = refresh.ID
				WHERE Token = @Token 
			);

			
			INSERT INTO @T
			SELECT DISTINCT refresh.ID 
			FROM org.IssuedToken issued
			INNER JOIN  org.RefreshToken refresh ON issued.RefreshTokenID  = refresh.ID
			WHERE SsoTicket = @SsoTicket
				AND issued.ClientID = @ClientID
			
			DELETE issued 
			FROM @T t
			INNER JOIN org.RefreshToken refresh ON t.ID = refresh.ID
			INNER JOIN org.IssuedToken issued ON issued.RefreshTokenID  = refresh.ID
			
			DELETE refresh 
			FROM @T t
			INNER JOIN org.RefreshToken refresh ON t.ID = refresh.ID
		END

		ELSE
		BEGIN

			DELETE issued
			FROM org.RefreshToken refresh
			INNER JOIN  org.IssuedToken issued ON issued.RefreshTokenID  = refresh.ID
			WHERE refresh.SsoTicket = @SsoTicket 

			DELETE org.RefreshToken
			WHERE SsoTicket = @SsoTicket 

		END

		COMMIT
	END TRY
	BEGIN CATCH
		;THROW
	END CATCH

END

