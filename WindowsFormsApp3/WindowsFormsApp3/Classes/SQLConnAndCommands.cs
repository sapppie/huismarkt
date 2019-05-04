using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuizenmarktApp
{
    class SQLCAC
    {
        public string Connstring()
        {
            return @"Data Source=housebase.database.windows.net;Initial Catalog=HuizenMarkt;User ID=nhlandriesvdsluis;Password=Welkom!2;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        public string insertHouse()
        {
            //House h = new House();
            return null;
        }
        public SQLCAC()
        {
            //SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            //DataTable dtbl = new DataTable();
            //sda.Fill(dtbl);            
        }
        public void Insert(string query)
        {

        }
        public void Get(string query)
        {

        }
    }
}
