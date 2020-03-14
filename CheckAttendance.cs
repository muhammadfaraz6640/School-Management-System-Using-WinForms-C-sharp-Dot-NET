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
    public partial class CheckAttendance : Form
    {
        string idee;
        public CheckAttendance(string id)
        {
            InitializeComponent();
            idee = id;
        }

        private void CheckAttendance_Load(object sender, EventArgs e)
        {
            string query = "select * from attendance where ID = '"+idee+"'   ";
            model.FeeCheck fd = new model.FeeCheck();
            dataGridView1.DataSource = fd.datagrid(query);
        }
    }
}
