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

        public int employeeID;
        public string userName;
        public string role;

        public Front()
        {
            InitializeComponent();
            login = new Login(this);
            login.MdiParent = this;
            login.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!login.IsDisposed)
            {
                login.Show();
            }
            else
            {
                login = new Login(this);
                login.MdiParent = this;
                login.Show();
            }
        }

        public void CloseLogin()
        {
            login.Hide();
            login.Close();
            
            //mnuNav.Items.Clear();
            loginToolStripMenuItem.Visible = false;

            if (role == "Administrator")
            {
                var manageStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem()
                {
                    Text = "Manage Staff"
                };
                mnuNav.Items.Add(manageStaffToolStripMenuItem);
            }
            else if (role == "Medical Staff")
            {
                var doctorScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem()
                {
                    Text = "Doctor Schedule"
                };
                mnuNav.Items.Add(doctorScheduleToolStripMenuItem);
            }
            else
            {
                var schedulingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem()
                {
                    Text = "Scheduling"
                };
                mnuNav.Items.Add(schedulingToolStripMenuItem);
            }
        }

        private void mnuNav_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
