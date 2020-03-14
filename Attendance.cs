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
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }
        model.AttendanceClass at = new model.AttendanceClass();
        private void button2_Click(object sender, EventArgs e)
        {
            int attend = Convert.ToInt32(textBox3.Text);
            int total = Convert.ToInt32(textBox2.Text);           
            double res = at.CalPerDays(attend, total);
            
            textBox1.Text = res.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            at.ID = textBox4.Text;
            at.totaldays =Convert.ToInt32( textBox2.Text);
            at.daysattended = Convert.ToInt32(textBox3.Text);
            at.percent = Convert.ToDouble(textBox1.Text);
            at.monthID = Convert.ToInt32(textBox5.Text);
            at.Role = textBox6.Text;
            string q = "insert into attendance values('" + at.ID + "','" + at.daysattended + "','" + at.totaldays + "','" + at.percent + "','" + at.monthID + "','" + at.Role + "')";
            at.InsertData(q);
            MessageBox.Show("successfully inserted attendance");
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            model.FeeCheck fc = new model.FeeCheck();
            string query = "select * from attendance";
            dataGridView1.DataSource = fc.datagrid(query);
        }
    }
}
