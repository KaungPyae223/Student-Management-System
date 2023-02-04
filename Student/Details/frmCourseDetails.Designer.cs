namespace Student.Details
{
    partial class frmCourseDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCourseDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblShort = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.lblDuriation = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.btnDetail = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslData = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmAllData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpcommig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblShort);
            this.panel1.Controls.Add(this.lblFee);
            this.panel1.Controls.Add(this.lblDuriation);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.btnDetail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1473, 92);
            this.panel1.TabIndex = 0;
            // 
            // lblShort
            // 
            this.lblShort.AutoSize = true;
            this.lblShort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShort.Location = new System.Drawing.Point(1190, 37);
            this.lblShort.Name = "lblShort";
            this.lblShort.Size = new System.Drawing.Size(70, 25);
            this.lblShort.TabIndex = 8;
            this.lblShort.Text = "label5";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFee.Location = new System.Drawing.Point(956, 37);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(70, 25);
            this.lblFee.TabIndex = 7;
            this.lblFee.Text = "label5";
            // 
            // lblDuriation
            // 
            this.lblDuriation.AutoSize = true;
            this.lblDuriation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuriation.Location = new System.Drawing.Point(707, 37);
            this.lblDuriation.Name = "lblDuriation";
            this.lblDuriation.Size = new System.Drawing.Size(70, 25);
            this.lblDuriation.TabIndex = 6;
            this.lblDuriation.Text = "label5";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(133, 37);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(70, 25);
            this.lblname.TabIndex = 5;
            this.lblname.Text = "label5";
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDetail.Location = new System.Drawing.Point(1292, 33);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(137, 37);
            this.btnDetail.TabIndex = 4;
            this.btnDetail.Text = "CourseDetail";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1095, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Short Form";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(858, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course Fee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Duriation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1473, 428);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1473, 391);
            this.dataGridView1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslData});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1473, 37);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslData
            // 
            this.tslData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAllData,
            this.tsmUpcommig,
            this.tsmHistory});
            this.tslData.Image = ((System.Drawing.Image)(resources.GetObject("tslData.Image")));
            this.tslData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslData.Name = "tslData";
            this.tslData.Size = new System.Drawing.Size(103, 34);
            this.tslData.Text = "All Data";
            // 
            // tsmAllData
            // 
            this.tsmAllData.Name = "tsmAllData";
            this.tsmAllData.Size = new System.Drawing.Size(249, 34);
            this.tsmAllData.Text = "All Data";
            // 
            // tsmUpcommig
            // 
            this.tsmUpcommig.Name = "tsmUpcommig";
            this.tsmUpcommig.Size = new System.Drawing.Size(249, 34);
            this.tsmUpcommig.Text = "Upcomming Data";
            // 
            // tsmHistory
            // 
            this.tsmHistory.Name = "tsmHistory";
            this.tsmHistory.Size = new System.Drawing.Size(249, 34);
            this.tsmHistory.Text = "History";
            // 
            // frmCourseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCourseDetails";
            this.Text = "CourseDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCourseDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton tslData;
        private System.Windows.Forms.ToolStripMenuItem tsmAllData;
        private System.Windows.Forms.ToolStripMenuItem tsmUpcommig;
        private System.Windows.Forms.ToolStripMenuItem tsmHistory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblShort;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Label lblDuriation;
        private System.Windows.Forms.Label lblname;
    }
}