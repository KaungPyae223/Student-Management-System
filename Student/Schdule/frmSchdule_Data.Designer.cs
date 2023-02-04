namespace Student.Schdule
{
    partial class frmSchdule_Data
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
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboDate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboRoomName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCourse
            // 
            this.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(227, 55);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(364, 33);
            this.cboCourse.TabIndex = 0;
            this.cboCourse.SelectedIndexChanged += new System.EventHandler(this.cboCourse_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Schdule ID";
            // 
            // lblID
            // 
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(227, 127);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(364, 41);
            this.lblID.TabIndex = 3;
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboTime);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblAvailable);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboRoomName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.cboCourse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 587);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(227, 515);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(364, 26);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 520);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Start Date";
            // 
            // cboTime
            // 
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Location = new System.Drawing.Point(227, 429);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(364, 33);
            this.cboTime.TabIndex = 11;
            this.cboTime.SelectedIndexChanged += new System.EventHandler(this.cboTime_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Time";
            // 
            // cboDate
            // 
            this.cboDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDate.FormattingEnabled = true;
            this.cboDate.Location = new System.Drawing.Point(227, 351);
            this.cboDate.Name = "cboDate";
            this.cboDate.Size = new System.Drawing.Size(364, 33);
            this.cboDate.TabIndex = 9;
            this.cboDate.SelectedIndexChanged += new System.EventHandler(this.cboDate_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Date";
            // 
            // lblAvailable
            // 
            this.lblAvailable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(227, 271);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(364, 41);
            this.lblAvailable.TabIndex = 7;
            this.lblAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Available";
            // 
            // cboRoomName
            // 
            this.cboRoomName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomName.FormattingEnabled = true;
            this.cboRoomName.Location = new System.Drawing.Point(227, 203);
            this.cboRoomName.Name = "cboRoomName";
            this.cboRoomName.Size = new System.Drawing.Size(364, 33);
            this.cboRoomName.TabIndex = 5;
            this.cboRoomName.SelectedIndexChanged += new System.EventHandler(this.cboRoomName_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Room Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Location = new System.Drawing.Point(12, 618);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 83);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(82, 25);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 41);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(516, 25);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 41);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSchdule_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(707, 715);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSchdule_Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schdule Data";
            this.Load += new System.EventHandler(this.frmSchdule_Data_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboRoomName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
    }
}