USE [Giberson]
GO

/****** Object:  StoredProcedure [dbo].[GetDailyPatientsReport]    Script Date: 11/19/2013 10:19:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetDailyPatientsReport]
@todays varchar(13)
AS
BEGIN
	SET NOCOUNT ON;
	select	 @todays,
			 pat.patientID as PatientID,
			 pat.giveMiddleName as PatientFirstName, 
			 pat.lastName as PatientLastName,
			 pat.dateOfBirth as DOB, 
			 pat.gender as Gender	 
					
 from
	Patient as pat,
	EMR as emr 
	
	where 
    emr.timestamp=@todays
    and pat.patientID=emr.patientID
    order by emr.timestamp desc;
END



GO

