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
using HealthInformaticSystem;
using System.Globalization;
using System.Text.RegularExpressions;


namespace MIMS
{
    public partial class CreateDemForm : Form
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

        public CreateDemForm()
        {
            InitializeComponent();
            enableFields();
            btn_update.Hide();
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CreateDemForm.ActiveForm.Hide();
        }
        public bool IsValidDateTimeTest(string dateTime)
        {
            string[] formats = { "MM/dd/yyyy" };
            DateTime parsedDateTime;
            return DateTime.TryParseExact(dateTime, formats, new CultureInfo("en-US"),
                                           DateTimeStyles.None, out parsedDateTime);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
           bool dob=IsValidDateTimeTest(patDob.Text);
             if (txtFname.Text.Length<2)
            {
                MessageBox.Show("Enter valid First name");
            }else if(txtLname.Text.Length<2)
             {
                 MessageBox.Show("Enter valid Last name");
            }
            else if(dob==false){
            MessageBox.Show("Please enter Date of birth in dd/mm/yyyy format");
            }
                  else if(txtInsNum.Text.Length!=10)
             {
                 MessageBox.Show("Enter 10 digit Insurance no.");
             }
             else if(txtInsVersion.Text.Length!=2)
             {
                 MessageBox.Show("Enter 2 digit Insurance Version no.");
             }
           
            //MessageBox.Show(" "+dob);
            //bool expir=IsValidDateTimeTest(txtExpDate.Text);
            //MessageBox.Show(" " + expir);
            

            
            else
            {
                //dictionary.Add("@allergyId", dtAllergy.Rows[0][0].ToString());
                //dictionary.Add("@patientId", patientId.ToString());
                //dictionary.Add("@name", txtAlergyName.Text);
                //dictionary.Add("@category", txtAlergyCategory.Text);
                //dc.getData("auspUpdateAllergy", dictionary);

                //dictionary = new Dictionary<string, string>();
                //dictionary.Add("@referenceId", dtReferenceDoctor.Rows[0][0].ToString());
                //dictionary.Add("@patientId", patientId.ToString());
                //dictionary.Add("@referenceDoctor", txtRefDoctor.Text);
                //dictionary.Add("@doctorBillingCode", txtBillingCode.Text);
                //dc.getData("auspUpdateReferenceDoctor", dictionary);

                dictionary = new Dictionary<string, string>();
                dictionary.Add("@patientId", patientId.ToString());
                dictionary.Add("@firstName", txtFname.Text);
                dictionary.Add("@lastName", txtLname.Text);
                dictionary.Add("@dob", patDob.Text);
                dictionary.Add("@gender", cmbGender.Text);
                dc.getData("UpdatePatient", dictionary);

                dictionary = new Dictionary<string, string>();
                dictionary.Add("@patientId", patientId.ToString());
                dictionary.Add("@insNumber", txtInsNum.Text);
                dictionary.Add("@versionCode", txtInsVersion.Text);
                dictionary.Add("@expDate", txtExpDate.Text);
                dc.getData("UpdateInsurance", dictionary);

                dictionary = new Dictionary<string, string>();
                dictionary.Add("@patientId", patientId.ToString());
                dictionary.Add("@phoneNo", txtPhone.Text);
                dictionary.Add("@phoneType", cmbPhoneType.Text);
                dc.getData("UpdatePatientPhone", dictionary);

                dictionary = new Dictionary<string, string>();
                dictionary.Add("@patientId", patientId.ToString());
                dictionary.Add("@email", txtEmail.Text);
                dictionary.Add("@emailType", cmbEmailType.Text);
                dc.getData("UpdatePatientEmail", dictionary);

                dictionary = new Dictionary<string, string>();
                dictionary.Add("@patientId", patientId.ToString());
                dictionary.Add("@addressType", cmbAddType.Text);
                dictionary.Add("@address", txtAdd.Text);
                dictionary.Add("@city", txtCity.Text);
                dictionary.Add("@province", txtProvince.Text);
                dictionary.Add("@postalCode", txtPostalCode.Text);
                dictionary.Add("@country", txtCountry.Text);
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
            patDob.Text = dtPatient.Rows[0][4].ToString();
            cmbGender.Text = dtPatient.Rows[0][5].ToString();

            txtRefDoctor.Text = dtReferenceDoctor.Rows[0][0].ToString();
            txtBillingCode.Text = dtReferenceDoctor.Rows[0][1].ToString();

            txtAlergyName.Text = dtAllergy.Rows[0][1].ToString();
            txtAlergyCategory.Text = dtAllergy.Rows[0][2].ToString();

            txtInsNum.Text = dtInsurance.Rows[0][2].ToString();
            txtInsVersion.Text = dtInsurance.Rows[0][3].ToString();
            txtExpDate.Text = dtInsurance.Rows[0][4].ToString();  
          

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
