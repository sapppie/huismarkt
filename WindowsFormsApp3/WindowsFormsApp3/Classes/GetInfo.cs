using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuizenmarktApp
{
    class GetInfo
    {
        static SQLCAC sQLConn = new SQLCAC();
        public static SqlConnection conn = new SqlConnection(sQLConn.Connstring());
        SqlCommand command;

        public void GetMyHouse()
        {
            
        }

        public void Bid(string id)
        {
            string query = "Insert into ";
            if (conn.State != ConnectionState.Open)
                conn.Open();
            command = new SqlCommand(query, conn);
        }
        
        public void getHouseInfo()
        {
            

        }
        public string QueryGet(string obj)
        {
            string query = "Select '"+obj+"' from Houses ";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            return query;
        }
    }

}
