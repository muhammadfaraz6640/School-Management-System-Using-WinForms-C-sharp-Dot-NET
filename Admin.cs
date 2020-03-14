using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_management_system.model
{
    class Admin : Register
    {
        
        public void Signup(Admin s)
        {
            Connection con = new Connection();
            con.GetConnection();
            con.ExecuteQuery("insert into info values('" + s.ID + "','" + s.Name + "','" + s.Userid + "','" + s.Pass + "','" + s.gender + "','" + s.contact + "','" + s.address + "','" + s.date + "','" + s.role + "','" + s.Class + "')");
        }
    }
}
