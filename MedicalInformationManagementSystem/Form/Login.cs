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
        private List<string> Roles = new List<string>();
        
        public Login()
        {
            InitializeComponent();

            Roles.Add("Medical Staff");
            Roles.Add("Adminstrative Staff");
            Roles.Add("Manager");

            foreach (String r in Roles)
            {
                cmbRole.Items.Add(r);
            }
            cmbRole.SelectedIndex = 0;
        }

        private String encrypt(String password)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = x.ComputeHash(data);
            return System.Text.Encoding.ASCII.GetString(data);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUserName.Text;
            String password = encrypt(txtPassword.Text);
            String role = cmbRole.SelectedItem.ToString();

            if (!String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(role))
            {
                foreach (String r in Roles)
                {
                    if (String.Equals(r, role))
                    {
                        MessageBox.Show(username + " " + password + " " + role);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }

        }
    }
}
