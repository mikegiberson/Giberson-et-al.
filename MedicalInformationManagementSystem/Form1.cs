using MIMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthInformaticSystem
{
    public partial class Form1 : Form
    {
        Database db;
        
        public Form1()
        {
            //InitializeComponent();

            db = new Database();

            //used to test Create Demographic Form
            Application.Run(new CreateDemForm());
            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Dictionary<String, String> d = new Dictionary<String, String>();
            DataTable table = db.getData("select * from [Person]", d);

            lblResult.Text = "";
            foreach (DataRow row in table.Rows)
            {
                lblResult.Text += row["givenMiddleName"].ToString();
                lblResult.Text += " " + row["lastName"].ToString();
                lblResult.Text += " (" + row["dateOfBirth"].ToString() + ")\n";
            }
        }
    }
}
