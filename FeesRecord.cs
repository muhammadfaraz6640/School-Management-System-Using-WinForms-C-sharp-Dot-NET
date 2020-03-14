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
    public partial class FeesRecord : Form
    {
        public FeesRecord()
        {
            InitializeComponent();
        }

        private void FeesRecord_Load(object sender, EventArgs e)
        {
            model.FeeCheck fc = new model.FeeCheck();
            string admin = "Admin";
            string query = "select info.Name , fees.Jan  , fees.Feb , fees.Mar , fees.Apr , fees.May , fees.Jun , fees.Jul , fees.Aug , fees.Sep , fees.Oct , fees.Nov , fees.Dec from info inner join fees on info.ID = fees.ID where fees.Role = '"+admin+"' ";
            dataGridView1.DataSource = fc.datagrid(query);
        }
    }
}
