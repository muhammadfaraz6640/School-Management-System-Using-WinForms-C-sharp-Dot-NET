using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_management_system.model
{
    class AttendanceClass
    {
        public string ID { get; set; }
        public int daysattended { get; set; }
        public int totaldays { get; set; }
        public double percent { get; set; }
        public int monthID { get; set; }
        public string Role { get; set; }

        public double CalPerDays(int att, int tot)
        {
            double div = att / tot;
            double res = div * 100;
            return div;
        }
        public void InsertData(string query)
        {
            Connection con = new Connection();
            con.GetConnection();
            con.ExecuteQuery(query);            
        }
    }
}
