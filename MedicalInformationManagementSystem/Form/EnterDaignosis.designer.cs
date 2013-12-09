using MedicalInformationManagementSystem.DataSet;
namespace MedicalInformationManagementSystem
{
    partial class EnterDaignosis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterDaignosis));
            this.txt_DiagnosisDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.getDiagnosisIntoComboboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getDaignosisToComboBoxDataSet = new MedicalInformationManagementSystem.DataSet.GetDaignosisToComboBoxDataSet();
            this.getDiagnosisIntoComboboxTableAdapter = new MedicalInformationManagementSystem.DataSet.GetDaignosisToComboBoxDataSetTableAdapters.GetDiagnosisIntoComboboxTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.getDiagnosisIntoComboboxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDaignosisToComboBoxDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_DiagnosisDescription
            // 
            this.txt_DiagnosisDescription.Location = new System.Drawing.Point(163, 69);
            this.txt_DiagnosisDescription.Multiline = true;
            this.txt_DiagnosisDescription.Name = "txt_DiagnosisDescription";
            this.txt_DiagnosisDescription.Size = new System.Drawing.Size(203, 87);
            this.txt_DiagnosisDescription.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Diagnosis Description ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Diagnosis  Name";
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(163, 173);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(87, 37);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.getDiagnosisIntoComboboxBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(163, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // getDiagnosisIntoComboboxBindingSource
            // 
            this.getDiagnosisIntoComboboxBindingSource.DataMember = "GetDiagnosisIntoCombobox";
            this.getDiagnosisIntoComboboxBindingSource.DataSource = this.getDaignosisToComboBoxDataSet;
            // 
            // getDaignosisToComboBoxDataSet
            // 
            this.getDaignosisToComboBoxDataSet.DataSetName = "GetDaignosisToComboBoxDataSet";
            this.getDaignosisToComboBoxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getDiagnosisIntoComboboxTableAdapter
            // 
            this.getDiagnosisIntoComboboxTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(268, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 23;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EnterDaignosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(396, 230);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_DiagnosisDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnterDaignosis";
            this.Text = "EnterDaignosis";
            this.Load += new System.EventHandler(this.EnterDaignosis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getDiagnosisIntoComboboxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDaignosisToComboBoxDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_DiagnosisDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox comboBox1;
        private GetDaignosisToComboBoxDataSet getDaignosisToComboBoxDataSet;
        private System.Windows.Forms.BindingSource getDiagnosisIntoComboboxBindingSource;
        private MedicalInformationManagementSystem.DataSet.GetDaignosisToComboBoxDataSetTableAdapters.GetDiagnosisIntoComboboxTableAdapter getDiagnosisIntoComboboxTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}