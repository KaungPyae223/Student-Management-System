namespace Student
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsbfile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddTime = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddSection = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSchdule = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegisteration = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPannel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbfile,
            this.tsbUser,
            this.mnuData,
            this.mnuRegisteration});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(672, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsbfile
            // 
            this.tsbfile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLogin,
            this.tsbExit});
            this.tsbfile.Name = "tsbfile";
            this.tsbfile.Size = new System.Drawing.Size(44, 24);
            this.tsbfile.Text = "File";
            // 
            // tsbLogin
            // 
            this.tsbLogin.Name = "tsbLogin";
            this.tsbLogin.Size = new System.Drawing.Size(119, 24);
            this.tsbLogin.Text = "Log in";
            this.tsbLogin.Click += new System.EventHandler(this.tsbLogin_Click);
            // 
            // tsbExit
            // 
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(119, 24);
            this.tsbExit.Text = "Exit";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // tsbUser
            // 
            this.tsbUser.Name = "tsbUser";
            this.tsbUser.Size = new System.Drawing.Size(50, 24);
            this.tsbUser.Text = "User";
            this.tsbUser.Click += new System.EventHandler(this.tsbUser_Click);
            // 
            // mnuData
            // 
            this.mnuData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddTime,
            this.mnuAddSection,
            this.mnuCourse,
            this.mnuRoom,
            this.tsmSchdule});
            this.mnuData.Name = "mnuData";
            this.mnuData.Size = new System.Drawing.Size(73, 24);
            this.mnuData.Text = "Schdule";
            // 
            // mnuAddTime
            // 
            this.mnuAddTime.Name = "mnuAddTime";
            this.mnuAddTime.Size = new System.Drawing.Size(130, 24);
            this.mnuAddTime.Text = "Time";
            this.mnuAddTime.Click += new System.EventHandler(this.mnuAddTime_Click);
            // 
            // mnuAddSection
            // 
            this.mnuAddSection.Name = "mnuAddSection";
            this.mnuAddSection.Size = new System.Drawing.Size(130, 24);
            this.mnuAddSection.Text = "Section";
            this.mnuAddSection.Click += new System.EventHandler(this.mnuAddSection_Click);
            // 
            // mnuCourse
            // 
            this.mnuCourse.Name = "mnuCourse";
            this.mnuCourse.Size = new System.Drawing.Size(130, 24);
            this.mnuCourse.Text = "Course";
            this.mnuCourse.Click += new System.EventHandler(this.mnuCourse_Click);
            // 
            // mnuRoom
            // 
            this.mnuRoom.Name = "mnuRoom";
            this.mnuRoom.Size = new System.Drawing.Size(130, 24);
            this.mnuRoom.Text = "Room";
            this.mnuRoom.Click += new System.EventHandler(this.mnuRoom_Click);
            // 
            // tsmSchdule
            // 
            this.tsmSchdule.Name = "tsmSchdule";
            this.tsmSchdule.Size = new System.Drawing.Size(130, 24);
            this.tsmSchdule.Text = "Schdule";
            this.tsmSchdule.Click += new System.EventHandler(this.tsmSchdule_Click);
            // 
            // mnuRegisteration
            // 
            this.mnuRegisteration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStudent,
            this.mnuRegister});
            this.mnuRegisteration.Name = "mnuRegisteration";
            this.mnuRegisteration.Size = new System.Drawing.Size(101, 24);
            this.mnuRegisteration.Text = "Registration";
            this.mnuRegisteration.Click += new System.EventHandler(this.mnuRegisteration_Click);
            // 
            // mnuStudent
            // 
            this.mnuStudent.Name = "mnuStudent";
            this.mnuStudent.Size = new System.Drawing.Size(152, 24);
            this.mnuStudent.Text = "Student";
            this.mnuStudent.Click += new System.EventHandler(this.mnuStudent_Click_1);
            // 
            // mnuRegister
            // 
            this.mnuRegister.Name = "mnuRegister";
            this.mnuRegister.Size = new System.Drawing.Size(152, 24);
            this.mnuRegister.Text = "Register";
            this.mnuRegister.Click += new System.EventHandler(this.mnuRegister_Click);
            // 
            // mainPannel
            // 
            this.mainPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPannel.Location = new System.Drawing.Point(0, 28);
            this.mainPannel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPannel.Name = "mainPannel";
            this.mainPannel.Size = new System.Drawing.Size(672, 399);
            this.mainPannel.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 427);
            this.Controls.Add(this.mainPannel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Student Registeration form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuData;
        private System.Windows.Forms.ToolStripMenuItem mnuAddTime;
        private System.Windows.Forms.ToolStripMenuItem mnuAddSection;
        private System.Windows.Forms.ToolStripMenuItem mnuCourse;
        private System.Windows.Forms.ToolStripMenuItem mnuRoom;
        private System.Windows.Forms.ToolStripMenuItem mnuRegisteration;
        private System.Windows.Forms.Panel mainPannel;
        private System.Windows.Forms.ToolStripMenuItem tsbfile;
        private System.Windows.Forms.ToolStripMenuItem tsbUser;
        private System.Windows.Forms.ToolStripMenuItem mnuStudent;
        private System.Windows.Forms.ToolStripMenuItem mnuRegister;
        private System.Windows.Forms.ToolStripMenuItem tsmSchdule;
        private System.Windows.Forms.ToolStripMenuItem tsbLogin;
        private System.Windows.Forms.ToolStripMenuItem tsbExit;

    }
}

