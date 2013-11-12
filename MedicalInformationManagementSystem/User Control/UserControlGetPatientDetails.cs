using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace MedicalInformationManagementSystem
{
    public partial class UserControlGetPatientDetails : UserControl
    {
       //public string usercontrolPatientId;
       public string usercontrolPatientId { get; set; }
       DataTable dtPatient = null;
       Dictionary<String, String> dictionary = null;
       DatabaseConnector dc = null;
       
        public UserControlGetPatientDetails()
        {
            InitializeComponent();
        }

        private void UserControlGetPatientDetails_Load(object sender, EventArgs e)
        {
            //SearchPatient ss = new SearchPatient();
            //usercontrolPatientId = ss._mySearchId;

            dictionary = new Dictionary<string, string>();
            //dictionary.Add("@patientId", usercontrolPatientId);
            dictionary.Add("@patientId", "1");
            dc = new DatabaseConnector();
            dtPatient = dc.getData("GetPatient", dictionary);
            label1.Text = "Dfgsd" + dtPatient.Rows[0][2].ToString();
            label2.Text = dtPatient.Rows[0][3].ToString();
            label3.Text = dtPatient.Rows[0][4].ToString();
            label4.Text = dtPatient.Rows[0][5].ToString(); 

        }

        public void mygetPatientId(String s)
        {
            usercontrolPatientId = s;
        }
    }
}
