using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_management_system.model
{
    class Result
    {
        public string id { get; set; }
        public string Class { get; set; }
        public int Marksobt { get; set; }
        public int total { get; set; }
        public double percentage { get; set; }
        public void InsertData(string query)
        {
            Connection con = new Connection();
            con.GetConnection();
            con.ExecuteQuery(query);
        }
    }
}
