USE [Kama.Aro.Organization]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'org.spGetSsoUser') AND type in (N'P', N'PC'))
    DROP PROCEDURE org.spGetSsoUser
GO

CREATE PROCEDURE org.spGetSsoUser
	@AUserID NVARCHAR(max),
	@AUserHash NVARCHAR(max),
	@ACallBackUrl NVARCHAR(max)
--WITH ENCRYPTION
AS
BEGIN
    SET NOCOUNT ON;
	
	DECLARE 
		@UserID NVARCHAR(max) =@AUserID ,
		@UserHash NVARCHAR(max) = @AUserHash,
		@CallBackUrl NVARCHAR(max) =@ACallBackUrl

	SELECT Top 1
		[UserID] , 
		[UserHash] ,
		[CallBack] ,
		[GetType]
	FROM [org].[Sso]
	WHERE 
		(@UserID IS NULL OR UserID = @UserID)
		AND (@UserHash IS NULL OR UserHash = @UserHash)
		AND (@CallBackUrl IS NULL OR CallBack = @CallBackUrl)
		
END 