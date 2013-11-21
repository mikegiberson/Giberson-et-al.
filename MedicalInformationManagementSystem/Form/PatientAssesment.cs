using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalInformationManagementSystem
{
    public partial class PatientAssesment : Form
    {
        public String PatientAssesmentPatientId;
        public int patid;
        DataTable dtPatient = null;
        Dictionary<String, String> dictionary = null;
        DatabaseConnector dc = null;
        String MyComboBox;
        public PatientAssesment()
        {
            InitializeComponent();
            
        }

        private void PatientAssesment_Load(object sender, EventArgs e)
        {
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
            dictionary = new Dictionary<string, string>();
            dictionary.Add("@patientId", PatientAssesmentPatientId);
            dc = new DatabaseConnector();
            dtPatient = dc.getData("GetPatient", dictionary);
            label11.Text = dtPatient.Rows[0][0].ToString();
            label13.Text = dtPatient.Rows[0][1].ToString();
            label5.Text = dtPatient.Rows[0][2].ToString();
            label4.Text = dtPatient.Rows[0][3].ToString();
            label8.Text = dtPatient.Rows[0][4].ToString();
            label9.Text = dtPatient.Rows[0][5].ToString();
            textBox1.Enabled = false;
            txt_cheifcomplaint.Enabled = false;

           this.getPatientEMRDatesTableAdapter.Fill(dataSetGetEMRDatesIntoComboBox.GetPatientEMRDates, patid);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            string sourceDateText =  cmbEMRDates.Text;
           DateTime dt = Convert.ToDateTime(sourceDateText);
           sourceDateText = dt.Year.ToString() +"/"+ dt.Month + "/"+ dt.Day;
           MyComboBox = sourceDateText;
            dictionary = new Dictionary<string, string>();
            dictionary.Add("@patientId", PatientAssesmentPatientId);
            

            dictionary.Add("@emrDate", MyComboBox);
            dc = new DatabaseConnector();
            dtPatient = dc.getData("GetPatientEMRAccordingToDate", dictionary);
            textBox1.Text = dtPatient.Rows[0][3].ToString();
            label20.Text = dtPatient.Rows[0][4].ToString() +" mmhg";
            label19.Text = dtPatient.Rows[0][5].ToString()+ " per minute";
            label17.Text = dtPatient.Rows[0][6].ToString() +" per minute";
            label18.Text = dtPatient.Rows[0][7].ToString() + " degree C";
            label16.Text = dtPatient.Rows[0][8].ToString()+ " cms";
            label15.Text = dtPatient.Rows[0][9].ToString() + " pounds";
            label21.Text = dtPatient.Rows[0][10].ToString();
            txt_cheifcomplaint.Text = dtPatient.Rows[0][11].ToString();
        }
    }
}
