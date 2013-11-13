﻿using System;
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
        
        public Front()
        {
            InitializeComponent();
            login = new Login();
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
                login = new Login();
                login.MdiParent = this;
                login.Show();
            }
        }
    }
}
