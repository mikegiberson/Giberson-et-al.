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


namespace UnitTestProject1
{
    [TestClass]
    public class TestViewDemography
    {
        [TestMethod]
        public void TestMethod1()
        {
            MedicalInformationManagementSystem.ViewDemography v = new MedicalInformationManagementSystem.ViewDemography();
            Assert.IsNotNull(v);
        }

        [TestMethod]
        public void TestCreateDictionary()
        {
            MedicalInformationManagementSystem.ViewDemography v = new MedicalInformationManagementSystem.ViewDemography();
            Assert.IsNotNull(v);
            Dictionary<String, String> dic;
            String patientID = "1";
            dic = v.createDictionary(patientID);
            Assert.IsNotNull(dic);
            Assert.IsTrue(dic.ContainsKey("@patientId"));
            Assert.AreSame(dic["@patientId"], patientID);

            

        }
    }
}
