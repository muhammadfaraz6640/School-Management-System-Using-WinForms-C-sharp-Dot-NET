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
    public partial class ResultsStd : Form
    {
        string identity;
        public ResultsStd(string id)
        {
            InitializeComponent();
            identity = id;
        }

        private void ResultsStd_Load(object sender, EventArgs e)
        {
            string query = "select * from Result where ID = '"+identity+"' ";
            model.FeeCheck fc = new model.FeeCheck();
            dataGridView1.DataSource = fc.datagrid(query);
        }
    }
}
