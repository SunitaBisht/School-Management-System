using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace SchoolManagement
{
    class mycon
    {
        public OleDbConnection conn()
        {
            OleDbConnection con = new OleDbConnection("provider = Microsoft.Jet.OLEDB.4.0; Data Source=E:/ssm/ssm.mdb");       //fixed code or location name(path)
           con.Open();
            return con;
        }
        public int putData(String sqlcmd, OleDbConnection con)                               //put data create code se    //data le rha hai
        {
            OleDbCommand com = new OleDbCommand(sqlcmd, con);
            int n = com.ExecuteNonQuery();                                                    //use executenonquery means change table data
            return n;
        }
        public OleDbDataReader getData(String sqlcmd, OleDbConnection con)               
        {                                                                                           //data fetch krke layega or yha fill kr degi dr me
            OleDbCommand com = new OleDbCommand(sqlcmd, con);
            OleDbDataReader dr = com.ExecuteReader(); 
            return dr;
        }
        public  DataTable getTable(String sqlcmd, OleDbConnection con)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter dapt = new OleDbDataAdapter(sqlcmd,con);
            dapt.Fill(dt);
            return (dt);
        }
    }
}
