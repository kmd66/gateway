USE [Kama.Aro.Organization]
GO

--exec org.spAddNewCallBackUrl @ACallBackUrl='http://localhost:19726/#!/loginsso', @AApplicationID='8900F736-50C8-43E8-84BC-2B7C3945CFF1', @AGetType=0, @AClient=null

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'org.spAddNewCallBackUrl') AND type in (N'P', N'PC'))
    DROP PROCEDURE org.spAddNewCallBackUrl
GO

CREATE PROCEDURE org.spAddNewCallBackUrl
	@ACallBackUrl NVARCHAR(max),
	@AApplicationID UNIQUEIDENTIFIER ,
	@AClient UNIQUEIDENTIFIER ,
	@AGetType BIT 
--WITH ENCRYPTION
AS
BEGIN
    SET NOCOUNT ON;

	DECLARE 
		@CallBackUrl NVARCHAR(max) = @ACallBackUrl,
		@ApplicationID UNIQUEIDENTIFIER,
		@Client UNIQUEIDENTIFIER = @AClient,
		@GetType BIT = @AGetType,
		@HashThis NVARCHAR(max),
		@HashThis2 NVARCHAR(max); 
	
	SET @ApplicationID = (SELECT TOP 1 ID FROM org.[Application] WHERE ID = @AApplicationID)
	IF @ApplicationID IS NULL
	BEGIN
		RETURN '@ApplicationID NOT EXIST'
	END
	
	SET @HashThis = NEWID();  
	SET @HashThis2 = NEWID();  
	
	INSERT INTO [org].[Sso]
		(UserID, UserHash, CallBack, ApplicationID, SmsLogin, GetType, ClientID)
	SELECT 
		SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('MD5', @HashThis)), 3, 32),
		SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA2_512', @HashThis2)), 3, 128),
		@CallBackUrl,        -- call back url 
		@ApplicationID,
		0,
		@GetType,
		@Client
END 
