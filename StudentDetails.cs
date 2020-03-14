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
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            model.FeeCheck fc = new model.FeeCheck();
            string query = "select * from info where Role = '" + "Student" + "' ";
            dataGridView1.DataSource = fc.datagrid(query);
        }
    }
}
//string query = "select * from info where Role = '" + role + "' ";
