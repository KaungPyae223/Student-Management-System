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
using Student.ReportData;
namespace Student.Schdule
{
    public partial class frmRoomList : Form
    {
        public frmRoomList()
        {
            InitializeComponent();
        }
        String SP;
        clsMainDb objClsmainDB = new clsMainDb();

        private void tsbNew_Click(object sender, EventArgs e)
        {
            frmRoomData frm = new frmRoomData();
            frm.ShowDialog();
            ShowData();
        }

        
        private void frmRoomList_Load(object sender, EventArgs e)
        {
            ShowData();
        }
        public void ShowData()
        {
            SP = string.Format("Select_Room N'{0}',N'{1}'", "0", "1");
            dgvSection.DataSource = objClsmainDB.SelectData(SP);
            
            dgvSection.Columns[0].Width = (dgvSection.Width / 100) * 5;
            dgvSection.Columns[1].Visible = false;
            dgvSection.Columns[2].Width = (dgvSection.Width / 100) * 50;
            dgvSection.Columns[3].Width = (dgvSection.Width / 100) * 50;
            objClsmainDB.toolStripTextBoxdata(ref tstSearchWith, SP, "RoomName");
            
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            showEntry();
            ShowData();
        }
        public void showEntry()
        {
            if (dgvSection.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Plesae select a row to edit");
            }
            else
            {
                frmRoomData frm = new frmRoomData();
                frm.txtRoomName.Text = dgvSection.CurrentRow.Cells[2].Value.ToString();
                frm.txtAvailable.Text = dgvSection.CurrentRow.Cells[3].Value.ToString();
                frm.isEdit = true;
                frm.btnSave.Text = "Edit";
                frm.ID = Convert.ToInt32(dgvSection.CurrentRow.Cells[1].Value.ToString());
                frm.ShowDialog();
            }
            
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dgvSection.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Please select a row to delete");
            }
            else
            {
                if (MessageBox.Show("Are you sure to Delete", "comfirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    clsRoom objclsRoom = new clsRoom();
                    objclsRoom.ID = Convert.ToInt32(dgvSection.CurrentRow.Cells[1].Value.ToString());
                    objclsRoom.action = 2;
                    objclsRoom.SaveData();
                    MessageBox.Show("Successfully deleted");
                    ShowData();
                }
            }
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            
        }

        private void tstSearchWith_TextChanged(object sender, EventArgs e)
        {
            SP = string.Format("Select_Room N'{0}',N'{1}'", tstSearchWith.Text.ToString(), "2");
            dgvSection.DataSource = objClsmainDB.SelectData(SP);
        }

        

        
    }
}
