using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using school_management_system.model;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Data.OleDb;
namespace school_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string r;
        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                r = "Admin";
            }
            else if(radioButton2.Checked)
            {
                r = "Student";
            }
            model.Login log = new model.Login();
            log.userid = textBox1.Text;
            log.Password = textBox2.Text;
            log.role = r;
            model.Connection con = new Connection();
            con.GetConnection();
            log.GetLogin(log);          
            if (log.cond == true && radioButton1.Checked )
            {
                MessageBox.Show("Welcome Admin....!");
                log.userid = textBox1.Text;
                log.Password = textBox2.Text;
                string nam = "";
                string id = "";
                string roll = "";                
                OleDbCommand com = new OleDbCommand("Select * from info where UserID ='" + log.userid + "'and Pass = '" + log.Password + "' and role = '" + log.role + "' ", con.con);
                OleDbDataReader rd = com.ExecuteReader();
                while (rd.Read())
                {
                    nam = rd["Name"].ToString();
                    id = rd["ID"].ToString();
                    roll = rd["role"].ToString();                    
                }                               
                AdminHome hom = new AdminHome(nam,roll,id);
                hom.ShowDialog();
            }
            else if (log.cond == true && radioButton2.Checked)
            {
                MessageBox.Show("Welcome Student....!");
                log.userid = textBox1.Text;
                log.Password = textBox2.Text;
                string nam ="";
                string id="";
                string roll="";
                string cl="";
                OleDbCommand com = new OleDbCommand("Select * from info where UserID ='" + log.userid + "'and Pass = '" + log.Password + "' and role = '" + log.role + "' ", con.con);
                OleDbDataReader rd = com.ExecuteReader();
                while (rd.Read())
                {
                    nam = rd["Name"].ToString();
                     id = rd["ID"].ToString();
                     roll = rd["role"].ToString();
                     cl = rd["Class"].ToString();
                }
                StudentHome std = new StudentHome(nam, id, roll, cl);
                std.ShowDialog();

            }
            else
            {
                MessageBox.Show("Invalid User Id Or Password");
            }
        }        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
    }

