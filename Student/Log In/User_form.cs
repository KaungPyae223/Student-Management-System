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
    public partial class User_form : Form
    {
        public User_form()
        {
            InitializeComponent();
        }
        string SP;
        clsMainDb objclsMain = new clsMainDb();
        clsUser obj_clsUser = new clsUser();
        private void tsbNew_Click(object sender, EventArgs e)
        {
            frm_addUser frm = new frm_addUser();
            frm.ShowDialog();
            showdata();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
        }

        private void User_form_Load(object sender, EventArgs e)
        {
            showdata();
        }
        public void showdata()
        {
            SP = string.Format("Select_User N'{0}',N'{1}',N'{2}',N'{3}'", "0", "0", "0","0");
            dgvUser.DataSource = objclsMain.SelectData(SP);
            dgvUser.Columns[0].Width = (dgvUser.Width / 100) * 5;
            dgvUser.Columns[1].Width = (dgvUser.Width / 100) * 5;
            dgvUser.Columns[2].Width = (dgvUser.Width / 100) * 47;
            dgvUser.Columns[3].Width = (dgvUser.Width / 100) * 47;
            dgvUser.Columns[4].Visible = false;
            objclsMain.toolStripTextBoxdata(ref tstSearchWith, SP, "UserName");
            
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dgvUser.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("There Is No Data");
            }
            else
            {
                if (MessageBox.Show("Are You Sure You Want To Delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    obj_clsUser.ID = Convert.ToInt32(dgvUser.CurrentRow.Cells["UserID"].Value.ToString());
                    obj_clsUser.Action = 3;
                    obj_clsUser.saveData();
                    MessageBox.Show("Successfully Delete");
                    showdata();
                }
            }
        }

        private void tstSearchWith_Click(object sender, EventArgs e)
        {

        }

        private void tstSearchWith_TextChanged(object sender, EventArgs e)
        {
            SP = string.Format("Select_User N'{0}',N'{1}',N'{2}',N'{3}'", tstSearchWith.Text.ToString(),"0","0", "3");
            dgvUser.DataSource = objclsMain.SelectData(SP);
        }
    }
}
