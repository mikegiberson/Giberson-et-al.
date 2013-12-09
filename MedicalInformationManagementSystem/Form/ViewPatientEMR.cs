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
    public partial class ViewPatientEMR : Form
    {       
        public String viewEMRPatientId;
        public int patId ;
        public Int16 sortby = 1;
        DataTable dtPatient = null;
        Dictionary<String, String> dictionary = null;
        DatabaseConnector dc = null;

        public ViewPatientEMR()
        {
            InitializeComponent();
            
        }

        private void ViewPatientEMR_Load(object sender, EventArgs e)
        {
            //userControlGetPatientDetails1.mygetPatientId(viewEMRPatientId);
            // TODO: This line of code loads data into the 'gibersonDataSet2.GetAllAllergies' table. You can move, or remove it, as needed.
            //this.getAllAllergiesTableAdapter.Fill(this.gibersonDataSet2.GetAllAllergies);
            // TODO: This line of code loads data into the 'gibersonDataSet.Patient' table. You can move, or remove it, as needed.
            //UserControlGetPatientDetails userControl = new UserControlGetPatientDetails();
            //userControl.usercontrolPatientId=viewEMRPatientId;
            rdId.Hide();
            rdName.Hide();
            rdTime.Hide();
            
            label1.Text = viewEMRPatientId;
            patId = int.Parse(viewEMRPatientId);
            ViewPatientRadiologyGridView.Hide();

            dictionary= createPatientDictionary(patId.ToString());
            dc = new DatabaseConnector();
            dtPatient = createGetPatient(dictionary);
            
            label11.Text=dtPatient.Rows[0][0].ToString();

            String regDate = dtPatient.Rows[0][1].ToString();
            DateTime dte1 = Convert.ToDateTime(regDate);
            registedDate.Text = dte1.Year.ToString() + "-" + dte1.Month + "-" + dte1.Day;
            
            label5.Text = dtPatient.Rows[0][2].ToString();
            label4.Text = dtPatient.Rows[0][3].ToString();

            String sourceDateText = dtPatient.Rows[0][4].ToString();
            DateTime dte = Convert.ToDateTime(sourceDateText);
            sourceDateText = dte.Year.ToString() + "-" + dte.Month + "-" + dte.Day;

            label8.Text = sourceDateText;
            label9.Text = dtPatient.Rows[0][5].ToString(); 
         

        }

        public Dictionary<String, String> createPatientDictionary(String patientAssementId)
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("@patientId", patientAssementId);
            return dic;
        }

        public DataTable createGetPatient(Dictionary<String, String> dic)
        {
            DataTable dTab = dc.getData("GetPatient", dic);
            return dTab;
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
           PatientAssesment h = new PatientAssesment();
           h.PatientAssesmentPatientId = viewEMRPatientId;
           h.Show();
          
        }

        private void onSortByChange(object sender, EventArgs e)
        {
            sortby = getSortBy(radioButtonName.Checked, radioButtonID.Checked, radioButtonDateAndTime.Checked);
            if(sortby==1)
            {
                rdName.Checked = true;
            }
            
        }

        public short getSortBy(Boolean opName, Boolean opId, Boolean opDateAndTime )
        {
            short sortBy = 1;
            if (opName == true)
            {
                sortBy = 1;
            }
            else if (opId == true)
            {
                sortBy = 2;
            }
            else if (opDateAndTime == true)
            {
                sortBy = 3;
            }
            else
            {
                sortBy = 1;
            }
            return sortBy;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView4.Show();
            dataGridView5.Hide();
            dataGridView6.Hide();
            dataGridView7.Hide();
            this.getPatientRadiologyTableAdapter.Fill(dataSetViewPatientRadiology.GetPatientRadiology, patId, sortby);

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView4.Hide();
            dataGridView5.Show();
            dataGridView6.Hide();
            dataGridView7.Hide();
            this.getPatientLaboratoryTableAdapter.Fill(dataSetGetPatientLaboratory.GetPatientLaboratory, patId, sortby);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView4.Hide();
            dataGridView5.Hide();
            dataGridView6.Show();
            dataGridView7.Hide();
            this.getPatientDiagnosisTableAdapter1.Fill(dataSetViewPatientDiagnosis1.GetPatientDiagnosis, patId, sortby);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView4.Hide();
            dataGridView5.Hide();
            dataGridView6.Hide();
            dataGridView7.Show();
            this.getPatientMedicationTableAdapter.Fill(dataSetViewPatientMedication.GetPatientMedication, patId, sortby);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PatientAssesment assesment=new PatientAssesment();
            assesment.PatientAssesmentPatientId = viewEMRPatientId;
            assesment.patid = patId;
            assesment.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            EmrReport er = new EmrReport();
            er.MdiParent = this.MdiParent;
            er.patientId = patId;
            er.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            EnterAssesment a = new EnterAssesment();
            a.MdiParent = this.MdiParent;
            a.patId = this.patId;
            a.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            EnterDaignosis a = new EnterDaignosis();
            a.MdiParent = this.MdiParent;
            a.patId = this.patId;
            a.Show();
        }

       
    }
}
