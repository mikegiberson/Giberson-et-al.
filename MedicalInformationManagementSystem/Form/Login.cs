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
        Front front;
        User user;
        
        public Login(Front f, User u)
        {
            InitializeComponent();

            front = f;
            user = u;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                String UserName = txtUser.Text;
                String Password = txtPass.Text;

                user.Login(UserName, Password);
                if (User.ID != null)
                {
                    front.setRole();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
