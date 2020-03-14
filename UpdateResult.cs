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
    public partial class UpdateResult : Form
    {
        public UpdateResult()
        {
            InitializeComponent();
        }
        model.Connection con;
        private void UpdateResult_Load(object sender, EventArgs e)
        {
            con = new model.Connection();
            con.GetConnection();            
        }
        model.Result rs = new model.Result();
        private void button1_Click(object sender, EventArgs e)
        {
            rs.id = textBox1.Text;
            rs.Class = textBox2.Text;
            rs.Marksobt = Convert.ToInt32( textBox3.Text);
            rs.total = Convert.ToInt32(textBox4.Text);
            rs.percentage = Convert.ToDouble(textBox5.Text);
            con.ExecuteQuery("insert into Result values('" +rs.id + "','" + rs.Class + "','" + rs.Marksobt + "','" + rs.total + "','" + rs.percentage + "')");
            MessageBox.Show("successfully inserted data results");
        }
    }
}
//con.ExecuteQuery("insert into info values('" + s.ID + "','" + s.Name + "','" + s.Userid + "','" + s.Pass + "','" + s.gender + "','" + s.contact + "','" + s.address + "','" + s.date + "','" + s.role + "','" + s.Class + "')");