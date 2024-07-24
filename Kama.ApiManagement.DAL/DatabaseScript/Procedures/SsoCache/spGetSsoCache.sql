USE [Kama.Aro.Organization]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'org.spGetSsoCache') AND type in (N'P', N'PC'))
    DROP PROCEDURE org.spGetSsoCache
GO

CREATE PROCEDURE org.spGetSsoCache
	@AKey CHAR(32)
AS
BEGIN
    SET NOCOUNT ON;

	DECLARE  @Key CHAR(32) = @AKey 
	
	SELECT * FROM org.SsoCache 
		WHERE [Key] = @Key 
		AND [ExpireDate] > GETDATE();
			
END 
