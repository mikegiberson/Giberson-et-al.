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
    public partial class AddEmployee : Form
    {
        private ManageEmployees manageEmployees;

        public AddEmployee(ManageEmployees me)
        {
            InitializeComponent();

            manageEmployees = me;
        }

        private void AddEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            manageEmployees.updateEmployees();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String UserName = txtUser.Text;
            String Password = txtPass.Text;
            String HireDate = dtpHire.Value.ToString("yyyy-MM-dd");
            String Role = "" + cmbRole.SelectedIndex;
            String FirstName = txtFirst.Text;
            String LastName = txtLast.Text;
            String DateOfBirth = dtpDOB.Value.ToString("yyyy-MM-dd");
            String Gender = cmbGender.Text;
            manageEmployees.employees.addEmployee(UserName, Password, HireDate, Role, FirstName, LastName, DateOfBirth, Gender);

            manageEmployees.updateEmployees();
            this.Dispose();
        }
    }
}
