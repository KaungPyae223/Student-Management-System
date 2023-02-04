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
namespace Student.Register
{
    public partial class frmRegisterList : Form
    {
        clsMainDb objClsMain = new clsMainDb();
        String SP;
      
        public frmRegisterList()
        {
            InitializeComponent();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            
            frmRegister frm = new frmRegister();
            frm.ShowDialog();
            showdata();
        }
        public void showdata()
        {
            SP = string.Format("Select_Register N'{0}',N'{1}',N'{2}',N'{3}'", "0", "0", "0", "2");
            dgvRegisterList.DataSource = objClsMain.SelectData(SP);

            dgvRegisterList.DataSource = objClsMain.SelectData(SP);
            dgvRegisterList.Columns[0].Width = (dgvRegisterList.Width / 100) * 5;
            dgvRegisterList.Columns[1].Width = (dgvRegisterList.Width / 100) * 10;
            dgvRegisterList.Columns[2].Visible = false;
            dgvRegisterList.Columns[3].Width = (dgvRegisterList.Width / 100) * 15;
            dgvRegisterList.Columns[4].Width = (dgvRegisterList.Width / 100) * 10;
            dgvRegisterList.Columns[5].Width = (dgvRegisterList.Width / 100) * 10;
            dgvRegisterList.Columns[6].Width = (dgvRegisterList.Width / 100) * 20;
            dgvRegisterList.Columns[7].Width = (dgvRegisterList.Width / 100) * 15;
            dgvRegisterList.Columns[8].Width = (dgvRegisterList.Width / 100) * 15;
            dgvRegisterList.Columns[9].Visible = false;
            dgvRegisterList.Columns[10].Visible = false;
            dgvRegisterList.Columns[11].Visible = false;


            objClsMain.toolStripTextBoxdata(ref tstSearchWith, SP, "SchduleID");
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dgvRegisterList.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Please select a row to delete");
            }
            else
            {
                if (MessageBox.Show("Are you sure to Delete", "comfirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    clsRegister objclsCourse = new clsRegister();
                    objclsCourse.RID = Convert.ToInt32(dgvRegisterList.CurrentRow.Cells[1].Value.ToString());
                    objclsCourse.action = 1;
                    objclsCourse.SaveData();
                    MessageBox.Show("Successfully deleted");
                    showdata();
                }
            }
        }

        private void frmRegisterList_Load(object sender, EventArgs e)
        {
            showdata();


        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            showEntry();
            showdata();
        }
        public void showEntry()
        {
            if (dgvRegisterList.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Plesae select a row to edit");
            }
            else
            {
                frmRegister frm = new frmRegister();
                frm.isEdit = true;
                frm.btnRegister.Text = "Edit";
                frm.txtStudentAddress.Text = dgvRegisterList.CurrentRow.Cells["Address"].Value.ToString();
                frm.txtStudentName.Text = dgvRegisterList.CurrentRow.Cells["Name"].Value.ToString();
                frm.txtNote.Text = dgvRegisterList.CurrentRow.Cells["note"].Value.ToString();
                frm.Select = dgvRegisterList.CurrentRow.Cells["SchduleID"].Value.ToString();
                frm.RegistrationID = Convert.ToInt32(dgvRegisterList.CurrentRow.Cells["RegistrationID"].Value.ToString());
                frm.ShowDialog();
            }

        }

        private void tsmSchduleID_Click(object sender, EventArgs e)
        {
            tsbSearch.Text = "SchduleID";
            SP= string.Format("Select_Register N'{0}',N'{1}',N'{2}',N'{3}'", "0", "0", "0", "3");
            objClsMain.toolStripTextBoxdata(ref tstSearchWith, SP, "SchduleID");
        }

        private void tsmStudentID_Click(object sender, EventArgs e)
        {
            tsbSearch.Text = "Student Name";
            SP = string.Format("Select_Register N'{0}',N'{1}',N'{2}',N'{3}'", "0", "0", "0", "4");
            objClsMain.toolStripTextBoxdata(ref tstSearchWith, SP, "Name");
        }

        private void tstSearchWith_TextChanged(object sender, EventArgs e)
        {
            if (tsbSearch.Text == "SchduleID")
            {
                SP = string.Format("Select_Register N'{0}',N'{1}',N'{2}',N'{3}'", tstSearchWith.Text.Trim().ToString(), "0", "0", "5");
            }
            else if (tsbSearch.Text == "Student Name")
            {
                SP = string.Format("Select_Register N'{0}',N'{1}',N'{2}',N'{3}'", tstSearchWith.Text.Trim().ToString(), "0", "0", "6");
            }
            else if (tsbSearch.Text == "Course Name")
            {
                SP = string.Format("Select_Register N'{0}',N'{1}',N'{2}',N'{3}'", tstSearchWith.Text.Trim().ToString(), "0", "0", "8");
            }
            else if (tsbSearch.Text == "User Name")
            {
                SP = string.Format("Select_Register N'{0}',N'{1}',N'{2}',N'{3}'", tstSearchWith.Text.Trim().ToString(), "0", "0", "10");
            }

            dgvRegisterList.DataSource = objClsMain.SelectData(SP);
        }

        private void tsmCourseName_Click(object sender, EventArgs e)
        {
            tsbSearch.Text = "Course Name";
            SP = string.Format("Select_Register N'{0}',N'{1}',N'{2}',N'{3}'", "0", "0", "0", "7");
            objClsMain.toolStripTextBoxdata(ref tstSearchWith, SP, "CourseName");
        }

        private void tsmUserName_Click(object sender, EventArgs e)
        {
            tsbSearch.Text = "User Name";
            SP = string.Format("Select_Register N'{0}',N'{1}',N'{2}',N'{3}'", "0", "0", "0", "9");
            objClsMain.toolStripTextBoxdata(ref tstSearchWith, SP, "UserName");

        }
    }
}
