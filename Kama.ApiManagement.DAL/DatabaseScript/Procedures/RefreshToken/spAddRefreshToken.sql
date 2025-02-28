USE [Kama.Aro.Organization]
GO

IF EXISTS(SELECT 1 FROM sys.procedures WHERE [object_id] = OBJECT_ID('atu.spAddRefreshToken'))
	DROP PROCEDURE atu.spAddRefreshToken
GO


create PROCEDURE atu.spAddRefreshToken
	@AID UNIQUEIDENTIFIER,
	@AUserID UNIQUEIDENTIFIER,
	@AIssuedDate DATETIME,
	@AExpireDate DATETIME,
	@AProtectedTicket NVARCHAR(MAX),
	@ASsoTicket CHAR(32),
	@AOS smallint,
	@AOSVersion nvarchar(200),
	@ABrowser smallint ,
	@ABrowserVersion nvarchar(200),
	@ADeviceType smallint
--WITH ENCRYPTION
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE 
		@ID UNIQUEIDENTIFIER = @AID,
		@UserID UNIQUEIDENTIFIER = @AUserID,
		@IssuedDate DATETIME = @AIssuedDate,
		@ExpireDate DATETIME = @AExpireDate,
		@ProtectedTicket NVARCHAR(MAX) = LTRIM(RTRIM(@AProtectedTicket )),
		@SsoTicket CHAR(32) = LTRIM(RTRIM(@ASsoTicket )),

		@OS smallint = @AOS,
		@OSVersion nvarchar(200) = LTRIM(RTRIM(@AOSVersion )),
		@Browser smallint = @ABrowser,
		@BrowserVersion nvarchar(200) = LTRIM(RTRIM(@ABrowserVersion )),
		@DeviceType smallint = @ADeviceType
	DELETE org.RefreshToken 
	WHERE UserID = @UserID
		AND ExpireDate < DATEADD(day, -1, GETDATE())

	BEGIN TRY
		BEGIN TRAN
			INSERT INTO org.RefreshToken
				(ID, UserID, IssuedDate, [ExpireDate], ProtectedTicket, SsoTicket , OS ,OSVersion,Browser,BrowserVersion,DeviceType )
			VALUES
				(@ID, @UserID, @IssuedDate, @ExpireDate, @ProtectedTicket, @SsoTicket, @OS ,@OSVersion,@Browser,@BrowserVersion,@DeviceType)

		COMMIT
	END TRY
	BEGIN CATCH
		;THROW
	END CATCH
	
END