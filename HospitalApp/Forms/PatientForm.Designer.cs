namespace HospitalApp.Forms
{
    partial class PatientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbx_disease = new System.Windows.Forms.ComboBox();
            this.cbmx_doctors = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_doctor_time = new System.Windows.Forms.DateTimePicker();
            this.rdbtn_time1 = new System.Windows.Forms.RadioButton();
            this.rdbtn_time4 = new System.Windows.Forms.RadioButton();
            this.rdbtn_time7 = new System.Windows.Forms.RadioButton();
            this.rdbtn_time8 = new System.Windows.Forms.RadioButton();
            this.rdbtn_time5 = new System.Windows.Forms.RadioButton();
            this.rdbtn_time2 = new System.Windows.Forms.RadioButton();
            this.rdbtn_time9 = new System.Windows.Forms.RadioButton();
            this.rdbtn_time6 = new System.Windows.Forms.RadioButton();
            this.rdbtn_time3 = new System.Windows.Forms.RadioButton();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_errors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type of Disease";
            // 
            // cmbx_disease
            // 
            this.cmbx_disease.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_disease.FormattingEnabled = true;
            this.cmbx_disease.Location = new System.Drawing.Point(86, 178);
            this.cmbx_disease.Name = "cmbx_disease";
            this.cmbx_disease.Size = new System.Drawing.Size(259, 24);
            this.cmbx_disease.TabIndex = 1;
            this.cmbx_disease.SelectedValueChanged += new System.EventHandler(this.cmbx_disease_SelectedIndexChanged);
            // 
            // cbmx_doctors
            // 
            this.cbmx_doctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmx_doctors.FormattingEnabled = true;
            this.cbmx_doctors.Location = new System.Drawing.Point(86, 278);
            this.cbmx_doctors.Name = "cbmx_doctors";
            this.cbmx_doctors.Size = new System.Drawing.Size(259, 24);
            this.cbmx_doctors.TabIndex = 3;
            this.cbmx_doctors.SelectedIndexChanged += new System.EventHandler(this.cbmx_doctors_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doctors";
            // 
            // dtp_doctor_time
            // 
            this.dtp_doctor_time.Location = new System.Drawing.Point(86, 357);
            this.dtp_doctor_time.Name = "dtp_doctor_time";
            this.dtp_doctor_time.Size = new System.Drawing.Size(259, 22);
            this.dtp_doctor_time.TabIndex = 4;
            this.dtp_doctor_time.ValueChanged += new System.EventHandler(this.dtp_doctor_time_ValueChanged);
            // 
            // rdbtn_time1
            // 
            this.rdbtn_time1.AutoSize = true;
            this.rdbtn_time1.Location = new System.Drawing.Point(86, 410);
            this.rdbtn_time1.Name = "rdbtn_time1";
            this.rdbtn_time1.Size = new System.Drawing.Size(65, 21);
            this.rdbtn_time1.TabIndex = 5;
            this.rdbtn_time1.Text = "09:00";
            this.rdbtn_time1.UseVisualStyleBackColor = true;
            // 
            // rdbtn_time4
            // 
            this.rdbtn_time4.AutoSize = true;
            this.rdbtn_time4.Location = new System.Drawing.Point(86, 477);
            this.rdbtn_time4.Name = "rdbtn_time4";
            this.rdbtn_time4.Size = new System.Drawing.Size(65, 21);
            this.rdbtn_time4.TabIndex = 6;
            this.rdbtn_time4.Text = "12:00";
            this.rdbtn_time4.UseVisualStyleBackColor = true;
            // 
            // rdbtn_time7
            // 
            this.rdbtn_time7.AutoSize = true;
            this.rdbtn_time7.Location = new System.Drawing.Point(86, 540);
            this.rdbtn_time7.Name = "rdbtn_time7";
            this.rdbtn_time7.Size = new System.Drawing.Size(65, 21);
            this.rdbtn_time7.TabIndex = 7;
            this.rdbtn_time7.Text = "15:00";
            this.rdbtn_time7.UseVisualStyleBackColor = true;
            // 
            // rdbtn_time8
            // 
            this.rdbtn_time8.AutoSize = true;
            this.rdbtn_time8.Location = new System.Drawing.Point(182, 540);
            this.rdbtn_time8.Name = "rdbtn_time8";
            this.rdbtn_time8.Size = new System.Drawing.Size(65, 21);
            this.rdbtn_time8.TabIndex = 10;
            this.rdbtn_time8.Text = "16:00";
            this.rdbtn_time8.UseVisualStyleBackColor = true;
            // 
            // rdbtn_time5
            // 
            this.rdbtn_time5.AutoSize = true;
            this.rdbtn_time5.Location = new System.Drawing.Point(182, 477);
            this.rdbtn_time5.Name = "rdbtn_time5";
            this.rdbtn_time5.Size = new System.Drawing.Size(65, 21);
            this.rdbtn_time5.TabIndex = 9;
            this.rdbtn_time5.Text = "13:00";
            this.rdbtn_time5.UseVisualStyleBackColor = true;
            // 
            // rdbtn_time2
            // 
            this.rdbtn_time2.AutoSize = true;
            this.rdbtn_time2.Location = new System.Drawing.Point(182, 410);
            this.rdbtn_time2.Name = "rdbtn_time2";
            this.rdbtn_time2.Size = new System.Drawing.Size(65, 21);
            this.rdbtn_time2.TabIndex = 8;
            this.rdbtn_time2.Text = "10:00";
            this.rdbtn_time2.UseVisualStyleBackColor = true;
            // 
            // rdbtn_time9
            // 
            this.rdbtn_time9.AutoSize = true;
            this.rdbtn_time9.Location = new System.Drawing.Point(280, 540);
            this.rdbtn_time9.Name = "rdbtn_time9";
            this.rdbtn_time9.Size = new System.Drawing.Size(65, 21);
            this.rdbtn_time9.TabIndex = 13;
            this.rdbtn_time9.Text = "17:00";
            this.rdbtn_time9.UseVisualStyleBackColor = true;
            // 
            // rdbtn_time6
            // 
            this.rdbtn_time6.AutoSize = true;
            this.rdbtn_time6.Location = new System.Drawing.Point(280, 477);
            this.rdbtn_time6.Name = "rdbtn_time6";
            this.rdbtn_time6.Size = new System.Drawing.Size(65, 21);
            this.rdbtn_time6.TabIndex = 12;
            this.rdbtn_time6.Text = "14:00";
            this.rdbtn_time6.UseVisualStyleBackColor = true;
            // 
            // rdbtn_time3
            // 
            this.rdbtn_time3.AutoSize = true;
            this.rdbtn_time3.Location = new System.Drawing.Point(280, 410);
            this.rdbtn_time3.Name = "rdbtn_time3";
            this.rdbtn_time3.Size = new System.Drawing.Size(65, 21);
            this.rdbtn_time3.TabIndex = 11;
            this.rdbtn_time3.Text = "11:00";
            this.rdbtn_time3.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(182, 581);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(163, 57);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_errors
            // 
            this.lbl_errors.AutoSize = true;
            this.lbl_errors.Location = new System.Drawing.Point(86, 13);
            this.lbl_errors.Name = "lbl_errors";
            this.lbl_errors.Size = new System.Drawing.Size(0, 17);
            this.lbl_errors.TabIndex = 15;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 657);
            this.Controls.Add(this.lbl_errors);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.rdbtn_time9);
            this.Controls.Add(this.rdbtn_time6);
            this.Controls.Add(this.rdbtn_time3);
            this.Controls.Add(this.rdbtn_time8);
            this.Controls.Add(this.rdbtn_time5);
            this.Controls.Add(this.rdbtn_time2);
            this.Controls.Add(this.rdbtn_time7);
            this.Controls.Add(this.rdbtn_time4);
            this.Controls.Add(this.rdbtn_time1);
            this.Controls.Add(this.dtp_doctor_time);
            this.Controls.Add(this.cbmx_doctors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbx_disease);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PatientForm_FormClosed);
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbx_disease;
        private System.Windows.Forms.ComboBox cbmx_doctors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_doctor_time;
        private System.Windows.Forms.RadioButton rdbtn_time1;
        private System.Windows.Forms.RadioButton rdbtn_time4;
        private System.Windows.Forms.RadioButton rdbtn_time7;
        private System.Windows.Forms.RadioButton rdbtn_time8;
        private System.Windows.Forms.RadioButton rdbtn_time5;
        private System.Windows.Forms.RadioButton rdbtn_time2;
        private System.Windows.Forms.RadioButton rdbtn_time9;
        private System.Windows.Forms.RadioButton rdbtn_time6;
        private System.Windows.Forms.RadioButton rdbtn_time3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_errors;
    }
}