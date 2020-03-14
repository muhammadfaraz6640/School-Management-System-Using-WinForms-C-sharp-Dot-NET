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
    public partial class StudentHome : Form
    {
        public StudentHome(string n ,string i, string r,string c)
        {
            InitializeComponent();
            label1.Text = n;
            label2.Text = i;
            label3.Text = r;
            label4.Text = c;
        }

        private void StudentHome_Load(object sender, EventArgs e)
        {           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckAttendance ad = new CheckAttendance(label2.Text);
            ad.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangePass cp = new ChangePass(label2.Text);
            cp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResultsStd res = new ResultsStd(label2.Text);
            res.ShowDialog();
        }
    }
}
