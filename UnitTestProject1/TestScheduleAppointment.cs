using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MedicalInformationManagementSystem;

namespace UnitTestProject1
{
    [TestClass]
    public class TestScheduleAppointment
    {
        [TestMethod]
        public void ScheduleAppointmentTest1()
        {
            String PatientID = "1";
            String FirstName = "Sumit";
            String LastName = "Aroraa";

            ScheduleAppointment schedule = new ScheduleAppointment(PatientID, FirstName, LastName);

            String ScheduleID = "1";
            String DoctorID = "1";
            String DoctorName = "John Smith";
            String Date = "2013-12-09";

            schedule.addToSchedule(ScheduleID, DoctorID, DoctorName, Date, PatientID, LastName, FirstName);
        }
    }
}
