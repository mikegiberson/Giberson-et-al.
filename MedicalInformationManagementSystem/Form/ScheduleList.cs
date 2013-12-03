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
    public partial class ScheduleList : Form
    {
        public int doctorID;
        public string doctorName;
        DataTable dtSchedule = null;
        Dictionary<String, String> dictionary;
        DatabaseConnector dc = null;
        string today = System.DateTime.Today.ToShortDateString();

        public ScheduleList()
        {
            InitializeComponent();
        }

        private void ScheduleList_Load(object sender, EventArgs e)
        {
            lblDoctorID.Text = doctorID.ToString();
            lblDoctorName.Text = doctorName;

            dc = new DatabaseConnector();

            dictionary = createDoctorDayScheduleDictionary(today, doctorID.ToString());
            dtSchedule = createGetDoctorDaySchedule(dictionary);

    
 
     dataGridView1.DataSource = dtSchedule;

           
        }

        public Dictionary<String, String> createDoctorDayScheduleDictionary(String today, String doctorID)
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("@date", today);
            dic.Add("@doctorID", doctorID);
            return dic;
        }

        public DataTable createGetDoctorDaySchedule(Dictionary<String, String> dic)
        {
            DataTable dTab = dc.getData("GetDoctorDaySchedule", dic);
            return dTab;
        }
    }
}
