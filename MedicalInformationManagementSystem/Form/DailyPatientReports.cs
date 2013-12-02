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

    public partial class DailyPatientReports : Form
    {
       public String myDate=null;
        public DailyPatientReports()
        {
            InitializeComponent();
        }

        private void DailyPatientReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dailyReportDataSet.GetDailyPatientsReport' table. You can move, or remove it, as needed.
            this.getDailyPatientsReportTableAdapter.Fill(this.dailyReportDataSet.GetDailyPatientsReport, myDate);

            this.reportViewer1.RefreshReport();
        }
    }
}
