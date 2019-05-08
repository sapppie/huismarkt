using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuizenmarktApp
{ 
    public class SQLstrings
    {
        public string VerkoopInsert()
        {
            return "INSERT INTO Houses(Id,Street,Acres,HouseNR,Rooms,Garage,Price,City,PostCode,YearOfBuilt,AboutHouses,SoortHuis,EnergyLable,GarageCapacity,username,Image)VALUES(";
        }
        public string VerkoopGetUser()
        {
            return "Select username from Login";
        }

        public string KopenGetHouses()
        {
            return "select * from Houses";
        }
        public string KopenGetHouseID()
        {
            return "select * from Houses where id='";
        }
        public string RegisterMaxID()
        {
            return "SELECT MAX(Id) FROM Login";
        }
        public string RegisterCheckUser()
        {
            return "SELECT COUNT (*) FROM Login WHERE(username = @user)";
        }
        public string RegisterInstert(int MaxId,string Uname,string Passwd,string Mail)
        {
            return "INSERT INTO Login(Id,username,password,email)VALUES(" + MaxId + ",'" + Uname + "','" + Passwd + "','" + Mail + "')";
        }
    }
}
