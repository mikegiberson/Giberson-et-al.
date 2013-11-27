USE [master]
GO
/****** Object:  Database [Giberson]    Script Date: 11/21/2013 11:53:29 AM ******/
CREATE DATABASE [Giberson]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Giberson', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL11.SQLSERVER\MSSQL\DATA\Giberson.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Giberson_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL11.SQLSERVER\MSSQL\DATA\Giberson_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Giberson] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Giberson].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Giberson] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Giberson] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Giberson] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Giberson] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Giberson] SET ARITHABORT OFF 
GO
ALTER DATABASE [Giberson] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Giberson] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Giberson] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Giberson] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Giberson] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Giberson] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Giberson] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Giberson] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Giberson] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Giberson] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Giberson] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Giberson] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Giberson] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Giberson] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Giberson] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Giberson] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Giberson] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Giberson] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Giberson] SET RECOVERY FULL 
GO
ALTER DATABASE [Giberson] SET  MULTI_USER 
GO
ALTER DATABASE [Giberson] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Giberson] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Giberson] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Giberson] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Giberson', N'ON'
GO
USE [Giberson]
GO
/****** Object:  StoredProcedure [dbo].[CheckInsuranceExists]    Script Date: 11/21/2013 11:53:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[CheckPatientExists]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CheckPatientExists]
	@patientId int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT count(*) FROM Patient WHERE patientId = @patientId;

END



GO
/****** Object:  StoredProcedure [dbo].[GetAllAllergies]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllAllergies]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * from Allergy
END




GO
/****** Object:  StoredProcedure [dbo].[GetAllergyID1]    Script Date: 11/21/2013 11:53:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[GetAllergyID2]    Script Date: 11/21/2013 11:53:32 AM ******/
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
/****** Object:  StoredProcedure [dbo].[GetAllery]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllery]
@patientId int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT A.* FROM PatientAllergy as PA, Allergy as A WHERE PA.allergyID = a.allergyID and PA.patientID = @patientId;

END




GO
/****** Object:  StoredProcedure [dbo].[GetDoctor]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetDoctor]
	-- Add the parameters for the stored procedure here
	@doctorID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT doctorID, lastName, givenMiddleName, dateOfBirth, gender, billingCode 
		FROM Doctor 
		LEFT JOIN Person 
		ON Doctor.doctorID = Person.personID 
		WHERE doctorID = @doctorID;
END





GO
/****** Object:  StoredProcedure [dbo].[GetDoctorID1]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetDoctorID1]
	 @billingCode varchar(10)
AS
BEGIN
	
	SET NOCOUNT ON;

   
	SELECT doctorID FROM Doctor WHERE billingCode = @billingCode;
END






GO
/****** Object:  StoredProcedure [dbo].[GetDoctorID2]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetDoctorID2]
	
	
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	SELECT TOP 1 doctorID  FROM dbo.Doctor
ORDER BY doctorID DESC
	RETURN 
	
END





GO
/****** Object:  StoredProcedure [dbo].[GetPatient]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPatient]
@patientId int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Patient where patientID = @patientId;
END




GO
/****** Object:  StoredProcedure [dbo].[GetPatientAddress]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPatientAddress]
@patientId int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM PatientAddress where patientID = @patientId;
END




GO
/****** Object:  StoredProcedure [dbo].[GetPatientDiagnosis]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPatientDiagnosis]
	@patientId int,
	@sortBy int
AS
BEGIN
	SET NOCOUNT ON;
	if @sortBy = 1 
		SELECT * from EMRDiagnosis emr, Diagnosis d where d.diagnosisID = emr.diagnosisID and emr.patientID = @patientId order by d.name;
	
	if @sortBy = 2
		SELECT * from EMRDiagnosis emr, Diagnosis d where d.diagnosisID = emr.diagnosisID and emr.patientID = @patientId order by d.diagnosisID;

	if @sortBy = 3
		SELECT * from EMRDiagnosis emr, Diagnosis d where d.diagnosisID = emr.diagnosisID and emr.patientID = @patientId order by emr.timestamp;
END


GO
/****** Object:  StoredProcedure [dbo].[GetPatientDoctor]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPatientDoctor]
@patientId int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT D.* FROM ReferialDoctor as RD, Doctor as D where RD.doctorID = D.doctorID and Rd.patientID = @patientId;
END




GO
/****** Object:  StoredProcedure [dbo].[GetPatientEmail]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPatientEmail]
@patientId int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM PatientEmail where patientID = @patientId;
END




GO
/****** Object:  StoredProcedure [dbo].[GetPatientEMRAccordingToDate]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPatientEMRAccordingToDate]
@patientId int,
@emrDate varchar(100)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM EMR as emr where patientID = @patientId and emr.timestamp=(Select CONVERT(Date, @emrDate, 120));
END




GO
/****** Object:  StoredProcedure [dbo].[GetPatientEMRDates]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetPatientEMRDates]
	@patientId int	
AS
BEGIN
	
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	SELECT timestamp  FROM dbo.EMR where patientID=@patientId
ORDER BY timestamp DESC
	RETURN 
	
END



GO
/****** Object:  StoredProcedure [dbo].[GetPatientID]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetPatientID]
	
	
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	SELECT TOP 1 patientId  FROM dbo.Patient
ORDER BY patientId DESC
	RETURN 
	
END



GO
/****** Object:  StoredProcedure [dbo].[GetPatientLaboratory]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPatientLaboratory] 
	@patientId int,
		@sortBy int
AS
BEGIN
	SET NOCOUNT ON;
	if @sortBy = 1 
	SELECT * from EMRLaboratory emr, Laboratory l where l.laboratoryID = emr.laboratoryID and emr.patientID = @patientId order by l.name;

	if @sortBy = 2
	SELECT * from EMRLaboratory emr, Laboratory l where l.laboratoryID = emr.laboratoryID and emr.patientID = @patientId order by l.laboratoryID;
	
	if @sortBy = 3 
	SELECT * from EMRLaboratory emr, Laboratory l where l.laboratoryID = emr.laboratoryID and emr.patientID = @patientId order by emr.timestamp;
END



GO
/****** Object:  StoredProcedure [dbo].[GetPatientLatestEmrReport]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetPatientLatestEmrReport]
@patientId int
AS
BEGIN
	SET NOCOUNT ON;
	select Top 1 pat.patientID as PatientID,
			 pat.giveMiddleName as PatientFirstName, 
			 pat.lastName as PatientLastName,
			 pat.dateOfBirth as DOB, 
			 pat.gender as Gender,
			 emr.timestamp as EMRDate,
			 emr.doctorID as DoctorId,
			 doc.doctorName as DoctorName, 
			 emr.chiefComplaint as ChiefComplaint,	
			 emr.height as Height_cms, 
			 emr.weight as Weight_pounds, 
			 emr.bloodPressure as BloodPressure_mmhg, 
			 emr.pulseRate as PulseRate_per_minute,
			 emr.respiratoryRate as RespiratoryRate_per_minute, 
			 emr.temperature as Temperature_degree_C, 
			 emr.painScale as PainScale_0_to_10_Level, 
			 rad.name as RadiologyName,
			 rad.description as RadiologyDescription, 
			 lab.name as Laboratory_Name, 
			 lab.description as LaboratoryDescription, 
			 diag.name as DiagnosisName, 
			 diag.description as DiagnosisDescription,
			 emr.clinicalImpression as ClinicalImpression, 
			 med.name as MedicationName,
			 med.description as MedicationDescription 
 from
	Patient as pat,
	EMR as emr , 
	EMRDiagnosis as emrDiag ,
	Diagnosis as diag ,
	EMRRadiology as emrRad ,
	Radiology as rad,
	EMRMedication as emrMed,
	Medication as med,
	EMRLaboratory as emrLab,
	Laboratory as lab,
	Doctor as doc
	
	where pat.patientID= @patientId
	and emrDiag.patientID = emr.patientID
	and diag.diagnosisID = emrDiag.diagnosisID
	and emrRad.patientID = emr.patientID
	and rad.radiologyID = emrRad.radiologyID
	and doc.doctorID=emr.doctorID

	order by emr.timestamp desc






END




GO
/****** Object:  StoredProcedure [dbo].[GetPatientMedication]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPatientMedication] 
	@patientId int,
	@sortBy int
AS
BEGIN

	SET NOCOUNT ON;
	if @sortBy=1
	SELECT * from EMRMedication emr, Medication m where m.medicationID = emr.medicationID and emr.patientID = @patientId order by m.name;

	if @sortBy=2
	SELECT * from EMRMedication emr, Medication m where m.medicationID = emr.medicationID and emr.patientID = @patientId order by m.medicationID;

	if @sortBy=3
    SELECT * from EMRMedication emr, Medication m where m.medicationID = emr.medicationID and emr.patientID = @patientId order by emr.timestamp;

END


GO
/****** Object:  StoredProcedure [dbo].[GetPatientOHIPInsurance]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPatientOHIPInsurance]
@patientId int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM PatientOHIPInsurance where patientID = @patientId;
END




GO
/****** Object:  StoredProcedure [dbo].[GetPatientPhone]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPatientPhone]
@patientId int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM PatientPhone where patientID = @patientId;
END




GO
/****** Object:  StoredProcedure [dbo].[GetPatientRadiology]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPatientRadiology] 
	@patientId int,
	@sortBy int
AS
BEGIN
	SET NOCOUNT ON;
	if @sortBy=1
	SELECT * from EMRRadiology emr, Radiology r where r.radiologyID = emr.radiologyID and emr.patientID = @patientId order by r.name;

	if @sortBy= 2
	SELECT * from EMRRadiology emr, Radiology r where r.radiologyID = emr.radiologyID and emr.patientID = @patientId order by r.radiologyID;

	if @sortBy=3
	SELECT * from EMRRadiology emr, Radiology r where r.radiologyID = emr.radiologyID and emr.patientID = @patientId order by emr.timestamp;

END


GO
/****** Object:  StoredProcedure [dbo].[SavePatientAllergy]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SavePatientAllergy]
	@name varchar(250),
	@category varchar(250),
	@patientId int,
	@allergyId int
AS
BEGIN
	SELECT @allergyId = count(allergyId) from Allergy where name like @name and category like @category
	print @allergyId
	if @allergyId = 0
		begin
			select @allergyId = (max(allergyID) + 1) from Allergy
			insert into Allergy(allergyID, name, category) values(@allergyId, @name, @category)
			SELECT top 1 @allergyId = allergyId from Allergy order by allergyID desc
			delete from PatientAllergy where patientID = @patientId
			insert into PatientAllergy values(@patientId, @allergyId)
		end
	else
		SELECT @allergyId = allergyId from Allergy where name like @name and category like @category
		update PatientAllergy set allergyID = @allergyId where patientId = @patientId
END




GO
/****** Object:  StoredProcedure [dbo].[SavePatientDoctor]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SavePatientDoctor]
	@patientId int,
	@doctorId int
AS
DECLARE
	@count int
BEGIN
	SET NOCOUNT ON;
	select @count = COUNT(*) from Doctor where doctorID = @doctorId 
	if @count > 0
		update ReferialDoctor set doctorID = @doctorId where patientID = @patientId
END




GO
/****** Object:  StoredProcedure [dbo].[UpdateInsurance]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[UpdateInsurance]
	@versionCode int,
	@patientId int,
	@insNumber nchar(10),
	@expDate nchar(10)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE PatientOHIPInsurance SET insuranceNumber = @insNumber
					  ,versionCode=@versionCode
					  ,expiryDate = @expDate
 WHERE  patientId = @patientId
END




GO
/****** Object:  StoredProcedure [dbo].[UpdatePatient]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[UpdatePatient]
	@patientId int,
	@firstName nchar(10),
	@lastName nchar(10),
	@dob nchar(10),
	@gender nchar(10)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE Patient SET giveMiddleName = @firstName
					  ,lastName = @lastName
					  ,dateOfBirth = @dob
					  ,gender = @gender
 WHERE patientId = @patientId
END




GO
/****** Object:  StoredProcedure [dbo].[UpdatePatientAddress]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdatePatientAddress]
@patientId int,
@addressType varchar(50),
@address varchar(200),
@city varchar(100),
@province varchar(50),
@postalCode varchar(20),
@country varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE PatientAddress SET  type = @addressType
					  ,deliveryAddress = @address,
					  subdivision =@city,
					  division = @province,
					  postalCode=@postalCode
					--  country=@country
	 WHERE patientID = @patientID
END




GO
/****** Object:  StoredProcedure [dbo].[UpdatePatientAllergy]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[UpdatePatientAllergy] 
	@allergyId int,
	@patientId int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE PatientAllergy SET allergyId = @allergyId WHERE patientID = @patientId
END




GO
/****** Object:  StoredProcedure [dbo].[UpdatePatientEmail]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdatePatientEmail]
@patientId int,
@emailType varchar(50),
@email  varchar (50)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE PatientEmail SET  type = @emailType
					  ,emailAddress = @email
					  
	 WHERE patientID = @patientID
END




GO
/****** Object:  StoredProcedure [dbo].[UpdatePatientPhone]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdatePatientPhone]
@patientId int,
@phoneType varchar(50),
@phoneNo varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE PatientPhone SET  type = @phoneType
					  ,phoneNumber = @phoneNo
					  
	 WHERE patientID = @patientID
END




GO
/****** Object:  Table [dbo].[Allergy]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Allergy](
	[allergyID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](250) NOT NULL,
	[category] [varchar](50) NULL,
 CONSTRAINT [PK_Allergy] PRIMARY KEY CLUSTERED 
(
	[allergyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Appointment](
	[appointmentID] [int] IDENTITY(1,1) NOT NULL,
	[scheduleID] [int] NOT NULL,
	[doctorID] [int] NOT NULL,
	[patientID] [int] NOT NULL,
	[calender] [varchar](50) NULL,
	[timeZone] [varchar](10) NOT NULL,
	[dateTimeStart] [datetime] NOT NULL,
	[dateTimeEnd] [datetime] NULL,
	[duration] [time](7) NOT NULL,
	[completed] [datetime] NULL,
	[status] [varchar](50) NULL,
 CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED 
(
	[appointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Diagnosis]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Diagnosis](
	[diagnosisID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](250) NOT NULL,
	[description] [text] NULL,
 CONSTRAINT [PK_Diagnosis] PRIMARY KEY CLUSTERED 
(
	[diagnosisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Doctor](
	[doctorID] [int] NOT NULL,
	[billingCode] [varchar](50) NULL,
	[doctorName] [varchar](50) NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[doctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[employeeID] [int] NOT NULL,
	[hireDate] [date] NOT NULL,
	[userName] [varchar](50) NOT NULL,
	[password] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[employeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EMR]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EMR](
	[patientID] [int] NOT NULL,
	[doctorID] [int] NOT NULL,
	[timestamp] [date] NOT NULL,
	[clinicalImpression] [text] NULL,
	[bloodPressure] [varchar](20) NULL,
	[respiratoryRate] [varchar](20) NULL,
	[pulseRate] [varchar](20) NULL,
	[temperature] [varchar](20) NULL,
	[height] [varchar](20) NULL,
	[weight] [varchar](20) NULL,
	[painScale] [varchar](20) NULL,
	[chiefComplaint] [varchar](20) NULL,
 CONSTRAINT [PK_EMR] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC,
	[doctorID] ASC,
	[timestamp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EMRDiagnosis]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMRDiagnosis](
	[patientID] [int] NOT NULL,
	[doctorID] [int] NOT NULL,
	[timestamp] [date] NOT NULL,
	[diagnosisID] [int] NOT NULL,
 CONSTRAINT [PK_EMRDiagnosis] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC,
	[doctorID] ASC,
	[timestamp] ASC,
	[diagnosisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EMRLaboratory]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMRLaboratory](
	[patientID] [int] NOT NULL,
	[doctorID] [int] NOT NULL,
	[timestamp] [date] NOT NULL,
	[laboratoryID] [int] NOT NULL,
 CONSTRAINT [PK_EMRLaboratory] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC,
	[doctorID] ASC,
	[timestamp] ASC,
	[laboratoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EMRMedication]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMRMedication](
	[patientID] [int] NOT NULL,
	[doctorID] [int] NOT NULL,
	[timestamp] [date] NOT NULL,
	[medicationID] [int] NOT NULL,
 CONSTRAINT [PK_EMRMedication] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC,
	[doctorID] ASC,
	[timestamp] ASC,
	[medicationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EMRRadiology]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMRRadiology](
	[patientID] [int] NOT NULL,
	[doctorID] [int] NOT NULL,
	[timestamp] [date] NOT NULL,
	[radiologyID] [int] NOT NULL,
 CONSTRAINT [PK_EMRRadiology] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC,
	[doctorID] ASC,
	[timestamp] ASC,
	[radiologyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Laboratory]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Laboratory](
	[laboratoryID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](250) NOT NULL,
	[description] [text] NULL,
 CONSTRAINT [PK_Laboratory] PRIMARY KEY CLUSTERED 
(
	[laboratoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[managerID] [int] NOT NULL,
 CONSTRAINT [PK_Manager] PRIMARY KEY CLUSTERED 
(
	[managerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Medication]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Medication](
	[medicationID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](250) NOT NULL,
	[description] [text] NULL,
 CONSTRAINT [PK_Medication] PRIMARY KEY CLUSTERED 
(
	[medicationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Patient](
	[patientID] [int] IDENTITY(1,1) NOT NULL,
	[registratonDate] [date] NOT NULL,
	[lastName] [varchar](50) NULL,
	[giveMiddleName] [varchar](150) NULL,
	[dateOfBirth] [date] NULL,
	[gender] [varchar](50) NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PatientAddress]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PatientAddress](
	[patientID] [int] NOT NULL,
	[timestamp] [timestamp] NOT NULL,
	[type] [varchar](50) NULL,
	[deliveryAddress] [varchar](200) NOT NULL,
	[subdivision] [varchar](100) NOT NULL,
	[division] [varchar](50) NOT NULL,
	[postalCode] [varchar](20) NOT NULL,
	[country] [varchar](50) NULL,
 CONSTRAINT [PK_PatientAddress] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC,
	[timestamp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PatientAllergy]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientAllergy](
	[patientID] [int] NOT NULL,
	[allergyID] [int] NOT NULL,
 CONSTRAINT [PK_PatientAllergy] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC,
	[allergyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PatientEmail]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PatientEmail](
	[timestamp] [timestamp] NOT NULL,
	[patientID] [int] NOT NULL,
	[type] [varchar](50) NULL,
	[emailAddress] [varchar](255) NOT NULL,
 CONSTRAINT [PK_PatientEmail] PRIMARY KEY CLUSTERED 
(
	[timestamp] ASC,
	[patientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PatientOHIPInsurance]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PatientOHIPInsurance](
	[timestamp] [timestamp] NOT NULL,
	[patientID] [int] NOT NULL,
	[insuranceNumber] [varchar](50) NOT NULL,
	[versionCode] [varchar](2) NOT NULL,
	[expiryDate] [date] NOT NULL,
 CONSTRAINT [PK_PatientInsurance] PRIMARY KEY CLUSTERED 
(
	[timestamp] ASC,
	[patientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PatientPhone]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PatientPhone](
	[timestamp] [timestamp] NOT NULL,
	[patientID] [int] NOT NULL,
	[type] [varchar](50) NULL,
	[phoneNumber] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PatientPhone] PRIMARY KEY CLUSTERED 
(
	[timestamp] ASC,
	[patientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Person]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Person](
	[personID] [int] IDENTITY(1,1) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
	[givenMiddleName] [varchar](150) NOT NULL,
	[dateOfBirth] [date] NOT NULL,
	[gender] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PersonAddress]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonAddress](
	[personID] [int] NOT NULL,
	[timestamp] [timestamp] NOT NULL,
	[type] [varchar](50) NULL,
	[deliveryAddress] [varchar](200) NOT NULL,
	[subdivision] [varchar](100) NOT NULL,
	[division] [varchar](50) NOT NULL,
	[postalCode] [varchar](20) NOT NULL,
	[country] [varbinary](50) NULL,
 CONSTRAINT [PK_PersonAddress] PRIMARY KEY CLUSTERED 
(
	[personID] ASC,
	[timestamp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PersonEmail]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonEmail](
	[timestamp] [timestamp] NOT NULL,
	[personID] [int] NOT NULL,
	[type] [varchar](50) NULL,
	[emailAddress] [varchar](255) NOT NULL,
 CONSTRAINT [PK_PersonEmail] PRIMARY KEY CLUSTERED 
(
	[timestamp] ASC,
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PersonPhone]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonPhone](
	[timestamp] [timestamp] NOT NULL,
	[personID] [int] NOT NULL,
	[type] [varchar](50) NULL,
	[phoneNumber] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PersonPhone] PRIMARY KEY CLUSTERED 
(
	[timestamp] ASC,
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Radiology]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Radiology](
	[radiologyID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](250) NOT NULL,
	[description] [text] NULL,
 CONSTRAINT [PK_Radiology] PRIMARY KEY CLUSTERED 
(
	[radiologyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ReferialDoctor]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReferialDoctor](
	[patientID] [int] NOT NULL,
	[doctorID] [int] NOT NULL,
	[timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK_ReferialDoctor] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC,
	[doctorID] ASC,
	[timestamp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Schedule]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Schedule](
	[scheduleID] [int] IDENTITY(1,1) NOT NULL,
	[doctorID] [int] NOT NULL,
	[calender] [varchar](50) NULL,
	[timeZone] [varchar](10) NOT NULL,
	[dateTimeStart] [datetime] NOT NULL,
	[dateTimeEnd] [datetime] NULL,
	[duration] [time](7) NULL,
	[exclusionDate] [text] NULL,
	[exclusionRule] [text] NULL,
	[recurrenceDate] [text] NULL,
	[recurrenceRule] [text] NULL,
 CONSTRAINT [PK_Schedule_1] PRIMARY KEY CLUSTERED 
(
	[scheduleID] ASC,
	[doctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 11/21/2013 11:53:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[staffID] [int] NOT NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[staffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Allergy] ON 

INSERT [dbo].[Allergy] ([allergyID], [name], [category]) VALUES (1, N'allergy', N'myCategory')
INSERT [dbo].[Allergy] ([allergyID], [name], [category]) VALUES (2, N'2allergy', N'2myCategory')
INSERT [dbo].[Allergy] ([allergyID], [name], [category]) VALUES (3, N'abcdef', N'Drug Allergy')
SET IDENTITY_INSERT [dbo].[Allergy] OFF
SET IDENTITY_INSERT [dbo].[Diagnosis] ON 

INSERT [dbo].[Diagnosis] ([diagnosisID], [name], [description]) VALUES (1, N'diagnosisname', N'daignosisdescription')
INSERT [dbo].[Diagnosis] ([diagnosisID], [name], [description]) VALUES (2, N'diagnosis2', N'dignosis2')
SET IDENTITY_INSERT [dbo].[Diagnosis] OFF
INSERT [dbo].[Doctor] ([doctorID], [billingCode], [doctorName]) VALUES (1, N'123456', N'John Smith')
INSERT [dbo].[Employee] ([employeeID], [hireDate], [userName], [password]) VALUES (1, CAST(0x80360B00 AS Date), N'lovu', N'123123')
INSERT [dbo].[EMR] ([patientID], [doctorID], [timestamp], [clinicalImpression], [bloodPressure], [respiratoryRate], [pulseRate], [temperature], [height], [weight], [painScale], [chiefComplaint]) VALUES (1, 1, CAST(0x80360B00 AS Date), N'impression`', N'120/80', N'100', N'72', N'99', N'172', N'72', N'12', N'headache')
INSERT [dbo].[EMR] ([patientID], [doctorID], [timestamp], [clinicalImpression], [bloodPressure], [respiratoryRate], [pulseRate], [temperature], [height], [weight], [painScale], [chiefComplaint]) VALUES (1, 1, CAST(0x81360B00 AS Date), N'impression2', N'100/60', N'99', N'70', N'98', N'170', N'70', N'10', N'respiratory problem')
INSERT [dbo].[EMR] ([patientID], [doctorID], [timestamp], [clinicalImpression], [bloodPressure], [respiratoryRate], [pulseRate], [temperature], [height], [weight], [painScale], [chiefComplaint]) VALUES (2, 2, CAST(0xF3340B00 AS Date), N'impresion 1', N'0/0', N'20', N'46', N'84', N'200', N'72', N'11', N'Crazy')
INSERT [dbo].[EMRDiagnosis] ([patientID], [doctorID], [timestamp], [diagnosisID]) VALUES (1, 1, CAST(0x80360B00 AS Date), 1)
INSERT [dbo].[EMRDiagnosis] ([patientID], [doctorID], [timestamp], [diagnosisID]) VALUES (1, 1, CAST(0x81360B00 AS Date), 2)
INSERT [dbo].[EMRDiagnosis] ([patientID], [doctorID], [timestamp], [diagnosisID]) VALUES (2, 2, CAST(0xF3340B00 AS Date), 2)
INSERT [dbo].[EMRLaboratory] ([patientID], [doctorID], [timestamp], [laboratoryID]) VALUES (1, 1, CAST(0x80360B00 AS Date), 1)
INSERT [dbo].[EMRLaboratory] ([patientID], [doctorID], [timestamp], [laboratoryID]) VALUES (1, 1, CAST(0x80360B00 AS Date), 2)
INSERT [dbo].[EMRLaboratory] ([patientID], [doctorID], [timestamp], [laboratoryID]) VALUES (1, 1, CAST(0x81360B00 AS Date), 2)
INSERT [dbo].[EMRLaboratory] ([patientID], [doctorID], [timestamp], [laboratoryID]) VALUES (2, 2, CAST(0xF3340B00 AS Date), 2)
INSERT [dbo].[EMRMedication] ([patientID], [doctorID], [timestamp], [medicationID]) VALUES (1, 1, CAST(0x80360B00 AS Date), 1)
INSERT [dbo].[EMRMedication] ([patientID], [doctorID], [timestamp], [medicationID]) VALUES (1, 1, CAST(0x81360B00 AS Date), 2)
INSERT [dbo].[EMRMedication] ([patientID], [doctorID], [timestamp], [medicationID]) VALUES (2, 2, CAST(0xF3340B00 AS Date), 2)
INSERT [dbo].[EMRRadiology] ([patientID], [doctorID], [timestamp], [radiologyID]) VALUES (1, 1, CAST(0x80360B00 AS Date), 1)
INSERT [dbo].[EMRRadiology] ([patientID], [doctorID], [timestamp], [radiologyID]) VALUES (1, 1, CAST(0x81360B00 AS Date), 2)
INSERT [dbo].[EMRRadiology] ([patientID], [doctorID], [timestamp], [radiologyID]) VALUES (2, 2, CAST(0xF3340B00 AS Date), 2)
SET IDENTITY_INSERT [dbo].[Laboratory] ON 

INSERT [dbo].[Laboratory] ([laboratoryID], [name], [description]) VALUES (1, N'labname', N'labdescr')
INSERT [dbo].[Laboratory] ([laboratoryID], [name], [description]) VALUES (2, N'labname2', N'labdescr2')
SET IDENTITY_INSERT [dbo].[Laboratory] OFF
SET IDENTITY_INSERT [dbo].[Medication] ON 

INSERT [dbo].[Medication] ([medicationID], [name], [description]) VALUES (1, N'surgery', N'heart')
INSERT [dbo].[Medication] ([medicationID], [name], [description]) VALUES (2, N'general', N'kidney')
SET IDENTITY_INSERT [dbo].[Medication] OFF
SET IDENTITY_INSERT [dbo].[Patient] ON 

INSERT [dbo].[Patient] ([patientID], [registratonDate], [lastName], [giveMiddleName], [dateOfBirth], [gender]) VALUES (1, CAST(0x80360B00 AS Date), N'Arora     ', N'Sumit     ', CAST(0x80360B00 AS Date), N'Female    ')
INSERT [dbo].[Patient] ([patientID], [registratonDate], [lastName], [giveMiddleName], [dateOfBirth], [gender]) VALUES (2, CAST(0x22360B00 AS Date), N'Sharma', N'Lovu Dhiraj', CAST(0x1B150B00 AS Date), N'Male')
INSERT [dbo].[Patient] ([patientID], [registratonDate], [lastName], [giveMiddleName], [dateOfBirth], [gender]) VALUES (3, CAST(0xCF370B00 AS Date), N'Do', N'Tram', CAST(0xE91A0B00 AS Date), N'Female')
INSERT [dbo].[Patient] ([patientID], [registratonDate], [lastName], [giveMiddleName], [dateOfBirth], [gender]) VALUES (4, CAST(0xCF370B00 AS Date), N'Kang', N'Vinnie', CAST(0x80360B00 AS Date), N'Male')
INSERT [dbo].[Patient] ([patientID], [registratonDate], [lastName], [giveMiddleName], [dateOfBirth], [gender]) VALUES (5, CAST(0xCF370B00 AS Date), N'Kang', N'Vinnie', CAST(0x80360B00 AS Date), N'Male')
INSERT [dbo].[Patient] ([patientID], [registratonDate], [lastName], [giveMiddleName], [dateOfBirth], [gender]) VALUES (1005, CAST(0xD6370B00 AS Date), N'Simpson', N'Doreen', CAST(0xEAEE0A00 AS Date), N'Female')
SET IDENTITY_INSERT [dbo].[Patient] OFF
INSERT [dbo].[PatientAddress] ([patientID], [type], [deliveryAddress], [subdivision], [division], [postalCode], [country]) VALUES (1, N'Home', N'826 brimorton', N'scarborough', N'ontario', N'm1g2s9', N'Canada')
INSERT [dbo].[PatientAddress] ([patientID], [type], [deliveryAddress], [subdivision], [division], [postalCode], [country]) VALUES (2, N'Home', N'3 Villa Apartment', N'Ludhiana', N'Punjab', N'm1m1m1', N'India')
INSERT [dbo].[PatientAddress] ([patientID], [type], [deliveryAddress], [subdivision], [division], [postalCode], [country]) VALUES (5, N'Mailing', N'76 Port Union', N'Scar', N'ON', N'm1j3k4', NULL)
INSERT [dbo].[PatientAddress] ([patientID], [type], [deliveryAddress], [subdivision], [division], [postalCode], [country]) VALUES (1005, N'', N'65 Progress Ave', N'SCARBOROUGH', N'ON', N'M3B 4J5', NULL)
INSERT [dbo].[PatientAllergy] ([patientID], [allergyID]) VALUES (1, 1)
INSERT [dbo].[PatientAllergy] ([patientID], [allergyID]) VALUES (2, 2)
INSERT [dbo].[PatientAllergy] ([patientID], [allergyID]) VALUES (4, 3)
INSERT [dbo].[PatientAllergy] ([patientID], [allergyID]) VALUES (5, 3)
INSERT [dbo].[PatientEmail] ([patientID], [type], [emailAddress]) VALUES (2, N'Personal', N'raman@yahoo.com')
INSERT [dbo].[PatientEmail] ([patientID], [type], [emailAddress]) VALUES (1, N'Business', N'lovudsharma@yahoo.com')
INSERT [dbo].[PatientEmail] ([patientID], [type], [emailAddress]) VALUES (3, N'Business', N'dothuytram@gmail.com')
INSERT [dbo].[PatientEmail] ([patientID], [type], [emailAddress]) VALUES (5, N'Business', N'sample@cencol.ca')
INSERT [dbo].[PatientEmail] ([patientID], [type], [emailAddress]) VALUES (1005, N'Personal', N'sdoreen@gmail.com')
INSERT [dbo].[PatientOHIPInsurance] ([patientID], [insuranceNumber], [versionCode], [expiryDate]) VALUES (2, N'1111111111', N'02', CAST(0xF3340B00 AS Date))
INSERT [dbo].[PatientOHIPInsurance] ([patientID], [insuranceNumber], [versionCode], [expiryDate]) VALUES (1, N'0000000000', N'11', CAST(0x80360B00 AS Date))
INSERT [dbo].[PatientOHIPInsurance] ([patientID], [insuranceNumber], [versionCode], [expiryDate]) VALUES (3, N'1232453564', N'', CAST(0xED370B00 AS Date))
INSERT [dbo].[PatientOHIPInsurance] ([patientID], [insuranceNumber], [versionCode], [expiryDate]) VALUES (4, N'8797987979', N'BH', CAST(0x80360B00 AS Date))
INSERT [dbo].[PatientOHIPInsurance] ([patientID], [insuranceNumber], [versionCode], [expiryDate]) VALUES (5, N'8907809787', N'BH', CAST(0x80360B00 AS Date))
INSERT [dbo].[PatientOHIPInsurance] ([patientID], [insuranceNumber], [versionCode], [expiryDate]) VALUES (1005, N'7897987987', N'GY', CAST(0xC73A0B00 AS Date))
INSERT [dbo].[PatientPhone] ([patientID], [type], [phoneNumber]) VALUES (2, N'Home', N'2222222222')
INSERT [dbo].[PatientPhone] ([patientID], [type], [phoneNumber]) VALUES (1, N'Home', N'6464647479')
INSERT [dbo].[PatientPhone] ([patientID], [type], [phoneNumber]) VALUES (1, N'Home', N'6464647479')
INSERT [dbo].[PatientPhone] ([patientID], [type], [phoneNumber]) VALUES (3, N'Home', N'647-686-1193')
INSERT [dbo].[PatientPhone] ([patientID], [type], [phoneNumber]) VALUES (4, N'Work', N'416-889-4657')
INSERT [dbo].[PatientPhone] ([patientID], [type], [phoneNumber]) VALUES (5, N'Home', N'416-232-3232`')
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([personID], [lastName], [givenMiddleName], [dateOfBirth], [gender]) VALUES (1, N'doctorLastname', N'doctorfirstname', CAST(0x6A070B00 AS Date), N'Male')
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[Radiology] ON 

INSERT [dbo].[Radiology] ([radiologyID], [name], [description]) VALUES (1, N'radioname', N'radiodesc')
INSERT [dbo].[Radiology] ([radiologyID], [name], [description]) VALUES (2, N'radio name 2', N'radio desc 2')
SET IDENTITY_INSERT [dbo].[Radiology] OFF
INSERT [dbo].[ReferialDoctor] ([patientID], [doctorID]) VALUES (1, 1)
INSERT [dbo].[ReferialDoctor] ([patientID], [doctorID]) VALUES (2, 1)
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Patient] FOREIGN KEY([patientID])
REFERENCES [dbo].[Patient] ([patientID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Patient]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Schedule] FOREIGN KEY([scheduleID], [doctorID])
REFERENCES [dbo].[Schedule] ([scheduleID], [doctorID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Schedule]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Employee] FOREIGN KEY([doctorID])
REFERENCES [dbo].[Employee] ([employeeID])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_Employee]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Person] FOREIGN KEY([employeeID])
REFERENCES [dbo].[Person] ([personID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Person]
GO
ALTER TABLE [dbo].[EMR]  WITH CHECK ADD  CONSTRAINT [FK_EMR_Patient] FOREIGN KEY([patientID])
REFERENCES [dbo].[Patient] ([patientID])
GO
ALTER TABLE [dbo].[EMR] CHECK CONSTRAINT [FK_EMR_Patient]
GO
ALTER TABLE [dbo].[EMRDiagnosis]  WITH CHECK ADD  CONSTRAINT [FK_EMRDiagnosis_Diagnosis] FOREIGN KEY([diagnosisID])
REFERENCES [dbo].[Diagnosis] ([diagnosisID])
GO
ALTER TABLE [dbo].[EMRDiagnosis] CHECK CONSTRAINT [FK_EMRDiagnosis_Diagnosis]
GO
ALTER TABLE [dbo].[EMRDiagnosis]  WITH CHECK ADD  CONSTRAINT [FK_EMRDiagnosis_EMR] FOREIGN KEY([patientID], [doctorID], [timestamp])
REFERENCES [dbo].[EMR] ([patientID], [doctorID], [timestamp])
GO
ALTER TABLE [dbo].[EMRDiagnosis] CHECK CONSTRAINT [FK_EMRDiagnosis_EMR]
GO
ALTER TABLE [dbo].[EMRLaboratory]  WITH CHECK ADD  CONSTRAINT [FK_EMRLaboratory_EMR] FOREIGN KEY([patientID], [doctorID], [timestamp])
REFERENCES [dbo].[EMR] ([patientID], [doctorID], [timestamp])
GO
ALTER TABLE [dbo].[EMRLaboratory] CHECK CONSTRAINT [FK_EMRLaboratory_EMR]
GO
ALTER TABLE [dbo].[EMRLaboratory]  WITH CHECK ADD  CONSTRAINT [FK_EMRLaboratory_Laboratory] FOREIGN KEY([laboratoryID])
REFERENCES [dbo].[Laboratory] ([laboratoryID])
GO
ALTER TABLE [dbo].[EMRLaboratory] CHECK CONSTRAINT [FK_EMRLaboratory_Laboratory]
GO
ALTER TABLE [dbo].[EMRMedication]  WITH CHECK ADD  CONSTRAINT [FK_EMRMedication_EMR] FOREIGN KEY([patientID], [doctorID], [timestamp])
REFERENCES [dbo].[EMR] ([patientID], [doctorID], [timestamp])
GO
ALTER TABLE [dbo].[EMRMedication] CHECK CONSTRAINT [FK_EMRMedication_EMR]
GO
ALTER TABLE [dbo].[EMRMedication]  WITH CHECK ADD  CONSTRAINT [FK_EMRMedication_Medication] FOREIGN KEY([medicationID])
REFERENCES [dbo].[Medication] ([medicationID])
GO
ALTER TABLE [dbo].[EMRMedication] CHECK CONSTRAINT [FK_EMRMedication_Medication]
GO
ALTER TABLE [dbo].[EMRRadiology]  WITH CHECK ADD  CONSTRAINT [FK_EMRRadiology_EMR] FOREIGN KEY([patientID], [doctorID], [timestamp])
REFERENCES [dbo].[EMR] ([patientID], [doctorID], [timestamp])
GO
ALTER TABLE [dbo].[EMRRadiology] CHECK CONSTRAINT [FK_EMRRadiology_EMR]
GO
ALTER TABLE [dbo].[EMRRadiology]  WITH CHECK ADD  CONSTRAINT [FK_EMRRadiology_Radiology] FOREIGN KEY([radiologyID])
REFERENCES [dbo].[Radiology] ([radiologyID])
GO
ALTER TABLE [dbo].[EMRRadiology] CHECK CONSTRAINT [FK_EMRRadiology_Radiology]
GO
ALTER TABLE [dbo].[Manager]  WITH CHECK ADD  CONSTRAINT [FK_Manager_Employee] FOREIGN KEY([managerID])
REFERENCES [dbo].[Employee] ([employeeID])
GO
ALTER TABLE [dbo].[Manager] CHECK CONSTRAINT [FK_Manager_Employee]
GO
ALTER TABLE [dbo].[PatientAddress]  WITH CHECK ADD  CONSTRAINT [FK_PatientAddress_Patient] FOREIGN KEY([patientID])
REFERENCES [dbo].[Patient] ([patientID])
GO
ALTER TABLE [dbo].[PatientAddress] CHECK CONSTRAINT [FK_PatientAddress_Patient]
GO
ALTER TABLE [dbo].[PatientAllergy]  WITH CHECK ADD  CONSTRAINT [FK_PatientAllergy_Allergy] FOREIGN KEY([allergyID])
REFERENCES [dbo].[Allergy] ([allergyID])
GO
ALTER TABLE [dbo].[PatientAllergy] CHECK CONSTRAINT [FK_PatientAllergy_Allergy]
GO
ALTER TABLE [dbo].[PatientAllergy]  WITH CHECK ADD  CONSTRAINT [FK_PatientAllergy_Patient] FOREIGN KEY([patientID])
REFERENCES [dbo].[Patient] ([patientID])
GO
ALTER TABLE [dbo].[PatientAllergy] CHECK CONSTRAINT [FK_PatientAllergy_Patient]
GO
ALTER TABLE [dbo].[PatientEmail]  WITH CHECK ADD  CONSTRAINT [FK_PatientEmail_Patient] FOREIGN KEY([patientID])
REFERENCES [dbo].[Patient] ([patientID])
GO
ALTER TABLE [dbo].[PatientEmail] CHECK CONSTRAINT [FK_PatientEmail_Patient]
GO
ALTER TABLE [dbo].[PatientOHIPInsurance]  WITH CHECK ADD  CONSTRAINT [FK_PatientInsurance_Patient] FOREIGN KEY([patientID])
REFERENCES [dbo].[Patient] ([patientID])
GO
ALTER TABLE [dbo].[PatientOHIPInsurance] CHECK CONSTRAINT [FK_PatientInsurance_Patient]
GO
ALTER TABLE [dbo].[PatientPhone]  WITH CHECK ADD  CONSTRAINT [FK_PatientPhone_Patient] FOREIGN KEY([patientID])
REFERENCES [dbo].[Patient] ([patientID])
GO
ALTER TABLE [dbo].[PatientPhone] CHECK CONSTRAINT [FK_PatientPhone_Patient]
GO
ALTER TABLE [dbo].[PersonAddress]  WITH CHECK ADD  CONSTRAINT [FK_PersonAddress_Person] FOREIGN KEY([personID])
REFERENCES [dbo].[Person] ([personID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PersonAddress] CHECK CONSTRAINT [FK_PersonAddress_Person]
GO
ALTER TABLE [dbo].[PersonEmail]  WITH CHECK ADD  CONSTRAINT [FK_PersonEmail_Person] FOREIGN KEY([personID])
REFERENCES [dbo].[Person] ([personID])
GO
ALTER TABLE [dbo].[PersonEmail] CHECK CONSTRAINT [FK_PersonEmail_Person]
GO
ALTER TABLE [dbo].[PersonPhone]  WITH CHECK ADD  CONSTRAINT [FK_PersonPhone_Person] FOREIGN KEY([personID])
REFERENCES [dbo].[Person] ([personID])
GO
ALTER TABLE [dbo].[PersonPhone] CHECK CONSTRAINT [FK_PersonPhone_Person]
GO
ALTER TABLE [dbo].[ReferialDoctor]  WITH CHECK ADD  CONSTRAINT [FK_ReferialDoctor_Doctor] FOREIGN KEY([doctorID])
REFERENCES [dbo].[Doctor] ([doctorID])
GO
ALTER TABLE [dbo].[ReferialDoctor] CHECK CONSTRAINT [FK_ReferialDoctor_Doctor]
GO
ALTER TABLE [dbo].[ReferialDoctor]  WITH CHECK ADD  CONSTRAINT [FK_ReferialDoctor_Patient] FOREIGN KEY([patientID])
REFERENCES [dbo].[Patient] ([patientID])
GO
ALTER TABLE [dbo].[ReferialDoctor] CHECK CONSTRAINT [FK_ReferialDoctor_Patient]
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_Doctor] FOREIGN KEY([doctorID])
REFERENCES [dbo].[Doctor] ([doctorID])
GO
ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK_Schedule_Doctor]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Employee] FOREIGN KEY([staffID])
REFERENCES [dbo].[Employee] ([employeeID])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_Employee]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PersonAddress'
GO
USE [master]
GO
ALTER DATABASE [Giberson] SET  READ_WRITE 
GO
