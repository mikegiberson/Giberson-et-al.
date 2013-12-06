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
    public partial class ManageEmployees : Form
    {
        public Employees employees;
        AddEmployee add;
        EditEmployee edit;

        bool flag;
        
        public ManageEmployees()
        {
            InitializeComponent();

            employees = new Employees();
            dgvUsers.DataSource = employees.EmployeeTable;

            flag = true;
        }

        public void updateEmployees()
        {
            employees.getEmployees();
            dgvUsers.DataSource = employees.EmployeeTable;
            flag = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (flag && dgvUsers.SelectedRows.Count == 1)
            {
                int index = dgvUsers.SelectedRows[0].Index;

                String employeeID = employees.EmployeeTable.Rows[index]["employeeID"].ToString();
                if (employeeID != "" + User.ID)
                {
                    String firstName = employees.EmployeeTable.Rows[index]["firstName"].ToString();
                    String lastName = employees.EmployeeTable.Rows[index]["lastName"].ToString();

                    flag = false;
                    DialogResult r = MessageBox.Show("Do you wish to delete " + firstName + " " + lastName + "?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (r == DialogResult.Yes)
                    {
                        employees.deleteEmployee(employeeID);
                    }
                    updateEmployees();
                }
                else
                {
                    MessageBox.Show("You cannot delete yourself", "Delete Employee");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (flag && dgvUsers.SelectedRows.Count == 1)
            {
                int index = dgvUsers.SelectedRows[0].Index;

                String employeeID = employees.EmployeeTable.Rows[index]["employeeID"].ToString();
                if (employeeID != "" + User.ID)
                {
                    flag = false; 
                    if (edit == null || edit.IsDisposed)
                    {
                        edit = new EditEmployee(index, this);
                        edit.MdiParent = this.MdiParent;
                    }
                    edit.Show();

                    //employees.editUser(employeeID);
                    //updateEmployees();
                }
                else
                {
                    MessageBox.Show("You cannot edit your own profile", "Edit Employee");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (flag && dgvUsers.SelectedRows.Count == 1)
            {
                flag = false;

                if (add == null || add.IsDisposed)
                {
                    add = new AddEmployee(this);
                    add.MdiParent = this.MdiParent;
                }
                add.Show();
            }
        }
    }
}
