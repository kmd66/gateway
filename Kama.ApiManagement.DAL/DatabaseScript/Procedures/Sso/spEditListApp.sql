USE [Kama.Aro.Organization]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'org.spEditListApp') AND type in (N'P', N'PC'))
    DROP PROCEDURE org.spEditListApp
GO

CREATE PROCEDURE org.spEditListApp
	@ASmsLogin BIT,
	@AApplicationIDS NVARCHAR(max)
--WITH ENCRYPTION
AS
BEGIN
    SET NOCOUNT ON;
	
	DECLARE 
		@SmsLogin BIT = @ASmsLogin,
		@ApplicationIDS NVARCHAR(max) = @AApplicationIDS
		
	UPDATE org.Sso SET SmsLogin = @SmsLogin
	UPDATE org.Client SET SsoState = 0
	UPDATE APP
		SET SsoState = 1
	FROM org.Client APP
	inner join  OPENJSON(@ApplicationIDS) APPID ON APP.ID = APPID.[VALUE]
		
END 