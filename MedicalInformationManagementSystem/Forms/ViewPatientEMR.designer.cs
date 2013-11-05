namespace HealthInformaticSystem
{
    partial class ViewPatientEMR
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radiologyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestampDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.radiologyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radiologyID1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getPatientRadiologyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gibersonDataSet4 = new HealthInformaticSystem.GibersonDataSet4();
            this.gibersonDataSet3 = new HealthInformaticSystem.GibersonDataSet3();
            this.getPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getPatientTableAdapter = new HealthInformaticSystem.GibersonDataSet3TableAdapters.GetPatientTableAdapter();
            this.getPatientRadiologyTableAdapter = new HealthInformaticSystem.GibersonDataSet4TableAdapters.GetPatientRadiologyTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.laboratoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getPatientLaboratoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gibersonDataSet5 = new HealthInformaticSystem.GibersonDataSet5();
            this.getPatientLaboratoryTableAdapter = new HealthInformaticSystem.GibersonDataSet5TableAdapters.GetPatientLaboratoryTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.medicationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getPatientMedicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gibersonDataSet9 = new HealthInformaticSystem.GibersonDataSet9();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.diagnosisIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getPatientDiagnosisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gibersonDataSet8 = new HealthInformaticSystem.GibersonDataSet8();
            this.getPatientDiagnosisTableAdapter = new HealthInformaticSystem.GibersonDataSet8TableAdapters.GetPatientDiagnosisTableAdapter();
            this.getPatientMedicationTableAdapter = new HealthInformaticSystem.GibersonDataSet9TableAdapters.GetPatientMedicationTableAdapter();
            this.userControlGetPatientDetails1 = new HealthInformaticSystem.UserControlGetPatientDetails();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientRadiologyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gibersonDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gibersonDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientLaboratoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gibersonDataSet5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientMedicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gibersonDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientDiagnosisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gibersonDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.radiologyID,
            this.name,
            this.description,
            this.patientIDDataGridViewTextBoxColumn,
            this.doctorIDDataGridViewTextBoxColumn,
            this.timestampDataGridViewImageColumn,
            this.radiologyIDDataGridViewTextBoxColumn,
            this.radiologyID1DataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.getPatientRadiologyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(344, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // radiologyID
            // 
            this.radiologyID.DataPropertyName = "radiologyID";
            this.radiologyID.HeaderText = "radiologyID";
            this.radiologyID.Name = "radiologyID";
            this.radiologyID.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "patientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "patientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "doctorID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "doctorID";
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
            this.doctorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timestampDataGridViewImageColumn
            // 
            this.timestampDataGridViewImageColumn.DataPropertyName = "timestamp";
            this.timestampDataGridViewImageColumn.HeaderText = "timestamp";
            this.timestampDataGridViewImageColumn.Name = "timestampDataGridViewImageColumn";
            this.timestampDataGridViewImageColumn.ReadOnly = true;
            // 
            // radiologyIDDataGridViewTextBoxColumn
            // 
            this.radiologyIDDataGridViewTextBoxColumn.DataPropertyName = "radiologyID";
            this.radiologyIDDataGridViewTextBoxColumn.HeaderText = "radiologyID";
            this.radiologyIDDataGridViewTextBoxColumn.Name = "radiologyIDDataGridViewTextBoxColumn";
            this.radiologyIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // radiologyID1DataGridViewTextBoxColumn
            // 
            this.radiologyID1DataGridViewTextBoxColumn.DataPropertyName = "radiologyID1";
            this.radiologyID1DataGridViewTextBoxColumn.HeaderText = "radiologyID1";
            this.radiologyID1DataGridViewTextBoxColumn.Name = "radiologyID1DataGridViewTextBoxColumn";
            this.radiologyID1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // getPatientRadiologyBindingSource
            // 
            this.getPatientRadiologyBindingSource.DataMember = "GetPatientRadiology";
            this.getPatientRadiologyBindingSource.DataSource = this.gibersonDataSet4;
            // 
            // gibersonDataSet4
            // 
            this.gibersonDataSet4.DataSetName = "GibersonDataSet4";
            this.gibersonDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gibersonDataSet3
            // 
            this.gibersonDataSet3.DataSetName = "GibersonDataSet3";
            this.gibersonDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getPatientBindingSource
            // 
            this.getPatientBindingSource.DataMember = "GetPatient";
            this.getPatientBindingSource.DataSource = this.gibersonDataSet3;
            // 
            // getPatientTableAdapter
            // 
            this.getPatientTableAdapter.ClearBeforeFill = true;
            // 
            // getPatientRadiologyTableAdapter
            // 
            this.getPatientRadiologyTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.laboratoryID,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.getPatientLaboratoryBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 169);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(344, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // laboratoryID
            // 
            this.laboratoryID.DataPropertyName = "laboratoryID";
            this.laboratoryID.HeaderText = "laboratoryID";
            this.laboratoryID.Name = "laboratoryID";
            this.laboratoryID.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getPatientLaboratoryBindingSource
            // 
            this.getPatientLaboratoryBindingSource.DataMember = "GetPatientLaboratory";
            this.getPatientLaboratoryBindingSource.DataSource = this.gibersonDataSet5;
            // 
            // gibersonDataSet5
            // 
            this.gibersonDataSet5.DataSetName = "GibersonDataSet5";
            this.gibersonDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getPatientLaboratoryTableAdapter
            // 
            this.getPatientLaboratoryTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(61, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 319);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EMR Type";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(37, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Medication";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(37, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Diagnosis";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(37, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Laboratory";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(37, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Radiology";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView4);
            this.groupBox2.Controls.Add(this.dataGridView3);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(287, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 319);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "History";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicationIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn3,
            this.descriptionDataGridViewTextBoxColumn3});
            this.dataGridView4.DataSource = this.getPatientMedicationBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(368, 175);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(290, 150);
            this.dataGridView4.TabIndex = 5;
            // 
            // medicationIDDataGridViewTextBoxColumn
            // 
            this.medicationIDDataGridViewTextBoxColumn.DataPropertyName = "medicationID";
            this.medicationIDDataGridViewTextBoxColumn.HeaderText = "medicationID";
            this.medicationIDDataGridViewTextBoxColumn.Name = "medicationIDDataGridViewTextBoxColumn";
            this.medicationIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            this.nameDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn3
            // 
            this.descriptionDataGridViewTextBoxColumn3.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn3.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn3.Name = "descriptionDataGridViewTextBoxColumn3";
            this.descriptionDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // getPatientMedicationBindingSource
            // 
            this.getPatientMedicationBindingSource.DataMember = "GetPatientMedication";
            this.getPatientMedicationBindingSource.DataSource = this.gibersonDataSet9;
            // 
            // gibersonDataSet9
            // 
            this.gibersonDataSet9.DataSetName = "GibersonDataSet9";
            this.gibersonDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diagnosisIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn2,
            this.descriptionDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.getPatientDiagnosisBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(368, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(273, 150);
            this.dataGridView3.TabIndex = 4;
            // 
            // diagnosisIDDataGridViewTextBoxColumn
            // 
            this.diagnosisIDDataGridViewTextBoxColumn.DataPropertyName = "diagnosisID";
            this.diagnosisIDDataGridViewTextBoxColumn.HeaderText = "diagnosisID";
            this.diagnosisIDDataGridViewTextBoxColumn.Name = "diagnosisIDDataGridViewTextBoxColumn";
            this.diagnosisIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn2
            // 
            this.descriptionDataGridViewTextBoxColumn2.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn2.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn2.Name = "descriptionDataGridViewTextBoxColumn2";
            this.descriptionDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // getPatientDiagnosisBindingSource
            // 
            this.getPatientDiagnosisBindingSource.DataMember = "GetPatientDiagnosis";
            this.getPatientDiagnosisBindingSource.DataSource = this.gibersonDataSet8;
            // 
            // gibersonDataSet8
            // 
            this.gibersonDataSet8.DataSetName = "GibersonDataSet8";
            this.gibersonDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getPatientDiagnosisTableAdapter
            // 
            this.getPatientDiagnosisTableAdapter.ClearBeforeFill = true;
            // 
            // getPatientMedicationTableAdapter
            // 
            this.getPatientMedicationTableAdapter.ClearBeforeFill = true;
            // 
            // userControlGetPatientDetails1
            // 
            this.userControlGetPatientDetails1.Location = new System.Drawing.Point(98, 12);
            this.userControlGetPatientDetails1.Name = "userControlGetPatientDetails1";
            this.userControlGetPatientDetails1.Size = new System.Drawing.Size(755, 89);
            this.userControlGetPatientDetails1.TabIndex = 6;
            // 
            // ViewPatientEMR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 522);
            this.Controls.Add(this.userControlGetPatientDetails1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ViewPatientEMR";
            this.Text = "EMR";
            this.Load += new System.EventHandler(this.ViewPatientEMR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientRadiologyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gibersonDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gibersonDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientLaboratoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gibersonDataSet5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientMedicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gibersonDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientDiagnosisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gibersonDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource getPatientBindingSource;
        private GibersonDataSet3 gibersonDataSet3;
        private GibersonDataSet3TableAdapters.GetPatientTableAdapter getPatientTableAdapter;
        private System.Windows.Forms.BindingSource getPatientRadiologyBindingSource;
        private GibersonDataSet4 gibersonDataSet4;
        private GibersonDataSet4TableAdapters.GetPatientRadiologyTableAdapter getPatientRadiologyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn radiologyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource getPatientLaboratoryBindingSource;
        private GibersonDataSet5 gibersonDataSet5;
        private GibersonDataSet5TableAdapters.GetPatientLaboratoryTableAdapter getPatientLaboratoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn timestampDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn radiologyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn radiologyID1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource getPatientDiagnosisBindingSource;
        private GibersonDataSet8 gibersonDataSet8;
        private GibersonDataSet8TableAdapters.GetPatientDiagnosisTableAdapter getPatientDiagnosisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn laboratoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource getPatientMedicationBindingSource;
        private GibersonDataSet9 gibersonDataSet9;
        private GibersonDataSet9TableAdapters.GetPatientMedicationTableAdapter getPatientMedicationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosisIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn2;
        private UserControlGetPatientDetails userControlGetPatientDetails1;
    }
}