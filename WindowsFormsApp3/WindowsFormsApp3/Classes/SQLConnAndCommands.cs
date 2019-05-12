using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuizenmarktApp
{
    public static class SQLCAC
    {

        public static void Execute(string sql)
        {
            SqlConnection conn = new SqlConnection(SQLCAC.Connstring());
            SqlCommand command;

            if (conn.State != ConnectionState.Open)
                conn.Open();
            command = new SqlCommand(sql, conn);
            int x = command.ExecuteNonQuery();
            conn.Close();
        }
        public static string Connstring()
        {
            return @"Data Source=housebase.database.windows.net;Initial Catalog=HuizenMarkt;User ID=nhlandriesvdsluis;Password=Welkom!2;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        public static string insertHouse()
        {
            //House h = new House();
            return null;
        }

        //VerkoopForm
        public static string VerkoopInsert()
        {
            return "INSERT INTO Houses(Id,Street,Acres,HouseNR,Rooms,Garage,Price,City,PostCode,YearOfBuilt,AboutHouses,SoortHuis,EnergyLable,GarageCapacity,username,Image)VALUES(";
        }
        public static string VerkoopGetUser()
        {
            return "Select username from Login";
        }

        //KopenForm

        public static string KopenGetHouses()
        {
            return "select * from Houses";
        }
        public static string KopenGetHouseID()
        {
            return "select * from Houses where id='";
        }

        //RegisterForm
        public static string RegisterMaxID()
        {
            return "SELECT MAX(Id) FROM Login";
        }
        public static string RegisterCheckUser()
        {
            return "SELECT COUNT (*) FROM Login WHERE(username = @user)";
        }        
        public static string RegisterInstert(int MaxId, string Uname, string Passwd, string Mail)
        {
            return "INSERT INTO Login(Id,username,password,email)VALUES(" + MaxId + ",'" + Uname + "','" + Passwd + "','" + Mail + "')";
        }
        public static string Register(string name)
        {
            return "Select * from Login where username='" + name + "'";
        }

        //BidForm
        public static string BidMaxID()
        {
            return "SELECT MAX(Id) FROM Bidding";
        }
        public static string BidGet(string House)
        {
            return "SELECT Bid FROM Bidding Where House='" + House + "'";
        }
        public static string BidGetMaxBid(string House)
        {
            return "SELECT MAX(Bid) FROM Bidding Where House='" + House + "'";
        }
        public static string BidInsert(int id,string user,string House,string bidvalue)
        {
            return "INSERT INTO Bidding(ID,USERNAME,HOUSE,BID)Values(" + id + ",'" + user + "','" + House + "','" + bidvalue + "')";
        }

        //Login.CS

        public static string GetUserFromDB(string user,string pass)
        {
           return "Select * from Login where username = '" + user + "'and password = '" + pass + "'";
        }

        //DeleteForm

        public static string DeleteHouse(string houdeid)
        {
            return "Delete from houses where id='"+houdeid+"'";
        }


        //public static string Insert(string form)
        //{
        //    return "INSERT INTO" + form;
        //}
    }
}
