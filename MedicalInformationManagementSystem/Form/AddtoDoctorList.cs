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

namespace MedicalInformationManagementSystem
{
    public partial class AddtoDoctorList : Form
    {
        public int patientID, doctorID, scheduleID;
        DataTable dtPatient, dtDoctorName, dtDoctorID, dtScheduleID, dtInsert;
        public string today = System.DateTime.Today.ToShortDateString();
        
        Dictionary<String, String> dictionary1, dictionary2, dictionary3, dictionary4, dictionary5;
       public DatabaseConnector dc = null;
        
        public AddtoDoctorList()
        {
            InitializeComponent();

        }

        private void AddtoDoctorList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetGetAllDoctor.GetAllDoctor' table. You can move, or remove it, as needed.
            dc = new DatabaseConnector();
           
            dictionary1 = createPatientDictionary(patientID.ToString());
            dictionary2 = createDoctorNameDictionary(today);
            
            
            
            dtPatient = createGetPatient(dictionary1);
            dtDoctorName = createGetDoctorName(dictionary2);

          
        


            lblPatientID.Text = dtPatient.Rows[0][0].ToString();
            lblRegistedDate.Text = dtPatient.Rows[0][1].ToString();
            lblLName.Text = dtPatient.Rows[0][2].ToString();
            lblFName.Text = dtPatient.Rows[0][3].ToString();
            lblDOB.Text = dtPatient.Rows[0][4].ToString();
            lblGender.Text = dtPatient.Rows[0][5].ToString();

            label1.Text = "Date: " + System.DateTime.Today.ToShortDateString();

           for (int i = 0; i < dtDoctorName.Rows.Count; i++)
           comboBox1.Items.Add(dtDoctorName.Rows[i][0].ToString());

            
            


        }

        public Dictionary<String, String> createPatientDictionary(String patientId)
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("@patientId", patientId);
            return dic;
        }

        public Dictionary<String, String> createDoctorNameDictionary(string date)
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("@date",date);
            return dic;
        }

        public Dictionary<String, String> createScheduleDictionary(string doctorID, string date)
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("@doctorID", doctorID);
            dic.Add("@date", date);
            return dic;
        }

        public Dictionary<String, String> createDoctorIDDictionary(string name)
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("@name", name);
            return dic;
        }


        public Dictionary<String, String> createDayScheduleDictionary(string scheduleID, String date, String doctorID, String doctorName, String patientID, string lastName, string firstName)
        {
            Dictionary<String, String> dictionary = new Dictionary<string, string>();
            dictionary.Add("@scheduleID", scheduleID);
            dictionary.Add("@today", date);
            dictionary.Add("@doctorID", doctorID);
            dictionary.Add("@doctorName", doctorName);
            dictionary.Add("@patientID", patientID);
            dictionary.Add("@lastName", lastName);
            dictionary.Add("@firstName", firstName);
            return dictionary;
        }

        public DataTable createGetPatient(Dictionary<String, String> dic)
        {
            DataTable dTab = dc.getData("GetPatient", dic);
            return dTab;
        }

        public DataTable createGetDoctorName(Dictionary<String, String> dic)
        {
            DataTable dt = dc.getData("GetAllDoctor", dic);
            return dt;
        }

        public DataTable createGetDoctorID(Dictionary<String, String> dic)
        {
            DataTable dt = dc.getData("GetDoctorID2", dic);
            return dt;
        }

        public DataTable createGetSchedule(Dictionary<String, String> dic)
        {
            DataTable dTab = dc.getData("GetScheduleID", dic);
            return dTab;
        }

        public DataTable createDaySchedule(Dictionary<String, String> dic)
        {
            DataTable dt = dc.getData("InsertIntoDaySchedule", dic);
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("No doctor has been selected");
               
            }
            else
            {
                
                dictionary4 = createDoctorIDDictionary(comboBox1.SelectedItem.ToString());
                dtDoctorID = createGetDoctorID(dictionary4);
                doctorID = int.Parse( dtDoctorID.Rows[0][0].ToString());
                

                dictionary3 = createScheduleDictionary(this.doctorID.ToString(), today);
                dtScheduleID = createGetSchedule(dictionary3);
                scheduleID = int.Parse(dtScheduleID.Rows[0][0].ToString());
                

                dictionary5 = createDayScheduleDictionary(this.scheduleID.ToString(), today, this.doctorID.ToString(), comboBox1.SelectedItem.ToString(), this.patientID.ToString(), lblLName.Text, lblFName.Text);
                dtInsert = createDaySchedule(dictionary5);

                ScheduleList s = new ScheduleList();
                s.doctorID = this.doctorID;
                s.doctorName = comboBox1.SelectedItem.ToString();
                s.Show();

            }

        }

        
    }
}
