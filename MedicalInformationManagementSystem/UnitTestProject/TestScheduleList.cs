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
    public class TestScheduleList
    {
        [TestMethod]
        public void TestMethod1()
        {
            HealthInformaticSystem.ScheduleList s = new HealthInformaticSystem.ScheduleList();
            Assert.IsNotNull(s);
        }

        [TestMethod]
        public void TestCreateDoctorDayScheduleDictionary()
        {
            HealthInformaticSystem.ScheduleList s = new HealthInformaticSystem.ScheduleList();
            Assert.IsNotNull(s);
            Dictionary<String, String> dic;
            string date = "12/2/2013";
            string doctorID = "1";
            dic = s.createDoctorDayScheduleDictionary(date, doctorID);
            Assert.IsNotNull(dic);
            Assert.IsTrue(dic.ContainsKey("@date"));
            Assert.IsTrue(dic.ContainsKey("@doctorID"));
            Assert.AreSame(dic["@date"], date);
            Assert.AreSame(dic["@doctorID"], doctorID);

        }
    }
}
