USE [Kama.Aro.Organization]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'org.spAddSsoCache') AND type in (N'P', N'PC'))
    DROP PROCEDURE org.spAddSsoCache
GO

CREATE PROCEDURE org.spAddSsoCache
	@AID UNIQUEIDENTIFIER ,
	@AMasterPassword UNIQUEIDENTIFIER ,
	@AKey CHAR(32),
	@ASsoTicket CHAR(32),
	@AHash CHAR(128),
	@AUserName VARCHAR(MAX)
--WITH ENCRYPTION
AS
BEGIN
    SET NOCOUNT ON;

	DECLARE 
		@ID UNIQUEIDENTIFIER = @AID,
		@MasterPassword UNIQUEIDENTIFIER = @AMasterPassword,
		@Key CHAR(32) = @AKey, 
		@SsoTicket CHAR(32) = @ASsoTicket, 
		@Hash CHAR(128) = @AHash, 
		@UserName NVARCHAR(MAX) = @AUserName,
		@Date DATETIME = GETDATE(),
		@ExpireDate DATETIME = DATEADD(SECOND,120,GETDATE()); 
	
		INSERT INTO org.SsoCache
			([ID], [Key], [SsoTicket], [UserName], [Hash], [MasterPassword], [Date], [ExpireDate])
		VALUES
			(@ID, @Key, @SsoTicket, @UserName, @Hash, @MasterPassword, @Date, @ExpireDate)
			
END 
