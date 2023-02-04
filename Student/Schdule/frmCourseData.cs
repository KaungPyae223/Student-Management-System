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
    public partial class frmCourseData : Form
    {
        public frmCourseData()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Boolean is_Edit = false;
        public int ID = 0;
        String SP;
        clsMainDb objclsMain = new clsMainDb();
        private void btnSave_Click(object sender, EventArgs e)
        {
            int Ok;
            if (txtCourseName.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please type a course Name");
                txtCourseName.Focus();
            }
            else if (txtDuriation.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please type a Duriation");
                txtDuriation.Focus();
            }
            else if (txtCourseFee.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please type a Course Fee");
                txtCourseFee.Focus();
            }
            else if (int.TryParse(txtCourseFee.Text.ToString(),out Ok)==false)
            {
                MessageBox.Show("Course fee must be a number");
                txtCourseFee.Focus();
            }
            else if (txtShortName.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please type a Short Name");
                txtShortName.Focus();
            }
            else if (txtDetail.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please type a Short Detail");
                txtDetail.Focus();
            }
            else
            {
                DataTable DT = new DataTable();
                SP = string.Format("Select_Course N'{0}',N'{1}',N'{2}'", txtCourseName.Text.ToString(), txtShortName.Text.ToString(), "1");
                DT = objclsMain.SelectData(SP);
                if (DT.Rows.Count > 0 && is_Edit==false)
                    MessageBox.Show("This data is already exit");
                else
                {
                    clsCourse objClsCourse = new clsCourse();
                    objClsCourse.ID = ID;
                    objClsCourse.Fee = Convert.ToInt32(txtCourseFee.Text.ToString());
                    objClsCourse.Duriation = txtDuriation.Text;
                    objClsCourse.Detail = txtDetail.Text;
                    objClsCourse.CourseName = txtCourseName.Text;
                    objClsCourse.shortform = txtShortName.Text;
                    if (is_Edit)
                    {
                        objClsCourse.action = 0;
                        objClsCourse.saveData();
                        MessageBox.Show("Successfully Edied", "Successfully");
                    }
                    else
                    {
                        objClsCourse.action = 1;
                        objClsCourse.saveData();
                        MessageBox.Show("Successfully Saved", "Successfully");
                    }
                    this.Close();
                }
            }
            
        }

        
    }
}
