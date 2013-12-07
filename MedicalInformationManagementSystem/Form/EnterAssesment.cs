using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalInformationManagementSystem
{
    public partial class EnterAssesment : Form
    {
        Dictionary<String, String> dictionary = null;
        Dictionary<String, String> dic = null;
        DatabaseConnector dc = null;
        public int patId ;
        public int docId = 0;
        DataTable dtPatient = null;
        DataTable dtEMR = null;
        DataTable dtDoctor = null;
        public EnterAssesment()
        {
            InitializeComponent();
        }

        private void EnterAssesment_Load(object sender, EventArgs e)
        {
            dc = new DatabaseConnector();
            dictionary = new Dictionary<string, string>();
            // patId = int.Parse();
            dictionary.Add("@patientId", patId.ToString());
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
            


        }
      
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {

                dc = new DatabaseConnector();
                DateTime d = DateTime.Today;
                dic = new Dictionary<string, string>();
                dic.Add("@patientId", patId.ToString());
                dtDoctor = dc.getData("try1", dic);
                docId = int.Parse(dtDoctor.Rows[0][0].ToString());

                dictionary = new Dictionary<string, string>();
                dictionary.Add("@patientId", patId.ToString());
                dictionary.Add("@doctorId", docId.ToString());
                dictionary.Add("@timestamp", d.ToShortDateString());// if you need date time please convert d.ToString()  
                //d.ToShortDateString()
                //dictionary.Add("@patientId", patientId.ToString());
                dictionary.Add("@blooppressure", txt_Bp.Text);
                dictionary.Add("@respiratoryrate", txt_Rr.Text);
                dictionary.Add("@pulserate ", txt_Pr.Text);
                dictionary.Add("@temperature", txt_temp.Text);
                dictionary.Add("@height", txt_Height.Text);
                dictionary.Add("@weight", txt_Weight.Text);
                dictionary.Add("@painscale", txt_PainScale.Text);
                dictionary.Add("@clinicalimpression", txt_Clinical.Text);
                dictionary.Add("@chiefcomplaint", txt_cheifcomplaint.Text);
                dc.getData("EnterAssesment", dictionary);


                MessageBox.Show("Record Saved Successfully");
            }
            catch
            {
                MessageBox.Show("Failed to save record please check if the patient is already been assessed");
            }
        }

        private void btnEnterMedication_Click(object sender, EventArgs e)
        {
            EnterDaignosis ed = new EnterDaignosis();
            this.Hide();
            ed.Show();
        }
    }
}
