using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIMS;
using MedicalInformationManagementSystem;

namespace HealthInformaticSystem
{
    public partial class ViewDemography : Form
    {
        public int patientId;
        Dictionary<String, String> dictionary = null;
        DataTable dtPatient = null;
        DataTable dtReferenceDoctor = null;
        DataTable dtAllergy = null;
        DataTable dtPatientEmail = null;
        DataTable dtPatientAddress = null;
        DataTable dtPatientPhone = null;
        DataTable dtInsurance = null;
        DatabaseConnector dc = null;

        public ViewDemography()
        {
            InitializeComponent();

           
        }

        public int test1()
        {
            try
            {
                dtReferenceDoctor = dc.getData("GetPatientDoctor", dictionary);
                int a = int.Parse(dtReferenceDoctor.Rows[0][0].ToString());
                return a;
            }
            catch
            {
                int a = 0;
                return a;

            }
        }

        public int test2()
        {
            try
            {
                dtAllergy = dc.getData("GetAllery", dictionary);
                int a = int.Parse(dtAllergy.Rows[0][0].ToString());
                return a;
            }
            catch
            {
                int a = 0;
                return a;

            }
        }

     
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLastName_TextChanged(object sender, EventArgs e)
        {
            lblLastName.Visible = true;
        }

        private void lblFirstName_TextChanged(object sender, EventArgs e)
        {
            //lblFirstName.Visible = true;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatePatientDemography update = new UpdatePatientDemography();
            update.patientId = this.patientId;
            
            update.Show();
        }

        private void ViewDemography_Load(object sender, EventArgs e)
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

            lblLastName.Text = dtPatient.Rows[0][2].ToString();
            lblFirstName.Text = dtPatient.Rows[0][3].ToString();
            lblDOB.Text = dtPatient.Rows[0][4].ToString();
            lblGender.Text = dtPatient.Rows[0][5].ToString();


            if (test1() != 0)
            {
                lblReferralDoctor.Text = dtReferenceDoctor.Rows[0][2].ToString();
                lblBillingCode.Text = dtReferenceDoctor.Rows[0][1].ToString();
            }

            if (test2() != 0)
            {

                lblAllergyName.Text = dtAllergy.Rows[0][1].ToString();
                lblAllergyCategory.Text = dtAllergy.Rows[0][2].ToString();
            }

            lblInsNo.Text = dtInsurance.Rows[0][2].ToString() + " " + dtInsurance.Rows[0][3].ToString();

            lblExpDate.Text = dtInsurance.Rows[0][4].ToString();


            lblAddressType.Text = dtPatientAddress.Rows[0][2].ToString();
            lblAddress.Text = dtPatientAddress.Rows[0][3].ToString();
            lblCity.Text = dtPatientAddress.Rows[0][4].ToString();
            lblProvince.Text = dtPatientAddress.Rows[0][5].ToString();
            lblPostalCode.Text = dtPatientAddress.Rows[0][6].ToString();


            lblPhone.Text = dtPatientPhone.Rows[0][3].ToString();
            lblPhoneType.Text = dtPatientPhone.Rows[0][2].ToString();



            lblEmail.Text = dtPatientEmail.Rows[0][3].ToString();
            lblEmailType.Text = dtPatientEmail.Rows[0][2].ToString();
            
        }

        private void btnViewEMR_Click(object sender, EventArgs e)
        {
           
                ViewPatientEMR view = new ViewPatientEMR();
                view.viewEMRPatientId =  this.patientId.ToString();

                view.Show();
           
        }

       
    }
}
