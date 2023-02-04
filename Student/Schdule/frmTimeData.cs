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
namespace Student.DBA
{
    public partial class frmTimeData : Form
    {
        public frmTimeData()
        {
            InitializeComponent();
        }
        public Boolean is_Edit =false;
        public int id = 0;
        public string st;
        string SP;
        DataTable DT;
        clsTime objClsTime = new clsTime();
        clsMainDb objClsMain = new clsMainDb();
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsTime T1 = new clsTime();
            T1.SetData(Convert.ToDateTime(dtpfirst.Value.ToLongTimeString()));
            clsTime T2 = new clsTime();
            T2.SetData(Convert.ToDateTime(dtpSecond.Value.ToLongTimeString()));
            clsTime T3 = new clsTime();
            if (T3.checktime(T1, T2))
            {
                st = (dtpfirst.Value.ToLongTimeString()+" - "+dtpSecond.Value.ToLongTimeString());
                SP = string.Format("Select_Time N'{0}',N'{1}'", st, "0");
                DT=objClsMain.SelectData(SP);
                if (DT.Rows.Count > 0 && is_Edit == false)
                    MessageBox.Show("This Item is already exit");
                else
                {
                    objClsTime.Time = st;
                    objClsTime.ID = id;
                    if (is_Edit)
                    {
                        objClsTime.action = 0;
                        objClsTime.saveData();
                        MessageBox.Show("Successfully Edited", "Successfully");
                    }
                    else
                    {
                        objClsTime.action = 1;
                        objClsTime.saveData();
                        MessageBox.Show("Successfully Saved", "Successfully");
                    }
                }
            }
            this.Close();
        }

        private void frmTimeData_Load(object sender, EventArgs e)
        {
                dtpfirst.Value = Convert.ToDateTime("00:00:00");
                dtpSecond.Value = Convert.ToDateTime("00:00:00");
        }
    }
}
