using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MedicalInformationManagementSystem;
using MIMS;
using MedicalInformationManagementSystem.Forms;
using System.Data;


namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for SearchPatient
    /// </summary>
    [TestClass]
    public class TestSearchPatient
    {
        [TestMethod]
        public void TestCreatePatientSearchObject()
        {
            MedicalInformationManagementSystem.SearchPatient search = new SearchPatient();
            Assert.IsNotNull(search);
                  }

        [TestMethod]
        public void testCreateSearchPatientExistDictionary()
        {
            String patId = "1";
            MedicalInformationManagementSystem.SearchPatient pa = new SearchPatient();
            Assert.IsNotNull(pa);
            Dictionary<String, String> dict = pa.createCheckPatientExistsDictionary(patId);
            Assert.IsNotNull(dict);
            Assert.IsTrue(dict.ContainsKey("@patientId"));
            Assert.AreSame(dict["@patientId"], patId);
        }

        [TestMethod]
        public void testCreateSearchPatientExistDataTable()
        {
            String patId = "1";
            MedicalInformationManagementSystem.SearchPatient pa = new SearchPatient();
            Assert.IsNotNull(pa);
            Dictionary<String, String> dict = pa.createCheckPatientExistsDictionary(patId);
            Assert.IsNotNull(dict);
            Assert.IsTrue(dict.ContainsKey("@patientId"));
            Assert.AreSame(dict["@patientId"], patId);
            DataTable dat = new DataTable();
           //dat = pa.checkPatientExists(dict);
           
           //Assert.IsNotNull(dat);
           // Assert.AreEqual(dat.Rows[0][1],0);
        }
        
        
    }
}
