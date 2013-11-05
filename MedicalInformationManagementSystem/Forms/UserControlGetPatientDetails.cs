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

namespace HealthInformaticSystem
{
    public partial class UserControlGetPatientDetails : UserControl
    {
       public int usercontrolPatientId;
       DataTable dtPatient = null;
       Dictionary<String, String> dictionary = null;
       DatabaseConnector dc = null;
        public UserControlGetPatientDetails()
        {
            InitializeComponent();
        }

        private void UserControlGetPatientDetails_Load(object sender, EventArgs e)
        {
             

        }

        public void mygetPatientId(String s)
        {
            dictionary = new Dictionary<string, string>();
            dictionary.Add("@patientId", s);

            dc = new DatabaseConnector();
            dtPatient = dc.getData("GetPatient", dictionary);
            label1.Text = "Dfgsd" + dtPatient.Rows[0][2].ToString();
            label2.Text = dtPatient.Rows[0][3].ToString();
            label3.Text = dtPatient.Rows[0][4].ToString();
            label4.Text = dtPatient.Rows[0][5].ToString(); 
        }
    }
}
