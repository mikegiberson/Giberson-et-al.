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


namespace MIMS
{
    public partial class CreateDemForm : Form
    {
        public Boolean forEdit = false;
        public int patientId = 1;
        DataTable dtPatient = null;
        DataTable dtReferenceDoctor = null;
        DataTable dtAllergy = null;
        DataTable dtPatientContact = null;
        DataTable dtInsurance = null;
        DatabaseConnector dc = null;
        Dictionary<String, String> dictionary = null;

        public CreateDemForm()
        {
            InitializeComponent();
            comboBox1.Hide();
            comboBox2.Hide();
            enableFields();
            btn_update.Hide();
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CreateDemForm.ActiveForm.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            dictionary = new Dictionary<string, string>();
            dictionary.Add("@allergyId", dtAllergy.Rows[0][0].ToString());
            dictionary.Add("@patientId", patientId.ToString());
            dictionary.Add("@name", txtAlergyName.Text);
            dictionary.Add("@category", txtAlergyCategory.Text);
            dc.getData("auspUpdateAllergy", dictionary);

            dictionary = new Dictionary<string, string>();
            dictionary.Add("@referenceId", dtReferenceDoctor.Rows[0][0].ToString());
            dictionary.Add("@patientId", patientId.ToString());
            dictionary.Add("@referenceDoctor", txtRefDoctor.Text);
            dictionary.Add("@doctorBillingCode", txtBillingCode.Text);
            dc.getData("auspUpdateReferenceDoctor", dictionary);

            dictionary = new Dictionary<string, string>();
            dictionary.Add("@patientId", patientId.ToString());
            dictionary.Add("@firstName", txtFname.Text);
            dictionary.Add("@lastName", txtLname.Text);
            dictionary.Add("@dob", patDob.Text);
            dictionary.Add("@gender",cmbGender.SelectedIndex.ToString());
            dc.getData("auspUpdatePatient", dictionary);

            dictionary = new Dictionary<string, string>();
            dictionary.Add("@insuranceId",dtInsurance.Rows[0][0].ToString());
            dictionary.Add("@patientId", patientId.ToString());
            dictionary.Add("@type", cmbInsType.SelectedIndex.ToString());
            dictionary.Add("@insNumber", txtInsNum.Text);
            dictionary.Add("@expDate",txtExpDate.Text);
            dc.getData("auspUpdateInsurance", dictionary);

            dictionary = new Dictionary<string, string>();
            dictionary.Add("@patientId", patientId.ToString());
            dictionary.Add("@phoneNo", txtPhone.Text);
            dictionary.Add("@phoneType", cmbPhoneType.SelectedIndex.ToString());
            dictionary.Add("@email", txtEmail.Text);
            dictionary.Add("@emailType",cmbEmailType.SelectedIndex.ToString());
            dictionary.Add("@address", txtAdd.Text);
            dictionary.Add("@addressType", cmbAddType.SelectedIndex.ToString());
            dc.getData("auspUpdatePatientContact", dictionary);

            MessageBox.Show("Patient Update Successful!!");
            forEdit = false;
            BtnEditDemo.Show();
            enableFields();
            btn_update.Hide();
            
        }

        private void CreateDemForm_Load(object sender, EventArgs e)
        {
            dictionary = new Dictionary<string, string>();
            dictionary.Add("@patientId", patientId.ToString());
            
            dc = new DatabaseConnector();
            dtPatient = dc.getData("auspGetPatient", dictionary);
            dtReferenceDoctor = dc.getData("auspGetReferenceDoctor", dictionary);
            dtAllergy = dc.getData("auspGetAllery", dictionary);
            dtPatientContact = dc.getData("auspGetPatientContact", dictionary);
            dtInsurance = dc.getData("auspGetInsurance", dictionary);

            txtLname.Text = dtPatient.Rows[0][1].ToString();
            txtFname.Text = dtPatient.Rows[0][2].ToString();
            patDob.Text = dtPatient.Rows[0][3].ToString();
            cmbGender.SelectedIndex = int.Parse(dtPatient.Rows[0][4].ToString());

            txtRefDoctor.Text = dtReferenceDoctor.Rows[0][2].ToString();
            txtBillingCode.Text = dtReferenceDoctor.Rows[0][3].ToString();

            txtAlergyName.Text = dtAllergy.Rows[0][2].ToString();
            txtAlergyCategory.Text = dtAllergy.Rows[0][3].ToString();

            txtInsNum.Text = dtInsurance.Rows[0][3].ToString();
            txtExpDate.Text = dtInsurance.Rows[0][4].ToString();  
            cmbInsType.SelectedIndex=int.Parse(dtInsurance.Rows[0][2].ToString());

            txtPhone.Text=dtPatientContact.Rows[0][2].ToString();
            cmbPhoneType.SelectedIndex = int.Parse(dtPatientContact.Rows[0][3].ToString());
            txtEmail.Text=dtPatientContact.Rows[0][4].ToString();
            txtAdd.Text = dtPatientContact.Rows[0][6].ToString();
            cmbAddType.SelectedIndex = int.Parse(dtPatientContact.Rows[0][7].ToString());
            cmbEmailType.SelectedIndex = int.Parse(dtPatientContact.Rows[0][5].ToString());
           
            

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
            cmbInsType.Enabled = forEdit;
            cmbPhoneType.Enabled = forEdit;
            btn_update.Enabled = forEdit;
            patDob.Enabled = forEdit;
        }
            
    }
}
