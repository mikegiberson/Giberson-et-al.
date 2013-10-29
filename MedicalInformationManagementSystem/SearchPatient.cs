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

namespace HealthInformaticSystem
{
    public partial class SearchPatient : Form
    {
        DatabaseConnector dc = null;
        Dictionary<String, String> dictionary = null;
        DataTable dtPatient = null;

        public SearchPatient()
        {
            InitializeComponent(); 
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dictionary = new Dictionary<string, string>();
            dictionary.Add("@patientId", patientSearch.Text);

            dc = new DatabaseConnector();
            dtPatient = dc.getData("auspCheckPatientExists", dictionary);

            if (int.Parse(dtPatient.Rows[0][0].ToString()) > 0)
            {
                CreateDemForm cd = new CreateDemForm();
                cd.patientId = int.Parse(patientSearch.Text);
                patientSearch.Clear();
                cd.Show();
            }
            else
            {
                MessageBox.Show("Patient does not exist.");
            }

           
        }
    }
}
