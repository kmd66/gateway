USE [Kama.Aro.Organization]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'org.spCheckSmsLogin') AND type in (N'P', N'PC'))
    DROP PROCEDURE org.spCheckSmsLogin
GO

CREATE PROCEDURE org.spCheckSmsLogin
	@AApplicationID UNIQUEIDENTIFIER,
	@AClient UNIQUEIDENTIFIER ,
	@AUserID NVARCHAR(max)
--WITH ENCRYPTION
AS
BEGIN
    SET NOCOUNT ON;
	
	DECLARE 
		@ApplicationID UNIQUEIDENTIFIER = @AApplicationID,
		@Client UNIQUEIDENTIFIER = @AClient,
		@UserID NVARCHAR(max) = @AUserID

	SELECT Top 1
		SmsLogin
	FROM [org].[Sso]
	WHERE SmsLogin = 1
		AND (@ApplicationID IS NULL OR ApplicationID = @ApplicationID)
		AND (@Client IS NULL OR ApplicationID = @Client)
		AND (@UserID IS NULL OR UserID = @UserID)
		
END 