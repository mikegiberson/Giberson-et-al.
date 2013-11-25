USE [Giberson]
GO

/****** Object:  StoredProcedure [dbo].[GetPatientLatestEmrReport]    Script Date: 11/17/2013 12:57:46 AM ******/
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

