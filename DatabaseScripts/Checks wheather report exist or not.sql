USE [Giberson]
GO

/****** Object:  StoredProcedure [dbo].[CheckReportExists]    Script Date: 11/23/2013 5:07:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[CheckReportExists]
	@myDate varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT count(*) FROM EMR WHERE timestamp = @myDate;

END


GO

