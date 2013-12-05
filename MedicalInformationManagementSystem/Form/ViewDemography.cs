using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace MedicalInformationManagementSystem
{
    public partial class ViewDemography : Form
    {
        public int patientId;
        Dictionary<String, String> dictionary = null;
        DataTable dtPatient = null;
        DataTable dtReferenceDoctor = null;
        DataTable dtAllergy = null;
        DataTable dtPatientEmail = null;
        DataTable dtPatientAddress = null;
        DataTable dtPatientPhone = null;
        DataTable dtInsurance = null;
        DatabaseConnector dc = null;
        string name, id, dob, sex, hc, address, phone;

        public ViewDemography()
        {
            InitializeComponent();
            lblBillingCode.Visible = true;

        }

        public int try1()
        {
            try
            {
                dtReferenceDoctor = dc.getData("GetPatientDoctor", dictionary);
                int a = int.Parse(dtReferenceDoctor.Rows[0][0].ToString());
                return a;
            }
            catch
            {
                int a = 0;
                return a;

            }
        }

        public int try2()
        {
            try
            {
                dtAllergy = dc.getData("GetAllery", dictionary);
                int a = int.Parse(dtAllergy.Rows[0][0].ToString());
                return a;
            }
            catch
            {
                int a = 0;
                return a;

            }
        }

        public int try3()
        {
            try
            {
                dtPatientAddress = dc.getData("GetPatientAddress", dictionary);
                int a = int.Parse(dtPatientAddress.Rows[0][0].ToString());
                return a;
            }
            catch
            {
                int a = 0;
                return a;

            }
        }

        public int try4()
        {
            try
            {
                dtPatientPhone = dc.getData("GetPatientPhone", dictionary);
                int a = int.Parse(dtPatientPhone.Rows[0][1].ToString());
                return a;
            }
            catch
            {
                int a = 0;
                return a;

            }
        }

        public int try5()
        {
            try
            {
                dtPatientEmail = dc.getData("GetPatientEmail", dictionary);
                int a = int.Parse(dtPatientEmail.Rows[0][1].ToString());
                return a;
            }
            catch
            {
                int a = 0;
                return a;

            }
        }




        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLastName_TextChanged(object sender, EventArgs e)
        {
            lblLastName.Visible = true;
        }

        private void lblFirstName_TextChanged(object sender, EventArgs e)
        {
            //lblFirstName.Visible = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            UpdatePatientDemography update = new UpdatePatientDemography();
            update.patientId = this.patientId;

            update.Show();
        }

        public Dictionary<String, String> createDictionary(String patientId)
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("@patientId", patientId);
            return dic;
        }

        private void ViewDemography_Load(object sender, EventArgs e)
        {
            dictionary = createDictionary(patientId.ToString());

            dc = new DatabaseConnector();

            dtPatient = dc.getData("GetPatient", dictionary);
            dtPatientEmail = dc.getData("GetPatientEmail", dictionary);
            dtPatientAddress = dc.getData("GetPatientAddress", dictionary);
            dtPatientPhone = dc.getData("GetPatientPhone", dictionary);
            dtReferenceDoctor = dc.getData("GetPatientDoctor", dictionary);
            dtAllergy = dc.getData("GetAllery", dictionary);
            dtInsurance = dc.getData("GetPatientOHIPInsurance", dictionary);

            lblLastName.Text = dtPatient.Rows[0][2].ToString();
            lblFirstName.Text = dtPatient.Rows[0][3].ToString();
            string dob = dtPatient.Rows[0][4].ToString();
            DateTime dt = Convert.ToDateTime(dob);
            dob = dt.Year.ToString() + "-" + dt.Month + "-" + dt.Day;
            lblDOB.Text = dob;
            lblGender.Text = dtPatient.Rows[0][5].ToString();
            lblPatientID.Text = patientId.ToString();


            if (try1() != 0)
            {
                lblReferralDoctor.Text = dtReferenceDoctor.Rows[0][2].ToString();
                lblBillingCode.Text = dtReferenceDoctor.Rows[0][1].ToString();

            }

            if (try2() != 0)
            {

                lblAllergyName.Text = dtAllergy.Rows[0][1].ToString();
                lblAllergyCategory.Text = dtAllergy.Rows[0][2].ToString();

            }

            lblInsNo.Text = dtInsurance.Rows[0][2].ToString() + " " + dtInsurance.Rows[0][3].ToString();


            string date = dtInsurance.Rows[0][4].ToString();
            DateTime edt = Convert.ToDateTime(date);
            date = edt.Year.ToString() + "-" + edt.Month + "-" + edt.Day;
            lblExpDate.Text = date;

            if (try3() != 0)
            {
                lblAddressType.Text = dtPatientAddress.Rows[0][2].ToString();
                lblAddress.Text = dtPatientAddress.Rows[0][3].ToString();
                lblCity.Text = dtPatientAddress.Rows[0][4].ToString();
                lblProvince.Text = dtPatientAddress.Rows[0][5].ToString();
                lblPostalCode.Text = dtPatientAddress.Rows[0][6].ToString();


            }

            if (try4() != 0)
            {
                lblPhone.Text = dtPatientPhone.Rows[0][3].ToString();
                lblPhoneType.Text = dtPatientPhone.Rows[0][2].ToString();

            }


            if (try5() != 0)
            {
                lblEmailType.Text = dtPatientEmail.Rows[0][2].ToString();
                lblEmail.Text = dtPatientEmail.Rows[0][3].ToString();

            }

        }



        private void btnViewEMR_Click(object sender, EventArgs e)
        {

            ViewPatientEMR view = new ViewPatientEMR();
            view.viewEMRPatientId = this.patientId.ToString();

            view.Show();

        }

        private void btnPrintLabel_Click(object sender, EventArgs e)
        {
            BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);

            iTextSharp.text.Font times = new iTextSharp.text.Font(bfTimes, 9);

            var pgSize = new iTextSharp.text.Rectangle(300, 100);
            var doc = new iTextSharp.text.Document(pgSize, 10, 5, 5, 0);

            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Label.pdf", FileMode.Create));

            name = lblLastName.Text + ", " + lblFirstName.Text;
            id = " (" + patientId + ")";
            dob = "\nD.O.B: " + lblDOB.Text;
            sex = "  Sex: " + lblGender.Text;
            hc = "\nHCN: " + lblInsNo.Text;
            address = "\nAddress: " + lblAddress.Text.ToUpper() + "\n" + lblCity.Text.ToUpper() + ", " + lblProvince.Text.ToUpper() + ", " + lblPostalCode.Text.ToUpper();
            phone = "\nPhone Number: " + lblPhone.Text;

            string par = name + id + dob + sex + hc + address + phone;
            Paragraph paragraph = new Paragraph(par, times);
            doc.Open();
            doc.Add(paragraph);

            iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance("health-care-shield-icon.png");
            png.ScalePercent(20f);
            png.SetAbsolutePosition(doc.PageSize.Width - 17f - 50f, doc.PageSize.Height - 38f - 38f);
            doc.Add(png);

            doc.Close();

            System.Diagnostics.Process.Start("Label.pdf");
        }

        private void btnPrintSheet_Click(object sender, EventArgs e)
        {
            BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);

            iTextSharp.text.Font times = new iTextSharp.text.Font(bfTimes, 9);

            iTextSharp.text.Font times1 = new iTextSharp.text.Font(bfTimes, 12);

            Document doc = new Document(iTextSharp.text.PageSize.A4, 20, 10, 20, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("DailySheet.pdf", FileMode.Create));


            string par1 = lblLastName.Text.ToUpper() + ", " + lblFirstName.Text.ToUpper() + "\n" + "D.O.B: " + lblDOB.Text + " OHIP: " + lblInsNo.Text + "\n" + lblAddress.Text.ToUpper() + "\n" +
                lblCity.Text.ToUpper() + ", " + lblProvince.Text.ToUpper() + ", " + lblPostalCode.Text.ToUpper() + "\n" + lblPhone.Text;
            Paragraph paragraph1 = new Paragraph(par1, times);

            string par2 = "Dr.____\nBONIFACE PARK MEDICAL CENTER\n141 PROGRESS AVENUE\nSCARBOROUGH, ON, M1C 5K9\n647-686-1193 ";
            Paragraph paragraph2 = new Paragraph(par2, times);
            paragraph2.IndentationLeft = 230;
            paragraph2.SpacingBefore = -67;

            string par3 = (DateTime.Now).ToString();
            Paragraph paragraph3 = new Paragraph(par3, times);
            paragraph3.IndentationLeft = 460;
            paragraph3.SpacingBefore = -67;

            iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance("health-care-shield-icon.png");
            png.ScalePercent(15f);
            png.SetAbsolutePosition(doc.PageSize.Width - 26f - 50f, doc.PageSize.Height - 40f - 40f);

            string par4 = "DOCTOR'S NOTE";
            Paragraph paragraph4 = new Paragraph(par4, times1);
            paragraph4.IndentationLeft = 2;
            paragraph4.SpacingBefore = 85;

            doc.Open();
            doc.Add(paragraph1);
            doc.Add(paragraph2);
            doc.Add(paragraph3);
            doc.Add(png);
            doc.Add(paragraph4);

            PdfContentByte cb = wri.DirectContent;
            cb.Rectangle(doc.PageSize.Width - 580f, 740f, 565f, 80f);
            cb.Rectangle(doc.PageSize.Width - 580f, 50f, 565f, 625f);
            cb.Stroke();

            doc.Close();

            System.Diagnostics.Process.Start("DailySheet.pdf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();

        }

        private void btnExpPt_Click(object sender, EventArgs e)
        {
            AddtoDoctorList a = new AddtoDoctorList();
            a.patientID = this.patientId;
            a.Show();
        }


    }
}
