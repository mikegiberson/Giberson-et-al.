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
    public partial class ScheduleAppointment : Form
    {
        private DataTable doctors;

        private String PatientID;
        private String FirstName;
        private String LastName;
        
        public ScheduleAppointment(String id, String f, String l)
        {
            InitializeComponent();

            PatientID = id;
            FirstName = f;
            LastName = l;
            lblPatient.Text = f + " " + l;

            String Date = dtpDate.Value.ToString("yyyy-MM-dd");
            getAllDoctors(Date);
        }

        private void getAllDoctors(String Date) {
            Dictionary<String, String> param = new Dictionary<string, string>();
            param.Add("date", Date);
            DatabaseConnector dconn = new DatabaseConnector();
            doctors = dconn.getData("getAllDoctor2", param);

            cmbDoctor.DataSource = doctors;
            cmbDoctor.DisplayMember = "doctorName";
            cmbDoctor.ValueMember = "doctorID";
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            String Date = dtpDate.Value.ToString("yyyy-MM-dd");
            String DoctorID = cmbDoctor.SelectedValue.ToString();
            String DoctorName = cmbDoctor.Text;
            String ScheduleID = doctors.Rows[cmbDoctor.SelectedIndex]["scheduleID"].ToString();

            Dictionary<String, String> param = new Dictionary<string, string>();
            param.Add("scheduleID", ScheduleID);
            param.Add("doctorID", DoctorID);
            param.Add("doctorName", DoctorName);
            param.Add("date", Date);
            param.Add("patientID", PatientID);
            param.Add("lastName", LastName);
            param.Add("firstName", FirstName);
            DatabaseConnector dconn = new DatabaseConnector();
            DataTable result = dconn.getData("addToSchedule", param);

            this.Dispose();
        }
    }
}
