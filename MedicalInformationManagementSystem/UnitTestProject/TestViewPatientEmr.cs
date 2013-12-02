using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Input;
using MedicalInformationManagementSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace UnitTestProject1
{

    [TestClass]
    public class TestViewPatientEmr
    {

        [TestMethod]
        public void TestMethod1()
        {
            int a = 10;
            int b = 10;
            Assert.AreEqual(a, b);
        }

        [TestMethod]
        public void testCreatePatientEmr()
        {
            MedicalInformationManagementSystem.ViewPatientEMR vwEMR=new MedicalInformationManagementSystem.ViewPatientEMR();
            Assert.IsNotNull(vwEMR);
        }

        [TestMethod]
        public void testGetSortByName()
        {
            MedicalInformationManagementSystem.ViewPatientEMR vwEMR = new MedicalInformationManagementSystem.ViewPatientEMR();
            Assert.IsNotNull(vwEMR);
            Int16 sortBy = vwEMR.getSortBy(true,false, false);
            Assert.IsNotNull(sortBy);
            Assert.AreEqual(sortBy, 1);
        }

        [TestMethod]
        public void testGetSortById()
        {
            MedicalInformationManagementSystem.ViewPatientEMR vwEMR = new MedicalInformationManagementSystem.ViewPatientEMR();
            Assert.IsNotNull(vwEMR);
            Int16 sortBy = vwEMR.getSortBy(false, true, false);
            Assert.IsNotNull(sortBy);
            Assert.AreEqual(sortBy, 2);
        }

        [TestMethod]
        public void testGetSortByDateAndTime()
        {
            MedicalInformationManagementSystem.ViewPatientEMR vwEMR = new MedicalInformationManagementSystem.ViewPatientEMR();
            Assert.IsNotNull(vwEMR);
            Int16 sortBy = vwEMR.getSortBy(false, false, true);
            Assert.IsNotNull(sortBy);
            Assert.AreEqual(sortBy, 3);
        }

        [TestMethod]
        public void testCreateGetPatientDictionary()
        {
            String assesmentId = "1";
            MedicalInformationManagementSystem.ViewPatientEMR vwEMR = new MedicalInformationManagementSystem.ViewPatientEMR();
            Assert.IsNotNull(vwEMR);
            Dictionary<String, String> dict = vwEMR.createPatientDictionary(assesmentId);
            Assert.IsNotNull(dict);
            Assert.IsTrue(dict.ContainsKey("@patientId"));
            Assert.AreSame(dict["@patientId"], assesmentId);
        }

        [TestMethod]
        public void testgetPatientViewEmr()
        {
            MedicalInformationManagementSystem.ViewPatientEMR vwEMR = new MedicalInformationManagementSystem.ViewPatientEMR();
            Assert.IsNotNull(vwEMR);
            String assesmentId = "1";

            Dictionary<String, String> d = vwEMR.createPatientDictionary(assesmentId);
            //DatabaseConnector con = new DatabaseConnector();
            //DataTable dat = vwEMR.createGetPatient(d);
            //Assert.IsNotNull(dat);
            // testing for just for one value
            //Assert.AreEqual(dat.Rows[0][0].ToString(), "1");
        }
    }
}
