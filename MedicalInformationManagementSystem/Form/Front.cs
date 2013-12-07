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
        public User user;
        public Login login;
        public ManageEmployees manageEmployees;
        public SearchPatient searchPatient;
        public PatientSearch patientSearch;
        
        public Front()
        {
            InitializeComponent();

            user = new User();
            Login();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void administratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (manageEmployees == null || manageEmployees.IsDisposed)
            {
                manageEmployees = new ManageEmployees();
                manageEmployees.MdiParent = this;
            }
            manageEmployees.Show();
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (patientSearch == null || patientSearch.IsDisposed)
            {
                patientSearch = new PatientSearch();
                patientSearch.MdiParent = this;
            }
            patientSearch.Show();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (patientSearch == null || patientSearch.IsDisposed)
            {
                patientSearch = new PatientSearch();
                patientSearch.MdiParent = this;
            }
            patientSearch.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this might be buggy
            FormCollection FC = Application.OpenForms;
            int i = 0;
            while (FC.Count > 1)
            {
                if (FC[i].Name != "Front")
                {
                    FC[i].Dispose();
                }
                else
                {
                    i++;
                }
            }

            user.Logout();
            setRole();
            Login();
        }

        private void Login()
        {
            if (login == null || login.IsDisposed)
            {
                login = new Login(this, user);
                login.MdiParent = this;
            }
            login.Show();
        }

        public void setRole()
        {
            if (user.Role != null)
            {
                loginToolStripMenuItem.Visible = false; 
                switch (user.Role)
                {
                    case 0:
                        administratorToolStripMenuItem.Visible = true;
                        break;
                    case 1:
                        doctorToolStripMenuItem.Visible = true;
                        break;
                    case 2:
                        staffToolStripMenuItem.Visible = true;
                        break;
                }
                logoutToolStripMenuItem.Visible = true;
            }
            else
            {
                loginToolStripMenuItem.Visible = true;
                administratorToolStripMenuItem.Visible = false;
                doctorToolStripMenuItem.Visible = false;
                staffToolStripMenuItem.Visible = false;
                logoutToolStripMenuItem.Visible = false;
            }
        }
    }
}
