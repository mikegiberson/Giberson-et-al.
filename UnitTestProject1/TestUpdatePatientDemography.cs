using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MedicalInformationManagementSystem;
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
    public class TestUpdatePatientDemography
    {
        [TestMethod]
        public void TestIsValidDateTimeTest()
        {
            UpdatePatientDemography upd = new UpdatePatientDemography();
            Assert.IsNotNull(upd);
            String testDate = "11/11/2011";
            bool check= upd.IsValidDateTimeTest(testDate);
            Assert.IsTrue(check);
        }

        [TestMethod]
        public void testcreateUpdatePatientDictionary()
        {
            UpdatePatientDemography upd = new UpdatePatientDemography();
            Assert.IsNotNull(upd);
            Dictionary<String, String> dic;
            String patid="1";
           String firstName= "SumitS"; 
            String lastName="Arora";
            String dobirth= "12/12/1989";
            String genders = "Male";
           dic=upd.createUpdatePatientDictionary(patid,firstName,lastName,dobirth,genders);
           Assert.IsNotNull(dic);
           Assert.IsTrue(dic.ContainsKey("@patientId"));
           Assert.AreSame(dic["@patientId"], patid);
           Assert.IsTrue(dic.ContainsKey("@firstName"));
           Assert.AreSame(dic["@firstName"], firstName);
           Assert.IsTrue(dic.ContainsKey("@lastName"));
           Assert.AreSame(dic["@lastName"], lastName);
           Assert.IsTrue(dic.ContainsKey("@dob"));
           Assert.AreSame(dic["@dob"], dobirth);
           Assert.IsTrue(dic.ContainsKey("@gender"));
           Assert.AreSame(dic["@gender"], genders);
            
        }
        [TestMethod]
        public void testcreateUpdateInsuranceDictionary()
        {
            UpdatePatientDemography upd = new UpdatePatientDemography();
            Assert.IsNotNull(upd);
            Dictionary<String, String> dic;
            String a = "1";
            String b = "1234567890";
            String c = "12";
            String d = "12/12/2015";

            dic = upd.createUpdateInsuranceDictionary(a, b, c, d);
            Assert.IsNotNull(dic);
            Assert.IsTrue(dic.ContainsKey("@patientId"));
            Assert.AreSame(dic["@patientId"], a);
            Assert.IsTrue(dic.ContainsKey("@insNumber"));
            Assert.AreSame(dic["@insNumber"], b);
            Assert.IsTrue(dic.ContainsKey("@versionCode"));
            Assert.AreSame(dic["@versionCode"], c);
            Assert.IsTrue(dic.ContainsKey("@expDate"));
            Assert.AreSame(dic["@expDate"], d);
           
            
        }

        [TestMethod]
        public void testcreateUpdatePatientPhoneDictionary()
        {
            UpdatePatientDemography upd = new UpdatePatientDemography();
            Assert.IsNotNull(upd);
            Dictionary<String, String> dic;
            String a = "1";
            String b = "1234567890";
            String c = "Home";
            

            dic = upd.createUpdatePatientPhoneDictionary(a, b, c);
            Assert.IsNotNull(dic);
            Assert.IsTrue(dic.ContainsKey("@patientId"));
            Assert.AreSame(dic["@patientId"], a);
            Assert.IsTrue(dic.ContainsKey("@phoneNo"));
            Assert.AreSame(dic["@phoneNo"], b);
            Assert.IsTrue(dic.ContainsKey("@phoneType"));
            Assert.AreSame(dic["@phoneType"], c);
           
        }
        [TestMethod]
        public void testcreateUpdatePatientEmailDictionary()
        {
            UpdatePatientDemography upd = new UpdatePatientDemography();
            Assert.IsNotNull(upd);
            Dictionary<String, String> dic;
            String a = "1";
            String b = "lovudsharma@yahoo.com";
            String c = "Peronal";


            dic = upd.createUpdatePatientEmailDictionary(a, b, c);
            Assert.IsNotNull(dic);
            Assert.IsTrue(dic.ContainsKey("@patientId"));
            Assert.AreSame(dic["@patientId"], a);
            Assert.IsTrue(dic.ContainsKey("@email"));
            Assert.AreSame(dic["@email"], b);
            Assert.IsTrue(dic.ContainsKey("@emailType"));
            Assert.AreSame(dic["@emailType"], c);
        }

        [TestMethod]
        public void testcreateUpdatePatientAddressDictionary()
        {
            UpdatePatientDemography upd = new UpdatePatientDemography();
            Assert.IsNotNull(upd);
            Dictionary<String, String> dic;
            String a = "1";
            String b = "lovudsharma@yahoo.com";
            String c = "Peronal";
            String d = "";
            String e = "";
            String f = "";
            String g = "";


            dic = upd.createUpdatePatientAddressDictionary(a, b, c,d,e,f,g);
            Assert.IsNotNull(dic);
            Assert.IsTrue(dic.ContainsKey("@patientId"));
            Assert.AreSame(dic["@patientId"], a);
            Assert.IsTrue(dic.ContainsKey("@addressType"));
            Assert.AreSame(dic["@addressType"], b);
            Assert.IsTrue(dic.ContainsKey("@address"));
            Assert.AreSame(dic["@address"], c);
            Assert.IsTrue(dic.ContainsKey("@city"));
            Assert.AreSame(dic["@city"], d);
            Assert.IsTrue(dic.ContainsKey("@province"));
            Assert.AreSame(dic["@province"], e);
            Assert.IsTrue(dic.ContainsKey("@postalCode"));
            Assert.AreSame(dic["@postalCode"], f);
            Assert.IsTrue(dic.ContainsKey("@country"));
            Assert.AreSame(dic["@country"], g);
        }
    }
}
