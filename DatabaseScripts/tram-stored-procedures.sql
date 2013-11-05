USE [Giberson]
GO
/****** Object:  StoredProcedure [dbo].[CheckInsuranceExists]    Script Date: 11/5/2013 1:03:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CheckInsuranceExists]
	 @insuranceNumber varchar(10)
AS
BEGIN
	
	SET NOCOUNT ON;

   
	SELECT count(*) FROM PatientOHIPInsurance WHERE insuranceNumber = @insuranceNumber;
END


GO
/****** Object:  StoredProcedure [dbo].[GetAllergyID1]    Script Date: 11/5/2013 1:03:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllergyID1]
	 @allergyName varchar(10)
AS
BEGIN
	
	SET NOCOUNT ON;

   
	SELECT allergyID FROM Allergy WHERE name = @allergyName;
END


GO
/****** Object:  StoredProcedure [dbo].[GetAllergyID2]    Script Date: 11/5/2013 1:03:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllergyID2]
	
	
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	SELECT TOP 1 allergyID  FROM dbo.Allergy
ORDER BY allergyID DESC
	RETURN 
	
END

GO
