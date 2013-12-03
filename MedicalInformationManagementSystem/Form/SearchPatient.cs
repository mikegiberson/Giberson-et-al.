
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


using System.Text.RegularExpressions;
using HealthInformaticSystem;


namespace MedicalInformationManagementSystem
{
    public partial class SearchPatient : Form
    {
        DatabaseConnector dc = null;
        Dictionary<String, String> dictionary, dictionary2, dictionary4;
        DataTable dtPatient = null;
        DataTable dtReport = null;
        DataTable dtDoctorName = null;
        DataTable dtDoctorID =  null;
        public String _mySearchId;
        public int doctorID;
        string today = System.DateTime.Today.ToShortDateString();

        public SearchPatient()
        {
            InitializeComponent();

            AddtoDoctorList a = new AddtoDoctorList();
            a.dc = new DatabaseConnector();
            dictionary2 = a.createDoctorNameDictionary(today);
            dtDoctorName = a.createGetDoctorName(dictionary2);
            for (int i = 0; i < dtDoctorName.Rows.Count; i++)
                comboBox1.Items.Add(dtDoctorName.Rows[i][0].ToString());
            label1.Text = System.DateTime.Today.ToShortDateString();
                                 
        }

        private void SearchPatient_Load(object sender, EventArgs e)
        {
          
            
        }

        public string mySearchId
        {
            get { return _mySearchId; }
            set { _mySearchId = value; }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _mySearchId = patientSearch.Text;
            dictionary = createCheckPatientExistsDictionary(_mySearchId);
            dc = new DatabaseConnector();
            dtPatient = checkPatientExists(dictionary);

            if (int.Parse(dtPatient.Rows[0][0].ToString()) > 0)
            {

                ViewDemography cd = new ViewDemography();
                cd.patientId = int.Parse(patientSearch.Text);
                patientSearch.Clear();
                cd.Show();
            }
            else
            {
                MessageBox.Show("Patient does not exist.");

                DialogResult result = MessageBox.Show("Create New Patient Demography?", "New Demography", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    this.Hide();
                    CreateDemForm create = new CreateDemForm();

                    create.Show();
                }
            }
        }

        public Dictionary<String, String> createCheckPatientExistsDictionary(String patientAssementId)
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("@patientId", patientAssementId);
            return dic;
        }

        

        public DataTable checkPatientExists(Dictionary<String, String> dic)
        {
            DataTable dTab = dc.getData("CheckPatientExists", dic);
            return dTab;
        }


        public DataTable createDailyReport(Dictionary<String, String> dic)
        {
            DataTable dTab = dc.getData("GetDailyPatientsReport", dic);
            return dTab;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            _mySearchId = patientSearch.Text;
            dictionary = createCheckPatientExistsDictionary(_mySearchId);

            dc = new DatabaseConnector();
            dtPatient = checkPatientExists(dictionary);


            if (int.Parse(dtPatient.Rows[0][0].ToString()) > 0)
            {
                
                ViewPatientEMR view = new ViewPatientEMR();
                view.viewEMRPatientId = patientSearch.Text.ToString();          
                view.Show();
            }
            else
            {
                MessageBox.Show("Patient does not exist.");
            }
       
        }

        private void button2_Click(object sender, EventArgs e)
        {

            dictionary = createCheckPatientExistsDictionary(_mySearchId);

            dc = new DatabaseConnector();
            dtPatient = checkPatientExists(dictionary);

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


        //Include it whenever using this calendar to any other form
        public Dictionary<String, String> createCheckDailyReortExistsDictionary(String selectedDate)
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("@patientId", selectedDate);
            return dic;
        }
        public Dictionary<String, String> createDailyReportDictionary(String selectedDate)
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("@todays", selectedDate);
            return dic;
        }
        
        public DataTable checkDailyReportExists(Dictionary<String, String> dic)
        {
            DataTable dTab = dc.getData("CheckReportExists", dic);
            return dTab;
        }
     
        private void button3_Click(object sender, EventArgs e)
        {
            String todaysDate = dateTimePicker1.Text.ToString();
            dictionary = createCheckDailyReortExistsDictionary(todaysDate);
            dc = new DatabaseConnector();
            dtReport = checkDailyReportExists(dictionary);
            if (int.Parse(dtReport.Rows[0][0].ToString()) > 0)
            {
                dictionary = createDailyReportDictionary(todaysDate);
                dc = new DatabaseConnector();
                dtReport = createDailyReport(dictionary);
                DailyPatientReports dailyReport = new DailyPatientReports();
                dailyReport.myDate = todaysDate;
                dailyReport.Show();

            }
            else
            {
                MessageBox.Show("No Patient was treated on " + todaysDate + "\n Report do not exist!");
            }
            
          
            
          
        }

 

        private void button4_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("No doctor has been selected");
                
            }
            else
            {
                AddtoDoctorList a = new AddtoDoctorList();
                a.dc = new DatabaseConnector();
                dictionary4 = a.createDoctorIDDictionary(comboBox1.SelectedItem.ToString());
                dtDoctorID = a.createGetDoctorID(dictionary4);
                doctorID = int.Parse(dtDoctorID.Rows[0][0].ToString());
                ScheduleList s = new ScheduleList();
                s.doctorID = this.doctorID;
                s.doctorName = comboBox1.SelectedItem.ToString();
                s.Show();
            }
        }

        
    }
}
