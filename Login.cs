using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace school_management_system.model
{
    class Login
    {
        public string userid { get; set; }
        public string Password { get; set; }
        public string role { get; set; }
        public bool cond = false;
        Connection con = new Connection();
        public void GetLogin(Login i)
        {
            con.GetConnection();
            OleDbCommand com = new OleDbCommand("Select * from info where UserID ='" + i.userid + "'and Pass = '" + i.Password + "' and role = '" + i.role + "' ", con.con);
            OleDbDataReader rd = com.ExecuteReader();
            while (rd.Read())
            {
                string Uid = rd["UserID"].ToString();
                string Pass = rd["Pass"].ToString();
                string roll = rd["role"].ToString();
                if (Uid == i.userid && Pass == i.Password && roll == i.role)
                {
                    cond = true;
                    i.role = rd["role"].ToString();
                }
            }
        }
        
    }
}
