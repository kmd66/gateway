USE [Kama.Aro.Organization]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'org.spGetSsoApplication') AND type in (N'P', N'PC'))
    DROP PROCEDURE org.spGetSsoApplication
GO

CREATE PROCEDURE org.spGetSsoApplication
	@AUserID UNIQUEIDENTIFIER,
	@APageSize INT,
	@APageIndex INT 
--WITH ENCRYPTION
AS
BEGIN
    SET NOCOUNT ON;
	DECLARE 
		@UserID UNIQUEIDENTIFIER = @AUserID,
		@PageSize INT = COALESCE(@APageSize,20),
		@PageIndex INT = COALESCE(@APageIndex, 0)
	
	
	;WITH Applications AS (	
		SELECT DISTINCT
		CASE WHEN IsNull(clt.[Name], '') <> '' THEN clt.[Name] ELSE app.[Name] END AppName,
			app.ID,
			app.Abbreviation AppAbbreviation,
			clt.ID cltID
		FROM org.Position position
			INNER JOIN org.[Application] app ON app.ID = position.ApplicationID
			INNER JOIN org.Client clt ON clt.ApplicationID = app.ID
	 	WHERE app.[Enabled] = 1 
			AND position.RemoveDate IS NULL
			AND (clt.SsoState = 1)
			AND (@UserID IS NOT NULL AND position.UserID = @UserID)
	)
	,MainSelect AS
	(	
		SELECT  *
		FROM Applications 
			INNER JOIN org.[Sso] sso ON sso.ApplicationID = Applications.ID
				AND (sso.ClientID IS NULL OR sso.ClientID = cltID )
	)
	, Total AS
	(
		SELECT COUNT(*) AS Total FROM MainSelect
	)
	SELECT * FROM Total, MainSelect
	OPTION (RECOMPILE);
END 
