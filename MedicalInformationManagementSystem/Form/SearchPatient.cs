using MIMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalInformationManagementSystem.Reports;
using MedicalInformationManagementSystem.Forms;
using System.Text.RegularExpressions;


namespace MedicalInformationManagementSystem
{
    public partial class SearchPatient : Form
    {
        DatabaseConnector dc = null;
        Dictionary<String, String> dictionary = null;
        DataTable dtPatient = null;
        DataTable dtReport = null;
        public String _mySearchId;
       

        public SearchPatient()
        {
            InitializeComponent();
            //_mySearchId = "1";
            
        }

        public string mySearchId
        {
            get { return _mySearchId; }
            set { _mySearchId = value; }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dictionary = new Dictionary<string, string>();
            dictionary.Add("@patientId", patientSearch.Text);

            dc = new DatabaseConnector();
            dtPatient = dc.getData("CheckPatientExists", dictionary);

            if (int.Parse(dtPatient.Rows[0][0].ToString()) > 0)
            {
               
                UpdatePatientDemography cd = new UpdatePatientDemography();
                cd.patientId = int.Parse(patientSearch.Text);
                patientSearch.Clear();
                cd.Show();
            }
            else
            {
                MessageBox.Show("Patient does not exist.");
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _mySearchId = patientSearch.Text;
            dictionary = new Dictionary<string, string>();
            dictionary.Add("@patientId", patientSearch.Text);

            dc = new DatabaseConnector();
            dtPatient = dc.getData("CheckPatientExists", dictionary);


            if (int.Parse(dtPatient.Rows[0][0].ToString()) > 0)
            {
                
                ViewPatientEMR view = new ViewPatientEMR();
                view.viewEMRPatientId = patientSearch.Text.ToString();
                
                //UserControlGetPatientDetails userControl = new UserControlGetPatientDetails();
                //userControl.usercontrolPatientId = view.viewEMRPatientId;

                
                view.Show();
            }
            else
            {
                MessageBox.Show("Patient does not exist.");
            }
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            dictionary = new Dictionary<string, string>();
            dictionary.Add("@patientId", patientSearch.Text);

            dc = new DatabaseConnector();
            dtPatient = dc.getData("CheckPatientExists", dictionary);

            if (int.Parse(dtPatient.Rows[0][0].ToString()) > 0)
            {
                int checkPat = int.Parse(patientSearch.Text);
                EmrReport repo = new EmrReport();
                repo.patientId = checkPat;
                repo.Show();
            }
            else
            {
                MessageBox.Show("Patient does not exist.");
            }
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String todaysDate = dateTimePicker1.Text.ToString();

            dictionary = new Dictionary<string, string>();
            dictionary.Add("@myDate", todaysDate);

            dc = new DatabaseConnector();
            dtReport = dc.getData("CheckReportExists", dictionary);

            if (int.Parse(dtReport.Rows[0][0].ToString()) > 0)
            {
                DailyPatientReports dailyReport = new DailyPatientReports();
                dailyReport.myDate = todaysDate;
                dailyReport.Show();
               
            }
            else
            {
                MessageBox.Show("No Patient was treated on "+ todaysDate +"\n Report do not exist!");
            }
            
          
            
          
        }

        private void SearchPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
