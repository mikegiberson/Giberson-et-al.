using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MedicalInformationManagementSystem;
using MIMS;
using MedicalInformationManagementSystem.Forms;
using System.Windows.Input;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MedicalInformationManagementSystem.Reports;
using System.Text.RegularExpressions;

namespace UnitTestProject1.TestResults
{
    [TestClass]
    public class TestAddDoctorList
    {
        [TestMethod]
        public void TestMethod1()
        {
            HealthInformaticSystem.AddtoDoctorList a = new HealthInformaticSystem.AddtoDoctorList();
            Assert.IsNotNull(a);
        }

        [TestMethod]
        public void TestCreatePatientDictionary()
        {
            HealthInformaticSystem.AddtoDoctorList a = new HealthInformaticSystem.AddtoDoctorList();
            Assert.IsNotNull(a);
            Dictionary<String, String> dic;
            String patientID = "1";
            dic = a.createPatientDictionary(patientID);
            Assert.IsNotNull(dic);
            Assert.IsTrue(dic.ContainsKey("@patientId"));
            Assert.AreSame(dic["@patientId"], patientID);
        }

        [TestMethod]
        public void TestCreateDoctorNameDictionary()
        {
            HealthInformaticSystem.AddtoDoctorList a = new HealthInformaticSystem.AddtoDoctorList();
            Assert.IsNotNull(a);
            Dictionary<String, String> dic;
            String date = "12/1/2013";
            dic = a.createDoctorNameDictionary(date);
            Assert.IsNotNull(dic);
            Assert.IsTrue(dic.ContainsKey("@date"));
            Assert.AreSame(dic["@date"], date);

        }

        [TestMethod]
        public void TestCreateScheduleDictionary()
        {
            HealthInformaticSystem.AddtoDoctorList a = new HealthInformaticSystem.AddtoDoctorList();
            Assert.IsNotNull(a);
            Dictionary<String, String> dic;
            String doctorID = "1";
            String date = "12/1/2013";
            dic = a.createScheduleDictionary(doctorID, date);
            Assert.IsNotNull(dic);
            Assert.IsTrue(dic.ContainsKey("@doctorID"));
            Assert.AreSame(dic["@doctorID"], doctorID);
            Assert.IsTrue(dic.ContainsKey("@date"));
            Assert.AreSame(dic["@date"], date);
        }

        [TestMethod]
        public void TestCreateDoctorIDDictionary()
        {
            HealthInformaticSystem.AddtoDoctorList a = new HealthInformaticSystem.AddtoDoctorList();
            Assert.IsNotNull(a);
            Dictionary<String, String> dic;
            String name = "John Smith";
            dic = a.createDoctorIDDictionary(name);
            Assert.IsNotNull(dic);
            Assert.IsTrue(dic.ContainsKey("@name"));
            Assert.AreSame (dic["@name"], name);
        }

        [TestMethod]
        public void TestCreateDayScheduleDictionary()
        {
            HealthInformaticSystem.AddtoDoctorList a = new HealthInformaticSystem.AddtoDoctorList();
            Assert.IsNotNull(a);
            Dictionary<String, String> dic;
            //string scheduleID, String date, String doctorID, String doctorName, String patientID, string lastName, string firstName
            string scheduleID = "1";
            string date = "12/1/2013";
            string doctorID = "1";
            string doctorName = "John Smith";
            string patientID = "1";
            string lastName = "Do";
            string firstName = "Tram";
            dic = a.createDayScheduleDictionary(scheduleID,  date,  doctorID,  doctorName,  patientID, lastName, firstName);
            Assert.IsNotNull(dic);
            Assert.IsTrue(dic.ContainsKey("@scheduleID"));
            Assert.IsTrue(dic.ContainsKey("@today"));
            Assert.IsTrue(dic.ContainsKey("@doctorID"));
            Assert.IsTrue(dic.ContainsKey("@doctorName"));
            Assert.IsTrue(dic.ContainsKey("@patientID"));
            Assert.IsTrue(dic.ContainsKey("@lastName"));
            Assert.IsTrue(dic.ContainsKey("@firstName"));
            Assert.AreSame(dic["@scheduleID"], scheduleID);
            Assert.AreSame(dic["@today"], date);
            Assert.AreSame(dic["@doctorID"], doctorID);
            Assert.AreSame(dic["@doctorName"], doctorName);
            Assert.AreSame(dic["@patientID"], patientID);
            Assert.AreSame(dic["@lastName"], lastName);
            Assert.AreSame(dic["@firstName"], firstName);



        }
    }
}
