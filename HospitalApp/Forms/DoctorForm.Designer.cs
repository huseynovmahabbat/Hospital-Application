namespace HospitalApp.Forms
{
    partial class DoctorForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbmx_patients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_receipttime = new System.Windows.Forms.DateTimePicker();
            this.rtxbx_description = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbmx_patients
            // 
            this.cbmx_patients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmx_patients.FormattingEnabled = true;
            this.cbmx_patients.Location = new System.Drawing.Point(129, 60);
            this.cbmx_patients.Name = "cbmx_patients";
            this.cbmx_patients.Size = new System.Drawing.Size(339, 24);
            this.cbmx_patients.TabIndex = 2;
            this.cbmx_patients.SelectedIndexChanged += new System.EventHandler(this.cbmx_patients_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patients :";
            // 
            // dtp_receipttime
            // 
            this.dtp_receipttime.Enabled = false;
            this.dtp_receipttime.Location = new System.Drawing.Point(129, 200);
            this.dtp_receipttime.Name = "dtp_receipttime";
            this.dtp_receipttime.Size = new System.Drawing.Size(339, 22);
            this.dtp_receipttime.TabIndex = 4;
            // 
            // rtxbx_description
            // 
            this.rtxbx_description.Location = new System.Drawing.Point(129, 323);
            this.rtxbx_description.Name = "rtxbx_description";
            this.rtxbx_description.Size = new System.Drawing.Size(339, 136);
            this.rtxbx_description.TabIndex = 5;
            this.rtxbx_description.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Receipt Time :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description :";
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 642);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxbx_description);
            this.Controls.Add(this.dtp_receipttime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbmx_patients);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoctorForm_FormClosed);
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbmx_patients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_receipttime;
        private System.Windows.Forms.RichTextBox rtxbx_description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}