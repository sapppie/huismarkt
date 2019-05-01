using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class GetInfo
    {
        string query;
        SQLConn sQLConn = new SQLConn();
        House house = new House();
        public void getAdresses()
        {
            string street  =QueryGet(house.street);
            string housenr =QueryGet(house.housenr);
            string city    =QueryGet(house.city);
            string postcode=QueryGet(house.postcode);
        }
        public void getHouseInfo()
        {
            SqlConnection conn = new SqlConnection(sQLConn.connstring());
            query = "";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);

        }
        public string QueryGet(string obj)
        {
            SqlConnection conn = new SqlConnection(sQLConn.connstring());

            string query = "Select '"+obj+"' from Houses ";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            return query;
        }
    }

}
