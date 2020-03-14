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
    public partial class AdminDetails : Form
    {
        public AdminDetails()
        {
            InitializeComponent();
        }

        private void AdminDetails_Load(object sender, EventArgs e)
        {
            model.FeeCheck fc = new model.FeeCheck();
            string admin = "Admin";
            string query = "select * from info where Role = '"+admin+"'";
            dataGridView1.DataSource = fc.datagrid(query);
        }
    }
}
