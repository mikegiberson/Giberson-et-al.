using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MedicalInformationManagementSystem.Forms;

using System.Windows.Input;
using System.Data;

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using MedicalInformationManagementSystem;
using System.Text;
using System.Threading.Tasks;
//using MedicalInformationManagementSystem.Reports;
using System.Text.RegularExpressions;


namespace UnitTestProject1
{
    [TestClass]
    public class TestPatientAssesment
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 10;
            int b = 10;
            Assert.AreEqual(a, b);
        }

        [TestMethod]
        public void testPatientAssesmentCreate()
        {
            MedicalInformationManagementSystem.Forms.PatientAssesment pa = new PatientAssesment();
            Assert.IsNotNull(pa);
        }

        [TestMethod]
        public void testPatientAssesmentObjects()
        {
            MedicalInformationManagementSystem.Forms.PatientAssesment pa = new PatientAssesment();
            Assert.IsNotNull(pa);
        }

        [TestMethod]
        public void testCreateGetPatientAssesmentDictionary()
        {
            String assesmentId = "1";
            MedicalInformationManagementSystem.Forms.PatientAssesment pa = new PatientAssesment();
            Assert.IsNotNull(pa);
            Dictionary<String, String> dict = pa.createGetPatientDictionary(assesmentId);
            Assert.IsNotNull(dict);
            Assert.IsTrue(dict.ContainsKey("@patientId"));
            Assert.AreSame(dict["@patientId"], assesmentId);
        }
       
        [TestMethod]
        public void testFormatDate()
        {
            MedicalInformationManagementSystem.Forms.PatientAssesment pa = new PatientAssesment();
            Assert.IsNotNull(pa);
            DateTime dt = new DateTime();
            string formattedDate = pa.formatDate(dt);
            Assert.IsNotNull(formattedDate);
         
            
        }
        [TestMethod]
        public void testcreateEmrRequest()
        {
            MedicalInformationManagementSystem.Forms.PatientAssesment pa = new PatientAssesment();
            Assert.IsNotNull(pa);
            String emrDate = "11/23/2013";
            String assesmentId = "1";
            Dictionary<String, String> d=pa.createEmrRequest(assesmentId,emrDate);
            Assert.IsNotNull(d);
            Assert.IsTrue(d.ContainsKey("@patientId"));
            Assert.IsTrue(d.ContainsKey("@emrDate"));
            Assert.AreSame(d["@patientId"],assesmentId);
            Assert.AreSame(d["@emrDate"], emrDate);
            
           
        }

        [TestMethod]
        public void getPatientEMRAccordingToDate()
        {
            MedicalInformationManagementSystem.Forms.PatientAssesment pa = new PatientAssesment();
            Assert.IsNotNull(pa);
             String emrDate = "2011/11/11";
            String assesmentId = "1";
            
            Dictionary<String, String> d=pa.createEmrRequest(assesmentId,emrDate);
           // DatabaseConnector con=new DatabaseConnector();
           // DataTable dat = pa.getPatientEMRAccordingToDate(d,con);
           // Assert.IsNotNull(dat);
            // testing for just for one value
           // Assert.AreEqual(dat.Rows[0][1].ToString(),"2");
        }

      

    }
}
