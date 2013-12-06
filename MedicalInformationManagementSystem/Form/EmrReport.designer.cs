using MedicalInformationManagementSystem.DataSet;
namespace MedicalInformationManagementSystem
{
    partial class EmrReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmrReport));
            this.getPatientLatestEmrReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPrintLatestEmr = new HealthInformaticSystem.DataSet.DataSetPrintLatestEmr();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getPatientLatestEmrReportTableAdapter = new HealthInformaticSystem.DataSet.DataSetPrintLatestEmrTableAdapters.GetPatientLatestEmrReportTableAdapter();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientLatestEmrReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrintLatestEmr)).BeginInit();
            this.SuspendLayout();
            // 
            // getPatientLatestEmrReportBindingSource
            // 
            this.getPatientLatestEmrReportBindingSource.DataMember = "GetPatientLatestEmrReport";
            this.getPatientLatestEmrReportBindingSource.DataSource = this.dataSetPrintLatestEmr;
            // 
            // dataSetPrintLatestEmr
            // 
            this.dataSetPrintLatestEmr.DataSetName = "DataSetPrintLatestEmr";
            this.dataSetPrintLatestEmr.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PrintablePatientEmrReport";
            reportDataSource1.Value = this.getPatientLatestEmrReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MedicalInformationManagementSystem.Reports.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(845, 436);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // getPatientLatestEmrReportTableAdapter
            // 
            this.getPatientLatestEmrReportTableAdapter.ClearBeforeFill = true;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(845, 436);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // ovalShape1
            // 
            this.ovalShape1.Location = new System.Drawing.Point(231, 35);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(257, 43);
            // 
            // EmrReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 436);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmrReport";
            this.Text = "EmrReport";
            this.Load += new System.EventHandler(this.EmrReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getPatientLatestEmrReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrintLatestEmr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource getPatientLatestEmrReportBindingSource;
        private HealthInformaticSystem.DataSet.DataSetPrintLatestEmr dataSetPrintLatestEmr;
        private HealthInformaticSystem.DataSet.DataSetPrintLatestEmrTableAdapters.GetPatientLatestEmrReportTableAdapter getPatientLatestEmrReportTableAdapter;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
    }
}