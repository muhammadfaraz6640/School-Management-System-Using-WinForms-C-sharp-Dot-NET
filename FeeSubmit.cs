using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace school_management_system
{
    public partial class FeeSubmit : Form
    {
        public FeeSubmit()
        {
            InitializeComponent();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        model.Connection con = new model.Connection();
        model.FeeCheck f = new model.FeeCheck();
        private void FeeSubmit_Load(object sender, EventArgs e)
        {
            string query = "select * from info";
            dataGridView1.DataSource = f.datagrid(query);
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            
                
                f.ID = textBox15.Text;
                f.year = textBox3.Text;
                f.role = textBox14.Text;
                f.Jan = textBox2.Text;
                f.feb = textBox1.Text;
                f.mar = textBox5.Text;
                f.apr = textBox4.Text;
                f.may = textBox7.Text;
                f.jun = textBox6.Text;
                f.jul = textBox9.Text;
                f.aug = textBox8.Text;
                f.sep = textBox11.Text;
                f.oct = textBox10.Text;
                f.nov = textBox13.Text;
                f.dec = textBox12.Text;
                f.Submit(f);
                MessageBox.Show("successfully inserting data fees..");                        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.GetConnection();

                OleDbCommand com = new OleDbCommand("Select * from fees where ID = '" + textBox15.Text + "' ", con.con);
                OleDbDataReader rd = com.ExecuteReader();
                while (rd.Read())
                {
                    textBox2.Text = rd["Jan"].ToString();
                    textBox1.Text = rd["Feb"].ToString();
                    textBox5.Text = rd["Mar"].ToString();
                    textBox4.Text = rd["Apr"].ToString();
                    textBox7.Text = rd["May"].ToString();
                    textBox6.Text = rd["Jun"].ToString();
                    textBox9.Text = rd["Jul"].ToString();
                    textBox8.Text = rd["Aug"].ToString();
                    textBox11.Text = rd["Sep"].ToString();
                    textBox10.Text = rd["Oct"].ToString();
                    textBox13.Text = rd["Nov"].ToString();
                    textBox12.Text = rd["Dec"].ToString();
                    textBox3.Text = rd["Year"].ToString();
                    textBox14.Text = rd["Role"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            model.Connection con = new model.Connection();
            con.GetConnection();
            model.Fee fd = new model.Fee();
            fd.ID = textBox15.Text;
            fd.role = textBox14.Text;
            fd.year = textBox3.Text;
            fd.Jan = "not paid";
            fd.feb = "not paid";
            fd.mar = "not paid";
            fd.apr = "not paid";
            fd.may = "not paid";
            fd.jun = "not paid";
            fd.jul = "not paid";
            fd.aug = "not paid";
            fd.sep = "not paid";
            fd.oct = "not paid";
            fd.nov = "not paid";
            fd.dec = "not paid";
            con.ExecuteQuery("insert into fees values('" + fd.ID + "','" + fd.year + "','" + fd.role + "','" + fd.Jan + "','" + fd.feb + "','" + fd.mar + "','" + fd.apr + "','" + fd.may + "','" + fd.jun + "','" + fd.jul + "','" + fd.aug + "','" + fd.sep + "','" + fd.oct + "','" + fd.nov + "','" + fd.dec + "')");
            MessageBox.Show("successfully initialize the person");
        }
    }
}
