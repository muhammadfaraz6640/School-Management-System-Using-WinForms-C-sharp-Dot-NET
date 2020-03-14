using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace school_management_system.model
{
    class FeeCheck : Fee
    {

        Connection con = new Connection();
        public void Submit(FeeCheck s)
        {
            
            con.GetConnection();
            con.ExecuteQuery("UPDATE fees set [Year]='" +s.year+ "',[Role]='" + s.role + "',[Jan]='" + s.Jan + "',[Feb]='" + s.feb + "',[Mar]='" + s.mar + "',[Apr]='" + s.apr + "',[May]='" + s.may + "',[Jun]='" + s.jun + "',[Jul]='" + s.jul + "',[Aug]='" + s.aug + "',[Sep]='" + s.sep + "',[Oct]='" + s.oct + "',[Nov]='" + s.nov + "' and [Dec]='" + s.dec + "' where ID = '"+s.ID+"'");
        }
         public DataTable datagrid(string query)
        {
            con.GetConnection();
            OleDbCommand com = new OleDbCommand(query, con.con);
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter adap = new OleDbDataAdapter(com);
            adap.Fill(dt);
            return dt;
        }
    }
}

