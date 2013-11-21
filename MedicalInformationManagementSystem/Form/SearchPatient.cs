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

using iTextSharp.text;
using iTextSharp.text.pdf;

using System.IO;
using MedicalInformationManagementSystem;


namespace HealthInformaticSystem
{
    public partial class SearchPatient : Form
    {
        DatabaseConnector dc = null;
        Dictionary<String, String> dictionary = null;
        DataTable dtPatient = null;
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

                ViewDemography view = new ViewDemography();
                view.patientId = int.Parse(patientSearch.Text);
                patientSearch.Clear();
                view.Show();


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

       

       
    }
}
