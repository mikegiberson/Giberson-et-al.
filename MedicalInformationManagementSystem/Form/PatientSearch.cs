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
    public partial class PatientSearch : Form
    {
       /* DatabaseConnector dc = null;
        Dictionary<String, String> dictionary = null;
        DataTable dtPatient = null;*/

        DatabaseConnector dc = null;
        Dictionary<String, String> dictionary, dictionary2, dictionary4;
        DataTable dtPatient = null;
        DataTable dtReport = null;
        DataTable dtDoctorName = null;
        DataTable dtDoctorID = null;
        public String _mySearchId;
        public int doctorID;
        string today = System.DateTime.Today.ToShortDateString();

        
        public PatientSearch()
        {
            InitializeComponent();
            AddtoDoctorList a = new AddtoDoctorList();
            a.dc = new DatabaseConnector();
            dictionary2 = a.createDoctorNameDictionary(today);
            dtDoctorName = a.createGetDoctorName(dictionary2);
            for (int i = 0; i < dtDoctorName.Rows.Count; i++)
                comboBox1.Items.Add(dtDoctorName.Rows[i][0].ToString());
        }

        public Dictionary<String, String> createCheckPatientExistsDictionary(String patientAssementId)
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("@patientId", patientAssementId);
            return dic;
        }



        public DataTable checkPatientExists(Dictionary<String, String> dic)
        {
            DataTable dTab = dc.getData("CheckPatientExists", dic);
            return dTab;
        }


        public DataTable createDailyReport(Dictionary<String, String> dic)
        {
            DataTable dTab = dc.getData("GetDailyPatientsReport", dic);
            return dTab;
        }

        public Dictionary<String, String> createCheckDailyReortExistsDictionary(String selectedDate)
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("@myDate", selectedDate);
            return dic;
        }
        public Dictionary<String, String> createDailyReportDictionary(String selectedDate)
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("@todays", selectedDate);
            return dic;
        }

        public DataTable checkDailyReportExists(Dictionary<String, String> dic)
        {
            DataTable dTab = dc.getData("CheckReportExists", dic);
            return dTab;
        }


        private void btn_SearchPatient_Click(object sender, EventArgs e)
        {

            dictionary = new Dictionary<string, string>();
            dc = new DatabaseConnector();

            if (txt_Output.Text != "")
            {
                bool temp = false;
                int temp1;
                try
                {
                    temp1 = Convert.ToInt32(txt_Output.Text);
                    temp = true;
                }
                catch (Exception ex)
                {
                    temp = false;
                }
                if (cm_Options.SelectedIndex == 1 && temp == true)
                {
                    dictionary.Add("@patientId", txt_Output.Text);
                    dtPatient = dc.getData("CheckPatientExists", dictionary);

                    if (int.Parse(dtPatient.Rows[0][0].ToString()) != 0 )
                    {
                        dataGridView2.Hide();
                        dataGridView1.Show();
                        this.getPatientByIdTableAdapter.Fill(getPatientByIdDataSet.GetPatientById, txt_Output.Text);
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
                else if (cm_Options.SelectedIndex == 2)
                {
                    dictionary.Add("@patientName", txt_Output.Text);
                    dtPatient = dc.getData("CheckPatientExistsByName", dictionary);
                    if (dtPatient.Rows.Count != 0)
                    {
                        dataGridView1.Hide();
                        dataGridView2.Show();
                        this.getPatientByNameTableAdapter.Fill(getPatientByNameDataSet.GetPatientByName, txt_Output.Text.ToString());


                    }
                    else
                    {
                        MessageBox.Show("Patient does not exist.");
                        DialogResult result = MessageBox.Show("Create New Patient Demography?", "New Demography", MessageBoxButtons.OKCancel,
                         MessageBoxIcon.Question);

                        if (result == DialogResult.OK)
                        {
                            
                            CreateDemForm create = new CreateDemForm();
                            create.Show();

                        }
                    }


                }
                else
                {
                    MessageBox.Show("Please proper search text!");
                    txt_Output.Focus();
                }
            }
        }

    

        
        private void PatientSearch_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            dataGridView2.Hide();
            btn_SearchPatient.Enabled = false;

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cm_Options_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cm_Options.SelectedIndex == 1 || cm_Options.SelectedIndex == 2)
            {
                btn_SearchPatient.Enabled = true;
                txt_Output.Text = "";
                txt_Output.Focus();

            }
            else
            {
                btn_SearchPatient.Enabled = false;
                txt_Output.Text = "";
                DialogResult result = MessageBox.Show("Create New Patient Demography?", "New Demography", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);
            }

        }
        private void dataGridView2_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int rowindex = dataGridView2.CurrentCell.RowIndex;
                int columnindex=  dataGridView2.CurrentCell.ColumnIndex;

                _mySearchId = dataGridView2.Rows[rowindex].Cells[columnindex].Value.ToString();
               
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                int columnindex = dataGridView1.CurrentCell.ColumnIndex;

                _mySearchId = dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString();
               
            }
        }

        private void btnSelect_Click_1(object sender, EventArgs e)
        {
            ViewDemography cd = new ViewDemography();
            cd.patientId = int.Parse(_mySearchId);

            cd.Show();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CreateDemForm create = new CreateDemForm();

            create.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewPatientEMR view = new ViewPatientEMR();
            view.viewEMRPatientId = _mySearchId;
            view.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmrReport repo = new EmrReport();
            repo.patientId = int.Parse(_mySearchId);
            repo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String todaysDate = dateTimePicker1.Text.ToString();
            dictionary = createCheckDailyReortExistsDictionary(todaysDate);
            dc = new DatabaseConnector();
            dtReport = checkDailyReportExists(dictionary);
            if (int.Parse(dtReport.Rows[0][0].ToString()) > 0)
            {
                dictionary = createDailyReportDictionary(todaysDate);
                dc = new DatabaseConnector();
                dtReport = createDailyReport(dictionary);
                DailyPatientReports dailyReport = new DailyPatientReports();
                dailyReport.myDate = todaysDate;
                dailyReport.Show();

            }
            else
            {
                MessageBox.Show("No Patient was treated on " + todaysDate + "\n Report do not exist!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("No doctor has been selected");

            }
            else
            {
                AddtoDoctorList a = new AddtoDoctorList();
                a.dc = new DatabaseConnector();
                dictionary4 = a.createDoctorIDDictionary(comboBox1.SelectedItem.ToString());
                dtDoctorID = a.createGetDoctorID(dictionary4);
                doctorID = int.Parse(dtDoctorID.Rows[0][0].ToString());
                ScheduleList s = new ScheduleList();
                s.doctorID = this.doctorID;
                s.doctorName = comboBox1.SelectedItem.ToString();
                s.Show();
            }
        }

        
    }
}
