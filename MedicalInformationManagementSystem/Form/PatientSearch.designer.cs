namespace MedicalInformationManagementSystem
{
    partial class PatientSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientSearch));
            this.getPatientByNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getPatientByNameDataSet = new MedicalInformationManagementSystem.DataSet.GetPatientByNameDataSet();
            this.getPatientByIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getPatientByIdDataSet = new MedicalInformationManagementSystem.DataSet.GetPatientByIdDataSet();
            this.getPatientByIdTableAdapter = new MedicalInformationManagementSystem.DataSet.GetPatientByIdDataSetTableAdapters.GetPatientByIdTableAdapter();
            this.getPatientByNameTableAdapter = new MedicalInformationManagementSystem.DataSet.GetPatientByNameDataSetTableAdapters.GetPatientByNameTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_SearchPatient = new System.Windows.Forms.Button();
            this.cm_Options = new System.Windows.Forms.ComboBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.txt_Output = new System.Windows.Forms.TextBox();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giveMiddleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registratonDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.genderDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giveMiddleNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registratonDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientByNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientByNameDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientByIdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientByIdDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // getPatientByNameBindingSource
            // 
            this.getPatientByNameBindingSource.DataMember = "GetPatientByName";
            this.getPatientByNameBindingSource.DataSource = this.getPatientByNameDataSet;
            // 
            // getPatientByNameDataSet
            // 
            this.getPatientByNameDataSet.DataSetName = "GetPatientByNameDataSet";
            this.getPatientByNameDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getPatientByIdBindingSource
            // 
            this.getPatientByIdBindingSource.DataMember = "GetPatientById";
            this.getPatientByIdBindingSource.DataSource = this.getPatientByIdDataSet;
            // 
            // getPatientByIdDataSet
            // 
            this.getPatientByIdDataSet.DataSetName = "GetPatientByIdDataSet";
            this.getPatientByIdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getPatientByIdTableAdapter
            // 
            this.getPatientByIdTableAdapter.ClearBeforeFill = true;
            // 
            // getPatientByNameTableAdapter
            // 
            this.getPatientByNameTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(204, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 39);
            this.button3.TabIndex = 5;
            this.button3.Text = "Daily Report";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(66, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 75);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrator Reports";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(396, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 75);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Doctor Today";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(182, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 46);
            this.button4.TabIndex = 1;
            this.button4.Text = "Day Appointment List";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(544, 25);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 23;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_SearchPatient
            // 
            this.btn_SearchPatient.Enabled = false;
            this.btn_SearchPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchPatient.Location = new System.Drawing.Point(454, 25);
            this.btn_SearchPatient.Name = "btn_SearchPatient";
            this.btn_SearchPatient.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchPatient.TabIndex = 18;
            this.btn_SearchPatient.Text = "Search";
            this.btn_SearchPatient.UseVisualStyleBackColor = true;
            this.btn_SearchPatient.Click += new System.EventHandler(this.btn_SearchPatient_Click);
            // 
            // cm_Options
            // 
            this.cm_Options.FormattingEnabled = true;
            this.cm_Options.Items.AddRange(new object[] {
            "",
            "ID ",
            "NAME"});
            this.cm_Options.Location = new System.Drawing.Point(179, 24);
            this.cm_Options.Name = "cm_Options";
            this.cm_Options.Size = new System.Drawing.Size(121, 21);
            this.cm_Options.TabIndex = 19;
            this.cm_Options.SelectedIndexChanged += new System.EventHandler(this.cm_Options_SelectedIndexChanged);
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search.Location = new System.Drawing.Point(79, 27);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(85, 18);
            this.lbl_Search.TabIndex = 20;
            this.lbl_Search.Text = "Search By";
            // 
            // txt_Output
            // 
            this.txt_Output.Location = new System.Drawing.Point(316, 25);
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.Size = new System.Drawing.Size(121, 20);
            this.txt_Output.TabIndex = 21;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giveMiddleNameDataGridViewTextBoxColumn
            // 
            this.giveMiddleNameDataGridViewTextBoxColumn.DataPropertyName = "giveMiddleName";
            this.giveMiddleNameDataGridViewTextBoxColumn.HeaderText = "giveMiddleName";
            this.giveMiddleNameDataGridViewTextBoxColumn.Name = "giveMiddleNameDataGridViewTextBoxColumn";
            this.giveMiddleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "lastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registratonDateDataGridViewTextBoxColumn
            // 
            this.registratonDateDataGridViewTextBoxColumn.DataPropertyName = "registratonDate";
            this.registratonDateDataGridViewTextBoxColumn.HeaderText = "registratonDate";
            this.registratonDateDataGridViewTextBoxColumn.Name = "registratonDateDataGridViewTextBoxColumn";
            this.registratonDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "patientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "patientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.registratonDateDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.giveMiddleNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getPatientByIdBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(66, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(645, 207);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // genderDataGridViewTextBoxColumn1
            // 
            this.genderDataGridViewTextBoxColumn1.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn1.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn1.Name = "genderDataGridViewTextBoxColumn1";
            this.genderDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn1
            // 
            this.dateOfBirthDataGridViewTextBoxColumn1.DataPropertyName = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn1.HeaderText = "D.O.B";
            this.dateOfBirthDataGridViewTextBoxColumn1.Name = "dateOfBirthDataGridViewTextBoxColumn1";
            this.dateOfBirthDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // giveMiddleNameDataGridViewTextBoxColumn1
            // 
            this.giveMiddleNameDataGridViewTextBoxColumn1.DataPropertyName = "giveMiddleName";
            this.giveMiddleNameDataGridViewTextBoxColumn1.HeaderText = "First Name";
            this.giveMiddleNameDataGridViewTextBoxColumn1.Name = "giveMiddleNameDataGridViewTextBoxColumn1";
            this.giveMiddleNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // registratonDateDataGridViewTextBoxColumn1
            // 
            this.registratonDateDataGridViewTextBoxColumn1.DataPropertyName = "registratonDate";
            this.registratonDateDataGridViewTextBoxColumn1.HeaderText = "Registered Date";
            this.registratonDateDataGridViewTextBoxColumn1.Name = "registratonDateDataGridViewTextBoxColumn1";
            this.registratonDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // patientIDDataGridViewTextBoxColumn1
            // 
            this.patientIDDataGridViewTextBoxColumn1.DataPropertyName = "patientID";
            this.patientIDDataGridViewTextBoxColumn1.HeaderText = "Patient ID";
            this.patientIDDataGridViewTextBoxColumn1.Name = "patientIDDataGridViewTextBoxColumn1";
            this.patientIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn1,
            this.registratonDateDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.giveMiddleNameDataGridViewTextBoxColumn1,
            this.dateOfBirthDataGridViewTextBoxColumn1,
            this.genderDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.getPatientByNameBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Location = new System.Drawing.Point(66, 77);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(645, 224);
            this.dataGridView2.TabIndex = 25;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(748, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "View Patient EMR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(748, 140);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(133, 39);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "View Patient Demography";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(748, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "View EMR Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(748, 77);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 39);
            this.button5.TabIndex = 5;
            this.button5.Text = "Register new patient";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // PatientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(926, 401);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Output);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.cm_Options);
            this.Controls.Add(this.btn_SearchPatient);
            this.Controls.Add(this.btn_Exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientSearch";
            this.Text = "Patient Search ";
            this.Load += new System.EventHandler(this.PatientSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getPatientByNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientByNameDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientByIdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPatientByIdDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource getPatientByIdBindingSource;
        private DataSet.GetPatientByIdDataSet getPatientByIdDataSet;
        private DataSet.GetPatientByIdDataSetTableAdapters.GetPatientByIdTableAdapter getPatientByIdTableAdapter;
        private System.Windows.Forms.BindingSource getPatientByNameBindingSource;
        private DataSet.GetPatientByNameDataSet getPatientByNameDataSet;
        private DataSet.GetPatientByNameDataSetTableAdapters.GetPatientByNameTableAdapter getPatientByNameTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_SearchPatient;
        private System.Windows.Forms.ComboBox cm_Options;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.TextBox txt_Output;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giveMiddleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registratonDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giveMiddleNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn registratonDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;

    }
}