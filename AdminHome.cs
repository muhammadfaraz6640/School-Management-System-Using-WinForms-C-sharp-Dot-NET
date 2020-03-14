using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system
{
    public partial class AdminHome : Form
    {
        public AdminHome(string n, string r, string i)
        {
            InitializeComponent();
            label4.Text = n;
            label5.Text = i;
            label6.Text = r;            
        }

        private void adminSignupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminReg reg = new AdminReg();
            reg.ShowDialog();
        }

        private void studentSignUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentReg regg = new StudentReg();
            regg.ShowDialog();
        }

        private void feeSubmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeeSubmit sub = new FeeSubmit();
            sub.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminDetails ad = new AdminDetails();
            ad.ShowDialog();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentDetails sd = new StudentDetails();
            sd.ShowDialog();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeesRecord fd = new FeesRecord();
            fd.ShowDialog();
        }

        private void feeRecordStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeeStudent std = new FeeStudent();
            std.ShowDialog();
        }

        private void updateAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendance at = new Attendance();
            at.ShowDialog();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }

        private void uodateResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateResult res = new UpdateResult();
            res.ShowDialog();
        }
    }
}
