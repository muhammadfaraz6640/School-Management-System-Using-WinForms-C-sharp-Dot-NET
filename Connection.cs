using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace school_management_system.model
{
    class Connection
    {
        public OleDbConnection con = new OleDbConnection();
        public OleDbConnection GetConnection()
        {
            if (con.ConnectionString == "")
            {
                con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/Haroon Traders/Documents/school management system.accdb; Persist Security Info = False");
                con.Open();
            }
            return con;
        }
        public void ExecuteQuery(string query)
        {
            OleDbCommand com = new OleDbCommand(query, con);
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
