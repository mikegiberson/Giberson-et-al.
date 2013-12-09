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
    public partial class EmrReport : Form
    {
        public int patientId=0;
        public EmrReport()
        {
            InitializeComponent();
        }

        private void EmrReport_Load(object sender, EventArgs e)
        {
            dataSetPrintLatestEmr.EnforceConstraints = false;
            this.getPatientLatestEmrReportTableAdapter.Fill(dataSetPrintLatestEmr.GetPatientLatestEmrReport, patientId);
            this.reportViewer1.RefreshReport();
           // this.reportViewer2.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        
    }
}
