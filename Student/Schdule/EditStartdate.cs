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
using Student.Schdule;
namespace Student.Schdule
{
    public partial class EditStartdate : Form
    {
        String SP;
        DataTable DT;
        clsMainDb objClsMain = new clsMainDb();
        public EditStartdate()
        {
            InitializeComponent();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            SP = string.Format("Select_Schdule N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", "0", dateTimePicker2.Value.ToShortDateString(), "5", "0", "0");
            DT = objClsMain.SelectData(SP);
            int no = Convert.ToInt32(DT.Rows[0]["NO"].ToString());
            if (no <= 0)
            {
                MessageBox.Show("Date must be greather than today");
                dateTimePicker2.Focus();
            }
            else
            {
                clsSchdule objclsSchdule = new clsSchdule();
                frmSchdule_list frm = new frmSchdule_list();
                objclsSchdule.SchduleID = Program.SchduleID;
                objclsSchdule.start = dateTimePicker2.Value.ToShortDateString();
                objclsSchdule.action = 3;
                objclsSchdule.SaveData();
                MessageBox.Show("Suvccessfully Edit");
            }
              
        }
    }
}
