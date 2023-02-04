namespace Student.Register
{
    partial class frmRegister
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
            this.cboSchduleID = new System.Windows.Forms.ComboBox();
            this.lblSchduleDate = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentAddress = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SchduleID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboSchduleID
            // 
            this.cboSchduleID.FormattingEnabled = true;
            this.cboSchduleID.Location = new System.Drawing.Point(212, 40);
            this.cboSchduleID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSchduleID.Name = "cboSchduleID";
            this.cboSchduleID.Size = new System.Drawing.Size(271, 24);
            this.cboSchduleID.TabIndex = 0;
            this.cboSchduleID.SelectedIndexChanged += new System.EventHandler(this.cboSchduleID_SelectedIndexChanged);
            // 
            // lblSchduleDate
            // 
            this.lblSchduleDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSchduleDate.Location = new System.Drawing.Point(212, 95);
            this.lblSchduleDate.Name = "lblSchduleDate";
            this.lblSchduleDate.Size = new System.Drawing.Size(270, 31);
            this.lblSchduleDate.TabIndex = 1;
            // 
            // txtStudentName
            // 
            this.txtStudentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtStudentName.Location = new System.Drawing.Point(212, 158);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(271, 22);
            this.txtStudentName.TabIndex = 2;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // txtStudentAddress
            // 
            this.txtStudentAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtStudentAddress.Location = new System.Drawing.Point(212, 212);
            this.txtStudentAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentAddress.Name = "txtStudentAddress";
            this.txtStudentAddress.Size = new System.Drawing.Size(271, 22);
            this.txtStudentAddress.TabIndex = 3;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(212, 258);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(271, 81);
            this.txtNote.TabIndex = 4;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(60, 368);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(67, 27);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(415, 368);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 27);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SchduleID
            // 
            this.SchduleID.AutoSize = true;
            this.SchduleID.Location = new System.Drawing.Point(57, 42);
            this.SchduleID.Name = "SchduleID";
            this.SchduleID.Size = new System.Drawing.Size(72, 17);
            this.SchduleID.TabIndex = 7;
            this.SchduleID.Text = "SchduleID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "SchduleDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Student Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Note";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 416);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SchduleID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtStudentAddress);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblSchduleDate);
            this.Controls.Add(this.cboSchduleID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegister";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSchduleDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label SchduleID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnRegister;
        public System.Windows.Forms.ComboBox cboSchduleID;
        public System.Windows.Forms.TextBox txtStudentName;
        public System.Windows.Forms.TextBox txtStudentAddress;
        public System.Windows.Forms.TextBox txtNote;
    }
}