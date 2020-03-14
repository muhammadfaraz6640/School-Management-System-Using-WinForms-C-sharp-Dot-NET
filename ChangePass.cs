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
    public partial class ChangePass : Form
    {
        string identity="";
        public ChangePass(string id)
        {
            InitializeComponent();
            identity = id;
        }
        model.Connection con;
        string pp;
        private void ChangePass_Load(object sender, EventArgs e)
        {
            con = new model.Connection();
            con.GetConnection();
            OleDbCommand com = new OleDbCommand("Select * from info where ID = '"+identity+"' ", con.con);
            OleDbDataReader rd = com.ExecuteReader();            
            while (rd.Read())
            {
                pp = rd["Pass"].ToString();
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != textBox2.Text || pp != textBox1.Text)
            {
                MessageBox.Show("The Password is not Same");
            }
            else
            {
                con.ExecuteQuery("UPDATE info set [Pass]='" + textBox3.Text + "' where ID = '" + identity + "'");
                MessageBox.Show("Passwrod updated successfully");
            }
        }
    }
}
