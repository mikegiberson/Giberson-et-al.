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
       public  DataTable dtPatient = null;
       public  Dictionary<String, String> dictionary = null;
       public  DatabaseConnector dc = null;
       public  String MyComboBox;
        public PatientAssesment()
        {
            InitializeComponent();
            
        }

        public void clearData()
        {
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
        }

        public Dictionary<string, string> createGetPatientDictionary(string PatientAssesmentPatientId)
        {
            Dictionary<string, string>  dict = new Dictionary<string, string>();
            dict.Add("@patientId", PatientAssesmentPatientId);
            return dict;
        }

        private void PatientAssesment_Load(object sender, EventArgs e)
        {
            
            DatabaseConnector dc = new DatabaseConnector();
            dictionary = createGetPatientDictionary(PatientAssesmentPatientId);
            dtPatient = dc.getData("GetPatient", dictionary);
            label11.Text = dtPatient.Rows[0][0].ToString();

            String regDate = dtPatient.Rows[0][1].ToString();
            DateTime dte1 = Convert.ToDateTime(regDate);
            label13.Text = dte1.Year.ToString() + "-" + dte1.Month + "-" + dte1.Day;
           
            label5.Text = dtPatient.Rows[0][2].ToString();
            label4.Text = dtPatient.Rows[0][3].ToString();

            String dob = dtPatient.Rows[0][4].ToString();
            DateTime dte2 = Convert.ToDateTime(dob);
            label8.Text = dte2.Year.ToString() + "-" + dte2.Month + "-" + dte2.Day;

            label9.Text = dtPatient.Rows[0][5].ToString();
            textBox1.Enabled = false;
            txt_cheifcomplaint.Enabled = false;

           this.getPatientEMRDatesTableAdapter.Fill(dataSetGetEMRDatesIntoComboBox.GetPatientEMRDates, patid);
        }
        public string formatDate(DateTime dt)
        {
            String str = dt.Year.ToString() + "/" + dt.Month + "/" + dt.Day;
            return str;
        }
        public DataTable getPatientEMRAccordingToDate(Dictionary<String, String> dict, DatabaseConnector conn)
        {
            DataTable dataTable;
            dataTable= conn.getData("GetPatientEMRAccordingToDate", dict);
            return dataTable;
        }

        public Dictionary<String, String> createEmrRequest(String patientAssementId, String emrDate)
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("@patientId", patientAssementId);
            dic.Add("@emrDate", emrDate);
            return dic;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            dictionary = createEmrRequest(PatientAssesmentPatientId,formatDate(Convert.ToDateTime(cmbEMRDates.Text)));
            dc = new DatabaseConnector();
            dtPatient = getPatientEMRAccordingToDate(dictionary,dc);
            
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
