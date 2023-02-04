namespace Student.Studentdata
{
    partial class frm_StudentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_StudentList));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tslLabel = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPhone = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGmail = new System.Windows.Forms.ToolStripMenuItem();
            this.tstSearchWith = new System.Windows.Forms.ToolStripTextBox();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbEdit,
            this.tsbDelete,
            this.tslLabel,
            this.tstSearchWith,
            this.tsbPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(808, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.AutoSize = false;
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(60, 30);
            this.tsbNew.Text = "New";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.AutoSize = false;
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(60, 30);
            this.tsbEdit.Text = "Edit";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.AutoSize = false;
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(60, 30);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tslLabel
            // 
            this.tslLabel.AutoSize = false;
            this.tslLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslLabel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmName,
            this.tsmPhone,
            this.tsmAddress,
            this.tsmGmail});
            this.tslLabel.Image = ((System.Drawing.Image)(resources.GetObject("tslLabel.Image")));
            this.tslLabel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslLabel.Name = "tslLabel";
            this.tslLabel.Size = new System.Drawing.Size(150, 30);
            this.tslLabel.Text = "Name";
            this.tslLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tslLabel.ButtonClick += new System.EventHandler(this.tslLabel_ButtonClick);
            // 
            // tsmName
            // 
            this.tsmName.Name = "tsmName";
            this.tsmName.Size = new System.Drawing.Size(152, 24);
            this.tsmName.Text = "Name";
            this.tsmName.Click += new System.EventHandler(this.tsmName_Click);
            // 
            // tsmPhone
            // 
            this.tsmPhone.Name = "tsmPhone";
            this.tsmPhone.Size = new System.Drawing.Size(152, 24);
            this.tsmPhone.Text = "Phone";
            this.tsmPhone.Click += new System.EventHandler(this.tsmPhone_Click);
            // 
            // tsmAddress
            // 
            this.tsmAddress.Name = "tsmAddress";
            this.tsmAddress.Size = new System.Drawing.Size(152, 24);
            this.tsmAddress.Text = "Address";
            this.tsmAddress.Click += new System.EventHandler(this.tsmAddress_Click);
            // 
            // tsmGmail
            // 
            this.tsmGmail.Name = "tsmGmail";
            this.tsmGmail.Size = new System.Drawing.Size(152, 24);
            this.tsmGmail.Text = "Email";
            this.tsmGmail.Click += new System.EventHandler(this.tsmGmail_Click);
            // 
            // tstSearchWith
            // 
            this.tstSearchWith.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tstSearchWith.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tstSearchWith.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstSearchWith.Name = "tstSearchWith";
            this.tstSearchWith.Size = new System.Drawing.Size(222, 33);
            this.tstSearchWith.TextChanged += new System.EventHandler(this.tstSearchWith_TextChanged);
            // 
            // tsbPrint
            // 
            this.tsbPrint.AutoSize = false;
            this.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(60, 30);
            this.tsbPrint.Text = "Print";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudent.Location = new System.Drawing.Point(0, 33);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowTemplate.Height = 28;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(808, 402);
            this.dgvStudent.TabIndex = 1;
            // 
            // frm_StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 435);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_StudentList";
            this.Text = "frm_StudentList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_StudentList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSplitButton tslLabel;
        private System.Windows.Forms.ToolStripMenuItem tsmName;
        private System.Windows.Forms.ToolStripMenuItem tsmPhone;
        private System.Windows.Forms.ToolStripMenuItem tsmAddress;
        private System.Windows.Forms.ToolStripTextBox tstSearchWith;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripMenuItem tsmGmail;

    }
}