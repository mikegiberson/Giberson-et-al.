using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MedicalInformationManagementSystem;
using System.Globalization;
using System.Text.RegularExpressions;
using HealthInformaticSystem;



namespace MIMS
{
    public partial class UpdatePatientDemography : Form
    {
        public Boolean forEdit = false;
        public int patientId = 1;
        DataTable dtPatient = null;
        DataTable dtReferenceDoctor = null;
        DataTable dtAllergy = null;
        DataTable dtPatientEmail = null;
        DataTable dtPatientAddress = null;
        DataTable dtPatientPhone = null;
        DataTable dtInsurance = null;
        DatabaseConnector dc = null;
        Dictionary<String, String> dictionary = null;

        public UpdatePatientDemography()
        {
            InitializeComponent();
            enableFields();
            btn_update.Hide();
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UpdatePatientDemography.ActiveForm.Hide();
        }
        public bool IsValidDateTimeTest(string dateTime)
        {
            string[] formats = { "MM/dd/yyyy" };
            DateTime parsedDateTime;
            return DateTime.TryParseExact(dateTime, formats, new CultureInfo("en-US"),
                                           DateTimeStyles.None, out parsedDateTime);
        }

        public Dictionary<String, String> createUpdatePatientDictionary(String patientId, String fname, String lname, String dob, String gender)
        {
            Dictionary<String, String>  dictionary = new Dictionary<string, string>();
            dictionary.Add("@patientId", patientId);
            dictionary.Add("@firstName", fname);
            dictionary.Add("@lastName", lname);
            dictionary.Add("@dob", dob);
            dictionary.Add("@gender", gender);
            return dictionary;
        }

        public Dictionary<String, String> createUpdateInsuranceDictionary(String patientId, String insnum, String versioncode, String expdate)
        {
            Dictionary<String, String> dictionary = new Dictionary<string, string>();
            dictionary.Add("@patientId", patientId);
            dictionary.Add("@insNumber", insnum);
            dictionary.Add("@versionCode", versioncode);
            dictionary.Add("@expDate", expdate);
            return dictionary;
        }

        public Dictionary<String, String> createUpdatePatientPhoneDictionary(String patientId, String phone, String phonetype)
        {
            Dictionary<String, String> dictionary = new Dictionary<string, string>();
            dictionary.Add("@patientId", patientId);
            dictionary.Add("@phoneNo", phone);
            dictionary.Add("@phoneType", phonetype);
            return dictionary;
        }

        public Dictionary<String, String> createUpdatePatientEmailDictionary(String patientId, String email, String emailtype)
        {
            Dictionary<String, String> dictionary = new Dictionary<string, string>();
            dictionary.Add("@patientId", patientId);
            dictionary.Add("@email", email);
            dictionary.Add("@emailType", emailtype); 
            return dictionary;
        }

        public Dictionary<String, String> createUpdatePatientAddressDictionary(String patientId, String addtype, String add, String city, String provience, String postcode, String country)
        {
            Dictionary<String, String> dictionary = new Dictionary<string, string>();
            dictionary.Add("@patientId", patientId.ToString());
            dictionary.Add("@addressType", addtype);
            dictionary.Add("@address", add);
            dictionary.Add("@city", city);
            dictionary.Add("@province", provience);
            dictionary.Add("@postalCode", postcode);
            dictionary.Add("@country", country);
            return dictionary;
        }
        //public Dictionary<String, String> createUpdatePatientAllergyDictionary(String patID, String allergyId, String AlergyName, String AlergyCategory)
        //{
        //    Dictionary<String, String> dictionary = new Dictionary<string, string>();
        //    dictionary.Add("@allergyId", allergyId);
        //    dictionary.Add("@patientId", patID);
        //    dictionary.Add("@name",AlergyName);
        //    dictionary.Add("@category", AlergyCategory);
        //    return dictionary;
        //}

        //public Dictionary<String, String> createUpdatePatientReferalDoctorDictionary(String patId, String ReferenceDoctor, String RefDoctor, String BillingCode)
        //{
        //    Dictionary<String, String> dictionary = new Dictionary<string, string>();

        //    dictionary.Add("@referenceId",ReferenceDoctor);
        //    dictionary.Add("@patientId", patId);
        //    dictionary.Add("@referenceDoctor", RefDoctor);
        //    dictionary.Add("@doctorBillingCode", BillingCode);
        //    //dc.getData("auspUpdateReferenceDoctor", dictionary);
        //    return dictionary;
        //}

