﻿using System;
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
        SqlConnection sqlcon = new SqlConnection(@"Data Source=housebase.database.windows.net;Initial Catalog=HuizenMarkt;User ID=nhlandriesvdsluis;Password=Welkom!2;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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
            query = "";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

        }
        public string QueryGet(string obj)
        {
            string query = "Select '"+obj+"' from Houses ";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            return query;
        }
    }

}
