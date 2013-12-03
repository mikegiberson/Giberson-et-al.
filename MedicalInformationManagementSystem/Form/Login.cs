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
    public partial class Login : Form
    {
        private Front Front;
        private Encrypt Encryption = new Encrypt();

        private DatabaseConnector dc;
        private Dictionary<String, String> dictionary;
        
        private DataTable dtEmployee;
        
        public Login(Front f)
        {
            Front = f;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUserName.Text;
            String password = Encryption.MD5(txtPassword.Text);

            if (!String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(txtPassword.Text))
            {
                dictionary = new Dictionary<string, string>();
                dictionary.Add("@userName", username);

                dc = new DatabaseConnector();
                dtEmployee = dc.getData("ReadEmployeeByName", dictionary);

                if (dtEmployee.Rows.Count == 1)
                {
                    verifyEmployee(username, password);
                }
                else
                {
                    MessageBox.Show("Multiple user with same userName");
                }
            }
            else
            {
                MessageBox.Show("Some field(s) were left blank.");
            }
        }

        public void verifyEmployee(String username, String password)
        {
            if (String.Equals(dtEmployee.Rows[0]["password"].ToString(), password))
            {
                Front.employeeID = int.Parse(dtEmployee.Rows[0]["employeeID"].ToString());
                Front.userName = dtEmployee.Rows[0]["password"].ToString();
                Front.role = dtEmployee.Rows[0]["role"].ToString();
                Front.Login();
            }
            else
            {
                MessageBox.Show("Invalid Password");
            }
        }
    }
}
