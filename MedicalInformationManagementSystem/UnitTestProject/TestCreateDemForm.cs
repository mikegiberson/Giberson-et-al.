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
using HealthInformaticSystem.Class_Library;

using System.Text.RegularExpressions;
using HealthInformaticSystem;
namespace UnitTestProject1
{
    [TestClass]
    public class TestCreateDemForm
    {
        [TestMethod]
        public void testCreateDemFormCreate()
        {
            MIMS.CreateDemForm a = new MIMS.CreateDemForm();
            Assert.IsNotNull(a);
        }

       
        [TestMethod]
        public void TestAddressClass()
        {
            Address a = new Address();
            a.patientID = 1;
            a.type = "Mailing";
            a.address = "141 Lakeridge Drive";
            a.city = "Scarborough";
            a.province = "Ontario";
            a.postalCode = "M1C 5K3";

            Assert.IsNotNull(a);
            Assert.AreEqual(1, a.patientID);
            Assert.AreEqual("Mailing", a.type);
            Assert.AreEqual("141 Lakeridge Drive", a.address);
            Assert.AreEqual("Scarborough", a.city);
            Assert.AreEqual("Ontario", a.province);
            Assert.AreEqual("M1C 5K3", a.postalCode);
            
            
        }

        [TestMethod]
        public void TestAllergyClass()
        {
            Allergy a = new Allergy();
            a.allergyId = 1;
            a.name = "abc";
            a.category = "cde";

            Assert.IsNotNull(a);
            Assert.AreEqual(1, a.allergyId);
            Assert.AreEqual("abc", a.name);
            Assert.AreEqual("cde", a.category);
           
        }

        [TestMethod]
        public void TestDoctorClass()
        {
            Doctor d = new Doctor();
            d.billingCode = "123456";
            d.name = "John Smith";

            Assert.IsNotNull(d);
            Assert.AreEqual("123456", d.billingCode);
            Assert.AreEqual("John Smith", d.name);
           

        }

        [TestMethod]
        public void TestEmailClass()
        {
            Email e = new Email();
            e.patientID = 1;
            e.type = "Personal";
            e.email = "dothuytram@my.centennialcollege.ca";

            Assert.IsNotNull(e);
            Assert.AreEqual(1, e.patientID);
            Assert.AreEqual("Personal", e.type);
            Assert.AreEqual("dothuytram@my.centennialcollege.ca", e.email);
        }

        [TestMethod]
        public void TestInsuranceClass()
        {
            Insurance i = new Insurance();
            i.patientID = 1;
            i.insNumber = "1234567890";
            i.expDate = "2015/12/12";
            i.versionCode = "CD";

            Assert.IsNotNull(i);
            Assert.AreEqual(1, i.patientID);
            Assert.AreEqual("1234567890", i.insNumber);
            Assert.AreEqual("2015/12/12", i.expDate);
            Assert.AreEqual("CD", i.versionCode);

        }

        [TestMethod]
        public void TestPatientClass()
        {
            Patient p = new Patient();
            p.patientID = 1;
            p.lastName = "Do";
            p.firstName = "Tram";
            p.dob = "2015/12/12";
            p.gender = "Female";

            Assert.IsNotNull(p);
            Assert.AreEqual(1, p.patientID);
            Assert.AreEqual("Do", p.lastName);
            Assert.AreEqual("Tram", p.firstName);
            Assert.AreEqual("2015/12/12", p.dob);
            Assert.AreEqual("Female", p.gender);


        }

        [TestMethod]
        public void TestPatietnAllergyClass()
        {
            PatientAllergy pa = new PatientAllergy();
            pa.patientId = 1;
            pa.allergyId = 1;

            Assert.IsNotNull(pa);
            Assert.AreEqual(1, pa.patientId);
            Assert.AreEqual(1, pa.allergyId);
        }

        [TestMethod]
        public void TestPhoneClass()
        {
            Phone p = new Phone();
            p.patientID = 1;
            p.type = "Home";
            p.phoneNumber = "647-896-5659";

            Assert.IsNotNull(p);
            Assert.AreEqual(1, p.patientID);
            Assert.AreEqual("Home", p.type);
            Assert.AreEqual("647-896-5659", p.phoneNumber);

        }

        [TestMethod]
        public void TestReferralDoctorClass()
        {
            ReferralDoctor r = new ReferralDoctor();
            r.patientID = 1;
            r.doctorID = 2;

            Assert.IsNotNull(r);
            Assert.AreEqual(1, r.patientID);
            Assert.AreEqual(2, r.doctorID);

        }

    }
}
