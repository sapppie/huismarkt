using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuizenmarktApp
{ 
    public static class SQLstrings
    {
        public static string VerkoopInsert()
        {
            return "INSERT INTO Houses(Id,Street,Acres,HouseNR,Rooms,Garage,Price,City,PostCode,YearOfBuilt,AboutHouses,SoortHuis,EnergyLable,GarageCapacity,username,Image)VALUES(";
        }
        public static string VerkoopGetUser()
        {
            return "Select username from Login";
        }

        public static string KopenGetHouses()
        {
            return "select * from Houses";
        }
        public static string KopenGetHouseID()
        {
            return "select * from Houses where id='";
        }
        public static string RegisterMaxID()
        {
            return "SELECT MAX(Id) FROM Login";
        }
        public static string RegisterCheckUser()
        {
            return "SELECT COUNT (*) FROM Login WHERE(username = @user)";
        }
        public static string Insert(string form)
        {
            return "INSERT INTO"+form;
        }
        public static string RegisterInstert(int MaxId,string Uname,string Passwd,string Mail)
        {
            return "INSERT INTO Login(Id,username,password,email)VALUES(" + MaxId + ",'" + Uname + "','" + Passwd + "','" + Mail + "')";
        }
    }
}
