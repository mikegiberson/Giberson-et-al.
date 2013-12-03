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
    public partial class EditEmployee : Form
    {
        private ManageEmployees manageEmployees;
        String employeeID;

        public EditEmployee(int index, ManageEmployees me)
        {
            InitializeComponent();

            manageEmployees = me;

            employeeID = manageEmployees.employees.EmployeeTable.Rows[index]["employeeID"].ToString();
            Dictionary<String, String> r = manageEmployees.employees.getEmployee(employeeID);

            txtUser.Text = r["userName"];
            txtFirst.Text = r["firstName"];
            txtLast.Text = r["lastName"];

            for (int i = 0; i < cmbGender.Items.Count; i++)
            {
                if (object.Equals(cmbGender.Items[i].ToString(), r["gender"]))
                {
                    cmbGender.SelectedIndex = i;
                }
            }

            cmbRole.SelectedIndex = int.Parse(r["role"]);
        }

        private void EditEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            manageEmployees.updateEmployees();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            String UserName = txtUser.Text;
            String Password = txtPass.Text;
            String Role = "" + cmbRole.SelectedIndex;
            String FirstName = txtFirst.Text;
            String LastName = txtLast.Text;
            String Gender = cmbGender.Text;
            manageEmployees.employees.editEmployee(employeeID, UserName, Password, Role, FirstName, LastName, Gender);

            manageEmployees.updateEmployees();
            this.Dispose();
        }
    }
}
