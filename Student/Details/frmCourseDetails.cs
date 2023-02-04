using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student.Details
{
    public partial class frmCourseDetails : Form
    {
        public frmCourseDetails()
        {
            InitializeComponent();
        }
        public String na="";
        public String Duriation="";
        public String Fee="";
        public String ShortForm="";
        public String Details="";

        private void frmCourseDetails_Load(object sender, EventArgs e)
        {
            lblname.Text = na;
            lblDuriation.Text = Duriation;
            lblFee.Text = Fee;
            lblShort.Text = ShortForm;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Details, "Course Details");
        }
    }
}
