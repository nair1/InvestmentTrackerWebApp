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
-- Description:	Signs a user up with all the specified information
-- =============================================
ALTER PROCEDURE SignupUser 
	-- Add the parameters for the stored procedure here
	@first_name varchar(32),
	@last_name varchar(32),
	@email varchar(128),
	@username varchar(32),
	@password varchar(64)
AS
BEGIN

    -- Insert statements for procedure here
	INSERT INTO USER_LOGINS
	VALUES
	(@username, @password, @first_name, @last_name, @email)
END
GO
