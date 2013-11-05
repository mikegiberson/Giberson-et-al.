﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using HealthInformaticSystem;
using System.Globalization;





namespace MIMS
{
    public partial class CreateDemForm : Form
    {

        private static SqlConnection myConnection = new SqlConnection("Data Source=.\\SQLSERVER;Initial Catalog=Giberson;Integrated Security=True");
        DataTable dtInsurance = null;
        DataTable dtAllergy = null;
        Dictionary<String, String> dictionary = null;
        DatabaseConnector dc = null;

        public CreateDemForm()
        {
            InitializeComponent(); 
           
                              
           
            cmbxGender.Text = "Male";
            cmbxInsuranceType.Text = "OHIP";
            cmbxPhoneType.Text = "Home";
            cmbxAddressType.Text = "Mailing";
            cmbxEmailType.Text = "Business";

            txtDOB.MaxLength=10;
            txtInsuranceNumber.MaxLength = 10;
            txtVersionCode.MaxLength = 2;
            txtVersionCode.CharacterCasing = CharacterCasing.Upper;
                                 

        }

        private static void insertPatient(Patient patient)
        {

            myConnection.Open();


            SqlCommand cmd = new SqlCommand("insert into Patient(registratonDate, lastName, giveMiddleName, dateOfBirth, gender) values(@reg_date,@pt_lName, @pt_fName,  @dob, @gender);");
            cmd.Connection = myConnection;

            cmd.Parameters.AddWithValue("@reg_date", (DateTime.Now).ToString());
            cmd.Parameters.AddWithValue("@pt_lName", patient.lastName);
            cmd.Parameters.AddWithValue("@pt_fName", patient.firstName);
            cmd.Parameters.AddWithValue("@dob", patient.dob);
            cmd.Parameters.AddWithValue("@gender", patient.gender);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            myConnection.Close();

        }

        private static void insertInsurance(Insurance insurance)
        {
            myConnection.Open();

            SqlCommand cmd = new SqlCommand("insert into PatientOHIPInsurance(patientID, insuranceNumber, versionCode, expiryDate) values(@pt_Id, @ins_number,  @ver_code, @exp_date);");
            cmd.Connection = myConnection;

            cmd.Parameters.AddWithValue("@pt_Id", insurance.patientID);
            cmd.Parameters.AddWithValue("@ins_number", insurance.insNumber);
            cmd.Parameters.AddWithValue("@ver_code", insurance.versionCode);
            cmd.Parameters.AddWithValue("@exp_date", insurance.expDate);

            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();


            myConnection.Close();
        }

        private static void insertAllergy(Allergy allergy)
        {
            myConnection.Open();

            SqlCommand cmd = new SqlCommand("insert into Allergy(name, category) values(@name, @category);");
            cmd.Connection = myConnection;

            cmd.Parameters.AddWithValue("@name", allergy.name);
            cmd.Parameters.AddWithValue("@category", allergy.category);
            
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();


            myConnection.Close();
        }

        private static void insertPatientAllergy(PatientAllergy patientAllergy)
        {
            myConnection.Open();

            SqlCommand cmd = new SqlCommand("insert into PatientAllergy(patientID, allergyID) values(@pt_Id, @allergy_Id);");
            cmd.Connection = myConnection;

            cmd.Parameters.AddWithValue("@pt_Id", patientAllergy.patientId);
            cmd.Parameters.AddWithValue("@allergy_Id", patientAllergy.allergyId);

            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();


            myConnection.Close();
        }

        private static void insertPhone(Phone phone)
        {
            myConnection.Open();

            SqlCommand cmd = new SqlCommand("insert into PatientPhone(patientID, type, phoneNumber) values(@pt_Id, @type, @phoneNo);");
            cmd.Connection = myConnection;

            cmd.Parameters.AddWithValue("@pt_Id", phone.patientID);
            cmd.Parameters.AddWithValue("@type", phone.type);
            cmd.Parameters.AddWithValue("@phoneNo", phone.phoneNumber);


            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();


            myConnection.Close();
        }

