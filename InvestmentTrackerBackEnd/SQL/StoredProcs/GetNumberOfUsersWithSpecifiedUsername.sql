-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sachin Nair
-- Create date: 8/14/22
-- Description:	Gets number of users that have the same username as the username provided during signup.
-- =============================================
CREATE PROCEDURE GetNumberOfUsersWithSpecifiedUsername 
	-- Add the parameters for the stored procedure here
	@username varchar(max)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT COUNT(USR_NM)
	FROM USER_LOGINS
	WHERE USR_NM=@username
END
GO
