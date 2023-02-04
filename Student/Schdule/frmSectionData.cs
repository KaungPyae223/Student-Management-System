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
    public partial class frmSectionData : Form
    {
        public frmSectionData()
        {
            InitializeComponent();
        }
        public Boolean is_Edit = false;
        public int ID =0;
        String SP;
        clsMainDb objClsMain = new clsMainDb();
        DataTable DT = new DataTable();
        private void btnSave_Click(object sender, EventArgs e)
        {
            String day = "";
            Boolean b = false;
            
            if (chkSun.Checked)
            {   
                day += "Sun";
                b = true;
            }
            if (chkMonday.Checked)
            {
                day += " Mon";
                b = true;
            }
            if (chkThu.Checked)
            {
                day += " Tue";
                b = true;
            }
            if (chkWeb.Checked)
            {
                day += " Web";
                b = true;
            }
            if (chkThur.Checked)
            {
                day += " Thur";
                b = true;
            }
            if (chkFri.Checked)
            {
                day += " Fri";
                b = true;
            }
            if (chkSat.Checked)
            {
                day += " Sat";
                b = true;
            }

            day = day.Trim();
            if (txtSectionName.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please type a Section Name", "Error");
                txtSectionName.Focus();
            }
            else if (b == false)
            {
                MessageBox.Show("Please select a name", "Error");
            }
            else
            {
                SP = string.Format("Select_Section N'{0}',N'{1}',N'{2}'", "0", txtSectionName.Text.ToString().Trim(), day);
                DT = objClsMain.SelectData(SP);
                if (DT.Rows.Count > 0 && is_Edit == false)
                    MessageBox.Show("This section is already exit");
                else
                {
                    clsSection objClsSection = new clsSection();
                    objClsSection.day = day;
                    objClsSection.id = ID;
                    objClsSection.SectionName = txtSectionName.Text.ToString().Trim();
                    if (is_Edit)
                    {
                        objClsSection.action = 1;
                        objClsSection.saveData();
                        MessageBox.Show("Successfully Edited", "Successfully");

                    }
                    else
                    {
                        objClsSection.action = 0;
                        objClsSection.saveData();
                        MessageBox.Show("Successfully Saved", "Successfully");

                    }
                }
            }
            this.Close();
        }
    }
}