        private static void insertEmail(Email email)
        {
            myConnection.Open();

            SqlCommand cmd = new SqlCommand("insert into PatientEmail(patientID, type, emailAddress) values(@pt_Id, @type, @email);");
            cmd.Connection = myConnection;

            cmd.Parameters.AddWithValue("@pt_Id", email.patientID);
            cmd.Parameters.AddWithValue("@type", email.type);
            cmd.Parameters.AddWithValue("@email", email.email);


            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();


            myConnection.Close();
        }

        private static void insertAdress(Address address)
        {
            myConnection.Open();

            SqlCommand cmd = new SqlCommand("insert into PatientAddress(patientID, type, deliveryAddress, subdivision, division, postalCode) values(@pt_Id, @type, @address, @city, @province, @postalCode);");
            cmd.Connection = myConnection;

            cmd.Parameters.AddWithValue("@pt_Id", address.patientID);
            cmd.Parameters.AddWithValue("@type", address.type);
            cmd.Parameters.AddWithValue("@address", address.address);
            cmd.Parameters.AddWithValue("@city",address.city);
            cmd.Parameters.AddWithValue("@province",address.province);
            cmd.Parameters.AddWithValue("@postalCode",address.postalCode);

            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();


            myConnection.Close();
        }

        private int getAllergyIdfromAllergyTbl()
        {
            try
            {
                dictionary = new Dictionary<string, string>();
                dictionary.Add("@allergyName", txtAllergyName.Text);
                dc = new DatabaseConnector();
                dtAllergy = dc.getData("GetAllergyID1", dictionary);
                int allergyID = int.Parse(dtAllergy.Rows[0][0].ToString());
                return allergyID;
            }
            catch
            {
                int allergyID = 0;
                return allergyID;

            }
        }

