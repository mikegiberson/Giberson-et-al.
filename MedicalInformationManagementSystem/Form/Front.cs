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

    public partial class Front : Form
    {
        private Login login;
        private DoctorSchedule doctorSchedule;
        private SearchPatient searchPatient;
        private ManageStaff manageStaff;

        public int employeeID;
        public string userName;
        public string role;

        public Front()
        {
            InitializeComponent();
            Logout();
        }

        public void Login()
        {
            login.Hide();
            login.Close();

            loginToolStripMenuItem.Visible = false;
            logoutToolStripMenuItem.Visible = true;

            if (role == "Administrator")
            {
                manageStaffToolStripMenuItem.Visible = true;
            }
            else if (role == "Doctor")
            {
                doctorScheduleToolStripMenuItem.Visible = true;
            }
            else
            {
                searchPatientToolStripMenuItem.Visible = true;
            }
        }

        public void Logout()
        {
            employeeID = 0;
            userName = null;
            role = null;

            loginToolStripMenuItem.Visible = true;
            manageStaffToolStripMenuItem.Visible = false;
            doctorScheduleToolStripMenuItem.Visible = false;
            searchPatientToolStripMenuItem.Visible = false;
            logoutToolStripMenuItem.Visible = false;
            
            login = new Login(this);
            login.MdiParent = this;
            login.Show();
        }

        public void ManageStaff()
        {
            manageStaff = new ManageStaff();
            manageStaff.MdiParent = this;
            manageStaff.Show();
        }

        public void DoctorSchedule()
        {
            doctorSchedule = new DoctorSchedule();
            doctorSchedule.MdiParent = this;
            doctorSchedule.Show();
        }

        public void SearchPatient()
        {
            searchPatient = new SearchPatient();
            searchPatient.MdiParent = this;
            searchPatient.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!login.IsDisposed)
            {
                login.Show();
            }
            else
            {
                Logout();
            }
        }

        private void mnuNav_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void doctorScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!doctorSchedule.IsDisposed)
            {
                doctorSchedule.Show();
            }
            else
            {
                DoctorSchedule();
            }
        }

        private void searchPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!searchPatient.IsDisposed)
            {
                searchPatient.Show();
            }
            else
            {
                SearchPatient();
            }
        }

        private void manageStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!manageStaff.IsDisposed)
            {
                manageStaff.Show();
            }
            else
            {
                ManageStaff();
            }
        }
    }
}
