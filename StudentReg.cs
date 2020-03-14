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
    public partial class StudentReg : Form
    {
        public StudentReg()
        {
            InitializeComponent();
        }
        string gen;
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                gen = "male";
            }
            else if (radioButton3.Checked)
            {
                gen = "Female";
            }
            model.Student st = new model.Student();
            st.ID = textBox4.Text;
            st.Name = textBox1.Text;
            st.Userid = textBox2.Text;
            st.Pass = textBox3.Text;
            st.gender = gen;
            st.contact = textBox5.Text;
            st.address = textBox6.Text;
            st.date = textBox7.Text;
            st.Class = textBox8.Text;
            st.Signup(st);
            MessageBox.Show("successfuuly inserted data...thanks for SignUP..");
        }

        private void StudentReg_Load(object sender, EventArgs e)
        {

        }
    }
}
