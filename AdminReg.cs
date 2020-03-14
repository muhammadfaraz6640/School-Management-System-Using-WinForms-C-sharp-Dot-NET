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
    public partial class AdminReg : Form
    {
        public AdminReg()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        string gen;
        string rol = "Admin";
        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                gen = "male";
            }
            else if(radioButton3.Checked)
            {
                gen = "Female";
            }
            
        model.Admin ad = new model.Admin();
            ad.ID = textBox4.Text;
            ad.Name = textBox1.Text;
            ad.Userid = textBox2.Text;
            ad.Pass = textBox3.Text;
            ad.gender = gen;
            ad.contact = textBox5.Text;
            ad.address = textBox6.Text;
            ad.date = textBox7.Text;
            ad.role = rol;
            ad.Class = textBox8.Text;
            ad.Signup(ad);
            MessageBox.Show("successfuuly inserted data...thanks for SignUP..");
        }

        private void AdminReg_Load(object sender, EventArgs e)
        {

        }
    }
}
