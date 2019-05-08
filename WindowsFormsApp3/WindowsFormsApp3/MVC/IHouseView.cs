using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuizenmarktApp.MVC
{
    public interface IHouseView
    { 
        void SetController(HouseController controller);
        void ClearView();
        void AddHouseToView(huis Huis);
        void UpdateViewWithChangedHouse(huis Huis);
        void RemoveHouseFromView(huis Huis);
        string GetIdOfSelectedHouseInView();
        void SetSelectedHouseInView(huis Huis);

        string ID             {get;set;}
        string Street         {get;set;}
        string Acres          {get;set;}
        string HouseNR        { get;set;}
        string Rooms          {get;set;}
        string Garage         {get;set;}
        string Price          {get;set;}
        string City           {get;set;}
        string Postcode       {get;set;}
        string Yearofbuilt    {get;set;}
        string Aboutthehouse  {get;set;}
        string Soorthuis      {get;set;}
        string Energielable   {get;set;}
        string Garagecapacity {get;set;}
        Byte[] Immage          {get;set;}

        bool CanModifyID { set; }
    }
}
