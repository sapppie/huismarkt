using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuizenmarktApp.nul
{
    class hHouse
    {
        private static string _id            ;
        private static string _street        ;
        private static string _acres         ;
        private static string _housenr       ;
        private static string _rooms         ;
        private static string _garage        ;
        private static string _price         ;
        private static string _city          ;
        private static string _postcode      ;
        private static string _yearofbuilt   ;
        private static string _aboutthehouse ;
        private static string _soorthuis     ;
        private static string _energielable  ;
        private static string _garagecapacity;
        private Byte[] _image         ;
        public static string Id            {get{return _id             ;}   set{_id             = value;}}
        public static string Street        {get{return _street         ;}   set{_street         = value;}}
        public static string Acres         {get{return _acres          ;}   set{_acres          = value;}}
        public static string Housenr       {get{return _housenr        ;}   set{_housenr        = value;}}
        public static string Rooms         {get{return _rooms          ;}   set{_rooms          = value;}}
        public static string Garage        {get{return _garage         ;}   set{_garage         = value;}}
        public static string Price         {get{return _price          ;}   set{_price          = value;}}
        public static string City          {get{return _city           ;}   set{_city           = value;}}
        public static string Postcode      {get{return _postcode       ;}   set{_postcode       = value;}}
        public static string Yearofbuilt   {get{return _yearofbuilt    ;}   set{_yearofbuilt    = value;}}
        public static string Aboutthehouse {get{return _aboutthehouse  ;}   set{_aboutthehouse  = value;}}
        public static string Soorthuis     {get{return _soorthuis      ;}   set{_soorthuis      = value;}}
        public static string Energielable  {get{return _energielable   ;}   set{_energielable   = value;}}
        public static string Garagecapacity {get{return _garagecapacity ;}   set{_garagecapacity = value;}}
        public Byte[] Image         {get{return _image          ;}   set{_image          = value;}}
        public hHouse(string id, string street, string acres, string housenr, string rooms, string garage, string price, string city, string postcode, string yearofbuilt, string aboutthehouse, string soorthuis, string energielable, string garagecapacity, Byte[] image)
        {
            Id = id;
            Street = street;
            Acres = acres;
            Housenr = housenr;
            Rooms = rooms;
            Garage = garage;
            Price = price;
            City = city;
            Postcode = postcode;
            Yearofbuilt = yearofbuilt;
            Aboutthehouse = aboutthehouse;
            Soorthuis = soorthuis;
            Energielable = energielable;
            Garagecapacity = garagecapacity;
            Image = image;
        }
        public static IList houseList = new ArrayList();

        
        
        public void HouseInsert()
        {

        }
        public static void HouseGet()
        {
            string[] test;
            SQLCAC sQLConn = new SQLCAC();
            Byte[] image = new Byte[0];
            SqlConnection conn = new SqlConnection(sQLConn.Connstring());
            String query = "select * from Houses";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                houseList.Add(new hHouse(dr["id"].ToString(), dr["street"].ToString(), dr["acres"].ToString(), dr["housenr"].ToString(), dr["rooms"].ToString(), dr["garage"].ToString(), dr["price"].ToString(), dr["city"].ToString(), dr["postcode"].ToString(), dr["yearofbuilt"].ToString(), dr["abouthouses"].ToString(), dr["soorthuis"].ToString(), dr["energylable"].ToString(), dr["garagecapacity"].ToString(), (Byte[])(dr["Image"])));
            }
            int i = 0;
            
            
        }
    }
    
}
