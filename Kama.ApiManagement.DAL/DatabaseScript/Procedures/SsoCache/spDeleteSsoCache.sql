USE [Kama.Aro.Organization]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'org.spDeleteSsoCache') AND type in (N'P', N'PC'))
    DROP PROCEDURE org.spDeleteSsoCache
GO

CREATE PROCEDURE org.spDeleteSsoCache
	@AKey CHAR(32)
AS
BEGIN
    SET NOCOUNT ON;

	DECLARE  @Key CHAR(32) = @AKey 
	
	DELETE org.SsoCache WHERE [Key] = @Key
			
END 
