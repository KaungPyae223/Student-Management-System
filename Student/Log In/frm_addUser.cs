using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student.DBA;
namespace Student.Log_In
{
   
    public partial class frm_addUser : Form
    {
        frmMain frm = new frmMain();
        public frm_addUser()
        {
            InitializeComponent();
        }

        public String userLevel;

        private void frm_addUser_Load(object sender, EventArgs e)
        {
            showUser();
        }
        public void showUser()
        {
            chkLevel.Items.Clear();
            for(int i = 1;i< frm.menuStrip1.Items.Count;i++)
            {
                ToolStripMenuItem mnumain = (ToolStripMenuItem)frm.menuStrip1.Items[i];
                chkLevel.Items.Add(mnumain.Text.ToString());
            }
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            userLevel = string.Empty;
            foreach (object itemChecked in chkLevel.CheckedItems)
            {
                userLevel = userLevel + itemChecked.ToString() + " ";
            }
            if (txtName.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please type your name");
                txtName.Focus();
            }
            else if (txtPass.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please type your password");
                txtPass.Focus();
            }
            else if (txtComfirm.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please type your comfirm password");
                txtComfirm.Focus();
            }
            else if (txtComfirm.Text.Trim().ToString() != txtPass.Text.ToString())
            {
                MessageBox.Show("Password and comfirm have to be same");
                txtPass.Focus();
                txtPass.SelectAll();
            }
            else if (userLevel.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please Select a user Level");
            }
            else
            {
                if (MessageBox.Show("Please comfirm", "Comfirm",  MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    clsUser objclsUser = new clsUser();
                    objclsUser.name = txtName.Text;
                    objclsUser.Level = userLevel;
                    objclsUser.Password = txtComfirm.Text.ToString();
                    objclsUser.Action = 1;
                    objclsUser.saveData();
                    MessageBox.Show("Successfully saved");
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
