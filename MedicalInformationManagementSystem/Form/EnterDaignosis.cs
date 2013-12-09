using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalInformationManagementSystem
{
    public partial class EnterDaignosis : Form
    {
        public int patId ;
        int docID;
        
        public EnterDaignosis()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            Dictionary<String, String> dict = new Dictionary<string, string>();
            dict.Add("@patientID", patId.ToString());

            DatabaseConnector dc = new DatabaseConnector();

            DataTable dtPatient = dc.getData("try1", dict);

           docID = int.Parse(dtPatient.Rows[0][0].ToString());
            
            String myDiag = comboBox1.Text;


            
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("@diagnosisId", myDiag);
            dic.Add("@patId", patId.ToString());


            //string fromFormat = "yyyy/mm/dd";
         

            //DateTime newDate = DateTime.ParseExact(System.DateTime.Today.ToShortDateString(), fromFormat, null);
                                           ;
            string[] formats = { "MM/dd/yyyy" };
            DateTime parsedDateTime;
            DateTime.TryParseExact(System.DateTime.Today.ToShortDateString(), formats, new CultureInfo("en-US"),
                                                                          DateTimeStyles.None, out parsedDateTime);
            dic.Add("@myTodays", "2012/12/12");
            dic.Add("@docId", docID.ToString());


            dc.getData("SaveEMRDaignosis", dic);

            
        }

      
       

        private void EnterDaignosis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'getDaignosisToComboBoxDataSet.GetDiagnosisIntoCombobox' table. You can move, or remove it, as needed.
            this.getDiagnosisIntoComboboxTableAdapter.Fill(this.getDaignosisToComboBoxDataSet.GetDiagnosisIntoCombobox);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String myDiag=comboBox1.Text;
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("@myDaignosisName", myDiag);
             
           DatabaseConnector dc = new DatabaseConnector();

           DataTable dtPatient = dc.getData("GetDaignosisDescription", dic);

           if (dtPatient.Rows.Count > 0)
           {
               txt_DiagnosisDescription.Text = dtPatient.Rows[0][0].ToString();
           }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
