using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthInformaticSystem
{
    public partial class ViewPatientEMR : Form
    {
        public String viewEMRPatientId=null;
        public int patId ;
        public ViewPatientEMR()
        {
            InitializeComponent();
        }

        private void ViewPatientEMR_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gibersonDataSet2.GetAllAllergies' table. You can move, or remove it, as needed.
            //this.getAllAllergiesTableAdapter.Fill(this.gibersonDataSet2.GetAllAllergies);
            // TODO: This line of code loads data into the 'gibersonDataSet.Patient' table. You can move, or remove it, as needed.
            label1.Text = viewEMRPatientId;
            patId = int.Parse(viewEMRPatientId);
            UserControlGetPatientDetails usercontrol = new UserControlGetPatientDetails();
            usercontrol.mygetPatientId(patId.ToString());
            //usercontrol.usercontrolPatientId = patId;
            //this.patientTableAdapter.Fill(viewEMRPatientId);

        }

        private void getAllAllergiesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.getPatientRadiologyTableAdapter.Fill(gibersonDataSet4.GetPatientRadiology, patId);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.getPatientLaboratoryTableAdapter.Fill(gibersonDataSet5.GetPatientLaboratory, patId);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.getPatientDiagnosisTableAdapter.Fill(gibersonDataSet8.GetPatientDiagnosis, patId);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.getPatientMedicationTableAdapter.Fill(gibersonDataSet9.GetPatientMedication, patId);
        }
    }
}
