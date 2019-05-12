using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuizenmarktApp.MVC
{
    public class huis
    {
        private string _id;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _street;
        public string Street
        {
            get { return _street; }
            set
            {
                if (value.Length > 50)
                    Verkopen.Popup("Straat",50);
                else
                {
                    _street = value;
                }
            }
        }
        private string _acres;
        public string Acres
        {
            get { return _acres; }
            set
            {
                if (value.Length > 5)
                    Verkopen.Popup("Hectare",5);
                else
                {
                    _acres = value;
                }
            }
        }
        
        private string _housenr;
        public string HouseNR
        {
            get { return _housenr; }
            set
            {
                if (value.Length > 100)
                    Verkopen.Popup("Huisnummer",100);
                else
                {
                    _housenr = value;
                }
            }
        }
        private string _rooms;
        public string Rooms
        {
            get { return _rooms; }
            set
            {
                if (value.Length > 10)
                    Verkopen.Popup("Kamers",10);
                else
                {
                    _rooms = value;
                }
            }
        }
        private string _garage;
        public string Garage
        {
            get { return _garage; }
            set
            {
                if (value.Length > 50)
                    Verkopen.Popup("Hectare",50);
                else
                {
                    _garage = value;
                }
            }
        }
        private string _price;
        public string Price
        {
            get { return _price; }
            set
            {
                if (value.Length > 50)
                    Verkopen.Popup("Prijs",50);
                else
                {
                    _price = value;
                }
            }
        }
        private string _city;
        public string City
        {
            get { return _city; }
            set
            {
                if (value.Length > 50)
                    Verkopen.Popup("Stad/Dorp",50);
                else
                {
                    _city = value;
                }
            }
        }
        private string _postcode;
        public string Postcode
        {
            get { return _postcode; }
            set
            {
                if (value.Length > 8)
                    Verkopen.Popup("Postcode",8);
                else
                {
                    _postcode = value;
                }
            }
        }
        private string _yearofbuilt;
        public string Yearofbuilt
        {
            get { return _yearofbuilt; }
            set
            {
                if (value.Length > 5)
                    Verkopen.Popup("Bouwjaar",5);
                else
                {
                    _yearofbuilt = value;
                }
            }
        }
        private string _aboutthehouse;
        public string Aboutthehouse
        {
            get { return _aboutthehouse; }
            set
            {
                if (value.Length > 100)
                    Verkopen.Popup("Over het huis",100);
                else
                {
                    _aboutthehouse = value;
                }
            }
        }
        private string _soorthuis;
        public string Soorthuis
        {
            get { return _soorthuis; }
            set
            {
                if (value.Length > 50)
                    Verkopen.Popup("Soorthuis",50);
                else
                {
                    _soorthuis = value;
                }
            }
        }
        private string _energielable;
        public string EnergieLable
        {
            get { return _energielable; }
            set
            {
                if (value.Length > 50)
                    Verkopen.Popup("energie lable",50);
                else
                {
                    _energielable = value;
                }
            }
        }
        private string _garagecapacity;
        public string GarageCapacity
        {
            get { return _garagecapacity; }
            set
            {
                if (value.Length > 50)
                    Verkopen.Popup("Garage plaatsen",50);
                else
                {
                    _garagecapacity = value;
                }
            }
        }
        private Byte[] _image;
        public Byte[] Image
        {
            get { return _image; }
            set
            {
                _image = value;
            }
        }
        public huis(string id, string street, string acres, string housenr, string rooms, string garage, string price, string city, string postcode, string yearofbuilt, string about, string soorthuis, string energielable, string garagecapacity, Byte[] image)
        {
            ID= id;
            Street= street;
            Acres= acres;
            HouseNR= housenr;
            Rooms= rooms;
            Garage = garage;
            Price= price;
            City = city;
            Postcode = postcode;
            Yearofbuilt = yearofbuilt;
            Aboutthehouse= about;
            Soorthuis = soorthuis;
            EnergieLable = energielable;
            GarageCapacity = garagecapacity;
            Image = image;
        }
    }
}