        public String checkErrors(string fname, string lname,string insnum, string insversion )
        {
            String errors = null;

            if (fname.Length < 2)
            {
                errors = "Enter valid First name";
                return errors;
            }
            else if (lname.Length < 2)
            {
                errors = "Enter valid Last name";
                return errors;
            }
            else if (insnum.Length != 10)
            {
                errors = "Enter 10 digit Insurance no.";
                return errors;
            }
            else if (insversion.Length != 2)
            {
                errors = "Enter 2 letters Insurance Version no.";
                return errors;
            }
            return errors;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
           String errors = checkErrors(txtFname.Text, txtLname.Text, txtInsNum.Text, txtInsVersion.Text);
           if (errors != null)
           {
               MessageBox.Show(errors);
           }
           else
           {
               dictionary = createUpdatePatientDictionary(patientId.ToString(), txtFname.Text, txtLname.Text, patDob.Text, cmbGender.Text);
               dc.getData("UpdatePatient", dictionary);

               dictionary = createUpdateInsuranceDictionary(patientId.ToString(), txtInsNum.Text, txtInsVersion.Text, txtExpDate.Text);
               dc.getData("UpdateInsurance", dictionary);

               //dictionary = createUpdatePatientEmailDictionary(patientId.ToString(), String allergyId, txtAlergyName, txtAlergyCategory);
               //dc.getData("", dictionary);

               dictionary = createUpdatePatientPhoneDictionary(patientId.ToString(), txtPhone.Text, cmbPhoneType.Text);
               dc.getData("UpdatePatientPhone", dictionary);

               dictionary = createUpdatePatientEmailDictionary(patientId.ToString(), txtEmail.Text, cmbEmailType.Text);
               dc.getData("UpdatePatientEmail", dictionary);

               dictionary = createUpdatePatientAddressDictionary(patientId.ToString(), cmbAddType.Text, txtAdd.Text, txtCity.Text, txtProvince.Text, txtPostalCode.Text, txtCountry.Text);
               dc.getData("UpdatePatientAddress", dictionary);


               MessageBox.Show("Patient Update Successful!!");
               forEdit = false;
               BtnEditDemo.Show();
               enableFields();
               btn_update.Hide();

              

              
           }
            
        }

        private void CreateDemForm_Load(object sender, EventArgs e)
        {
           
            
            dictionary = new Dictionary<string, string>();
            dictionary.Add("@patientId", patientId.ToString());
            
            dc = new DatabaseConnector();
            dtPatient = dc.getData("GetPatient", dictionary);
            dtPatientEmail = dc.getData("GetPatientEmail", dictionary);
            dtPatientAddress = dc.getData("GetPatientAddress", dictionary);
            dtPatientPhone = dc.getData("GetPatientPhone", dictionary);
            dtReferenceDoctor = dc.getData("GetPatientDoctor", dictionary);
            dtAllergy = dc.getData("GetAllery", dictionary);
            dtPatientAddress = dc.getData("GetPatientAddress", dictionary);
            dtInsurance = dc.getData("GetPatientOHIPInsurance", dictionary);
        
            txtLname.Text = dtPatient.Rows[0][2].ToString();
            txtFname.Text = dtPatient.Rows[0][3].ToString();
            string sourceDateTex = dtPatient.Rows[0][4].ToString();
            DateTime dt = Convert.ToDateTime(sourceDateTex);
            sourceDateTex = dt.Year.ToString() + "/" + dt.Month + "/" + dt.Day;
            patDob.Text = sourceDateTex;
            cmbGender.Text = dtPatient.Rows[0][5].ToString();

            txtRefDoctor.Text = dtReferenceDoctor.Rows[0][0].ToString();
            txtBillingCode.Text = dtReferenceDoctor.Rows[0][1].ToString();

            txtAlergyName.Text = dtAllergy.Rows[0][1].ToString();
            txtAlergyCategory.Text = dtAllergy.Rows[0][2].ToString();

            txtInsNum.Text = dtInsurance.Rows[0][2].ToString();
            txtInsVersion.Text = dtInsurance.Rows[0][3].ToString();

            string sourceDateText = dtInsurance.Rows[0][4].ToString(); 
            DateTime dte = Convert.ToDateTime(sourceDateText);
            sourceDateText = dte.Year.ToString() + "/" + dte.Month + "/" + dte.Day;
            txtExpDate.Text = sourceDateText;
          

            cmbAddType.Text=dtPatientAddress.Rows[0][2].ToString();
            txtAdd.Text=dtPatientAddress.Rows[0][3].ToString();
            txtCity.Text = dtPatientAddress.Rows[0][4].ToString();
            txtProvince.Text = dtPatientAddress.Rows[0][5].ToString();
            txtPostalCode.Text = dtPatientAddress.Rows[0][6].ToString();
            txtCountry.Text = dtPatientAddress.Rows[0][7].ToString();

            txtPhone.Text=dtPatientPhone.Rows[0][3].ToString();
            cmbPhoneType.Text = dtPatientPhone.Rows[0][2].ToString();
            
           

            txtEmail.Text = dtPatientEmail.Rows[0][3].ToString();
            cmbEmailType.Text = dtPatientEmail.Rows[0][2].ToString();
           
            

        }

        private void BtnEditDemo_Click(object sender, EventArgs e)
        {
            forEdit = true;
            btn_update.Show();
            BtnEditDemo.Hide();
            enableFields();
        }

        private void enableFields()
        {
            txtInsVersion.Enabled = forEdit;
            txtCity.Enabled = forEdit;
            txtCountry.Enabled = forEdit;
            txtProvince.Enabled = forEdit;
            txtPostalCode.Enabled = forEdit;
            txtAdd.Enabled = forEdit;
            txtAlergyCategory.Enabled = forEdit;
            txtAlergyName.Enabled = forEdit;
            txtBillingCode.Enabled = forEdit;
            txtEmail.Enabled = forEdit;
            txtExpDate.Enabled = forEdit;
            txtFname.Enabled = forEdit;
            txtInsNum.Enabled = forEdit;
            txtLname.Enabled = forEdit;
            txtPhone.Enabled = forEdit;
            txtRefDoctor.Enabled = forEdit;
            cmbAddType.Enabled = forEdit;
            cmbEmailType.Enabled = forEdit;
            cmbGender.Enabled = forEdit;
            cmbPhoneType.Enabled = forEdit;
            btn_update.Enabled = forEdit;
            patDob.Enabled = forEdit;
            txtCity.Enabled = forEdit;
            txtPostalCode.Enabled = forEdit;
            txtProvince.Enabled = forEdit;
        }

       
            
    }
}
