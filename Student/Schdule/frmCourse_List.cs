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
namespace Student.Schdule
{
    public partial class frmCourse_List : Form
    {
        public frmCourse_List()
        {
            InitializeComponent();
        }
        clsMainDb objClsMain = new clsMainDb();
        String SP;
        private void frmCourse_List_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            frmCourseData frm = new frmCourseData();
            frm.ShowDialog();
            showData();
        }
        public void showData()
        {
            SP = string.Format("Select_Course N'{0}',N'{1}',N'{2}'", "0", "0", "0");
            dgvCourse.DataSource = objClsMain.SelectData(SP);
            dgvCourse.Columns[0].Width = (dgvCourse.Width / 100) * 5;
            dgvCourse.Columns[1].Visible = false;
            dgvCourse.Columns[2].Width = (dgvCourse.Width / 100) * 40;
            dgvCourse.Columns[3].Width = (dgvCourse.Width / 100) * 20;
            dgvCourse.Columns[4].Width = (dgvCourse.Width / 100) * 20;
            dgvCourse.Columns[5].Visible = false;
            dgvCourse.Columns[6].Width = (dgvCourse.Width / 100) * 20;
            
            objClsMain.toolStripTextBoxdata(ref tstSearchWith, SP, "CourseName");
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            showEntry();
            showData();
        }
        public void showEntry()
        {
            if (dgvCourse.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Please select a course to edit");
            }
            else
            {
                frmCourseData frm = new frmCourseData();
                frm.txtCourseFee.Text = dgvCourse.CurrentRow.Cells[4].Value.ToString();
                frm.txtCourseName.Text = dgvCourse.CurrentRow.Cells[2].Value.ToString();
                frm.txtDetail.Text = dgvCourse.CurrentRow.Cells[5].Value.ToString();
                frm.txtDuriation.Text = dgvCourse.CurrentRow.Cells[3].Value.ToString();
                frm.txtShortName.Text = dgvCourse.CurrentRow.Cells[6].Value.ToString();
                frm.is_Edit = true;
                frm.ID = Convert.ToInt32(dgvCourse.CurrentRow.Cells[1].Value.ToString());
                frm.btnSave.Text = "Edit";
                frm.txtCourseName.Enabled = false;
                frm.txtShortName.Enabled = false;
                frm.ShowDialog();
                showData();
            }
        }

        

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dgvCourse.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Please select a row to delete");
            }
            else
            {
                if (MessageBox.Show("Are you sure to Delete", "comfirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    clsCourse objclsCourse = new clsCourse();
                    objclsCourse.ID = Convert.ToInt32(dgvCourse.CurrentRow.Cells[1].Value.ToString());
                    objclsCourse.action = 2;
                    objclsCourse.saveData();
                    MessageBox.Show("Successfully deleted");
                    showData();
                }
            }
        }

        private void tstSearchWith_TextChanged(object sender, EventArgs e)
        {
            SP = string.Format("Select_Course N'{0}',N'{1}',N'{2}'", tstSearchWith.Text.ToString(),"0", "2");
            dgvCourse.DataSource = objClsMain.SelectData(SP);
        }

    }
}
