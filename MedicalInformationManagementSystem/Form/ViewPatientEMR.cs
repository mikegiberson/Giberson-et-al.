using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalInformationManagementSystem.DataSet;
using MedicalInformationManagementSystem.Forms;


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


            dictionary = new Dictionary<string, string>();
            dictionary.Add("@patientId", patId.ToString());
            dc = new DatabaseConnector();
            dtPatient = dc.getData("GetPatient", dictionary);
            label11.Text=dtPatient.Rows[0][0].ToString();
            label13.Text = dtPatient.Rows[0][1].ToString();
            label5.Text = dtPatient.Rows[0][2].ToString();
            label4.Text = dtPatient.Rows[0][3].ToString();
            label8.Text = dtPatient.Rows[0][4].ToString();
            label9.Text = dtPatient.Rows[0][5].ToString(); 
         

        }

       
        private void button5_Click(object sender, EventArgs e)
        {
           MedicalInformationManagementSystem.Forms.PatientAssesment h=new MedicalInformationManagementSystem.Forms.PatientAssesment();
           h.PatientAssesmentPatientId = viewEMRPatientId;
           h.Show();
          
        }

        private void onSortByChange(object sender, EventArgs e)
        {
            if (radioButtonName.Checked == true)
            {
                sortby = 1;
            }
            else if (radioButtonID.Checked == true)
            {
                sortby = 2;
            }
            else if (radioButtonDateAndTime.Checked == true)
            {
                sortby = 3;
            }
            else
            {
                rdName.Checked = true;
                sortby = 1;
            }
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

       
    }
}