        private int getAllergyIdfromAllergyTbl2()
        {
            myConnection.Open();
            SqlCommand cmd = new SqlCommand("GetAllergyID2", myConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            object returnVALUE = cmd.ExecuteScalar();

            int a = int.Parse(returnVALUE.ToString());

            cmd.ExecuteNonQuery();
            myConnection.Close();
            return a;
        }

        private static int  getPtIdfromPatienTbl()
        {
            myConnection.Open();
            SqlCommand cmd = new SqlCommand("GetPatientID", myConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            
            object returnVALUE = cmd.ExecuteScalar();
           
            int a = int.Parse(returnVALUE.ToString());

            cmd.ExecuteNonQuery();
            myConnection.Close();
            return a;
            
         }

        private bool DOB_validation()
        {
            DateTime Test;
            bool valid;
            if

            (DateTime.TryParseExact(txtDOB.Text, "yyyy-mm-dd", null, DateTimeStyles.None, out Test) == true)
            {
             valid = true;
            }

            else
            {
               valid=false;
            }
            return valid;
        }

        private bool exp_validation()
        {
            DateTime Test;
            bool valid;
            if

            (DateTime.TryParseExact(txtInsuranceExpDate.Text, "yyyy-mm-dd", null, DateTimeStyles.None, out Test) == true)
            {
               valid = true;
            }

            else
            {
               valid = false;
            }
            return valid;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            bool DOB_valid;
            bool exp_valid;
            bool pass=false;

            //check whether Insurance numer exits
            dictionary = new Dictionary<string, string>();
            dictionary.Add("@insuranceNumber", txtInsuranceNumber.Text);
            dc = new DatabaseConnector();
            dtInsurance = dc.getData("CheckInsuranceExists", dictionary);
            int ins_exist = int.Parse(dtInsurance.Rows[0][0].ToString());

            //create new patient
            Patient patient = new Patient();
            patient.firstName = txtFirstName.Text;
            patient.lastName = txtLastName.Text;
            patient.dob = txtDOB.Text;
            patient.gender = cmbxGender.GetItemText(cmbxGender.SelectedItem);

            //create new insurance
            Insurance insurance = new Insurance();
            insurance.timestamp = (DateTime.Now).ToString();
            insurance.insNumber = txtInsuranceNumber.Text;
            insurance.versionCode = txtVersionCode.Text;
            insurance.expDate = txtInsuranceExpDate.Text;

            //create new allergy
            Allergy allergy = new Allergy();
            allergy.name = txtAllergyName.Text;
            allergy.category = txtAllergyCatergory.Text;

            //create new allergy-patient
            PatientAllergy ptAllgergy = new PatientAllergy();
                    
            //ins number : number only
            //ins vc : character only
            //no blank: name, dob

            Phone phone = new Phone();
            phone.type = cmbxPhoneType.GetItemText(cmbxPhoneType.SelectedItem);
            phone.phoneNumber = txtPhoneNumber.Text;

            Email email = new Email();
            email.type = cmbxEmailType.GetItemText(cmbxEmailType.SelectedItem);
            email.email = txtEmail.Text;

            Address address = new Address();
            address.type = cmbxAddressType.GetItemText(cmbxAddressType.SelectedItem);
            address.address = txtAddress.Text;
            address.city = txtCity.Text;
            address.province = txtProvince.Text;
            address.postalCode = txtPostalCode.Text;

            DOB_valid = DOB_validation();
            exp_valid = exp_validation();

            if (DOB_valid == true && exp_valid == true && ins_exist == 0 && txtInsuranceNumber.TextLength == 10)
            {
                pass = true;
            }

              if (pass == true )
              {
                  insertPatient(patient);

                  patient.patientID = getPtIdfromPatienTbl();
                  insurance.patientID = patient.patientID;
                  phone.patientID = patient.patientID;
                  email.patientID = patient.patientID;
                  address.patientID = patient.patientID;
                  

                  insertInsurance(insurance);

                  if (getAllergyIdfromAllergyTbl() != 0)
                  {
                      ptAllgergy.patientId = patient.patientID;
                      ptAllgergy.allergyId = getAllergyIdfromAllergyTbl();
                      insertPatientAllergy(ptAllgergy);
                  }
                  else
                  {
                      insertAllergy(allergy);
                      ptAllgergy.patientId = patient.patientID;
                      ptAllgergy.allergyId = getAllergyIdfromAllergyTbl2();
                      insertPatientAllergy(ptAllgergy);
                  }

                  insertPhone(phone);
                  insertAdress(address);
                  insertEmail(email);

                    clearText();
                    MessageBox.Show("Patient was registed");
              }

              else if (txtInsuranceNumber.TextLength != 10) //number incorrect of left blank
              {
                  MessageBox.Show("Please insert correct insurance number");
              }
              else if (ins_exist != 0)
              {
                  MessageBox.Show("Insurance Number already exists");
              }
              else if (DOB_valid == false)
              {
                  MessageBox.Show("D.O.B not valid");
              }

              else if (exp_valid == false)
              {
                  MessageBox.Show("Insurance Expiry Date not valid");
              }
              
 
       

            

            

           
        }

        private void clearText()
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            txtDOB.Clear();
            cmbxGender.Items.Clear();

            cmbxInsuranceType.Items.Clear();
            txtInsuranceNumber.Clear();
            txtVersionCode.Clear();
            txtInsuranceExpDate.Clear();

            txtAllergyCatergory.Clear();
            txtAllergyName.Clear();

            txtPhoneNumber.Clear();
            cmbxPhoneType.Items.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtProvince.Clear();
            txtPostalCode.Clear();
            cmbxAddressType.Items.Clear();

            txtEmail.Clear();
            cmbxEmailType.Items.Clear();

            txtReferralDoctor.Clear();
            txtDoctorBillingCode.Clear();


        }

        
    }
}
