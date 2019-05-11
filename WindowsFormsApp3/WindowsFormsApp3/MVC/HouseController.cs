using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuizenmarktApp.MVC
{
    public class HouseController
    {
        IHouseView _view;
        IList _houses;
        huis _selectedhouse;
        Byte[] image;

        public HouseController(IHouseView view,IList houses)
        {
            _view = view;
            _houses = houses;
            view.SetController(this);
            return;
        }

        public IList Houses
        {
            get { return ArrayList.ReadOnly(_houses);}
        }
        private void updateViewDetailValues(huis Huis)
        {
            _view.ID            = Huis.ID;
            _view.Street        = Huis.Street        ;
            _view.Acres         = Huis.Acres         ;
            _view.HouseNR       = Huis.HouseNR       ;
            _view.Rooms         = Huis.Rooms         ;
            _view.Garage        = Huis.Garage        ;
            _view.Price         = Huis.Price         ;
            _view.City          = Huis.City          ;
            _view.Postcode      = Huis.Postcode      ;
            _view.Yearofbuilt   = Huis.Yearofbuilt   ;
            _view.Aboutthehouse = Huis.Aboutthehouse ;
            _view.Soorthuis     = Huis.Soorthuis     ;
            _view.Energielable  = Huis.EnergieLable  ;
            _view.Garagecapacity= Huis.GarageCapacity;
            _view.Immage         = Huis.Image         ;
        }
        private void updateHouseWithViewValues(huis Huis)
        {
            Huis.ID            = _view.ID;
            Huis.Street        = _view.Street        ;
            Huis.Acres         = _view.Acres         ;
            Huis.HouseNR       = _view.HouseNR       ;
            Huis.Rooms         = _view.Rooms         ;
            Huis.Garage        = _view.Garage        ;
            Huis.Price         = _view.Price         ;
            Huis.City          = _view.City          ;
            Huis.Postcode      = _view.Postcode      ;
            Huis.Yearofbuilt   = _view.Yearofbuilt   ;
            Huis.Aboutthehouse = _view.Aboutthehouse ;
            Huis.Soorthuis     = _view.Soorthuis     ;
            Huis.EnergieLable  = _view.Energielable  ;
            Huis.GarageCapacity= _view.Garagecapacity;
            Huis.Image         = _view.Immage        ;
        }
        public void LoadView()
        {
            _view.ClearView();
            foreach (huis Huis in _houses)
                _view.AddHouseToView(Huis);
            _view.SetSelectedHouseInView((huis)_houses[0]);
        }

        public void SelectedHouseChanged(string selectedHouseId)
        {
            foreach(huis H in  this._houses)
            {
                if (H.ID == selectedHouseId)
                {
                    _selectedhouse = H;
                    updateViewDetailValues(H);
                    _view.SetSelectedHouseInView(H);
                    this._view.CanModifyID = false;
                    break;
                }
            }
        }
        public void AddNewHouse()
        {
            _selectedhouse = new huis("","","","","","","","","","","","","","",image);
            this.updateViewDetailValues(_selectedhouse);
            this._view.CanModifyID = true;
        }
        public void RemoveHouse()
        {
            string id = this._view.GetIdOfSelectedHouseInView();
            huis HuisToRemove = null;
            if (id != "")
            {
                foreach(huis H in this._houses)
                {
                    if (H.ID == id)
                    {
                        HuisToRemove = H;
                        break;
                    }
                }
                if (HuisToRemove != null)
                {
                    int newSelectedIndex = this._houses.IndexOf(HuisToRemove);
                    this._houses.Remove(HuisToRemove);
                    this._view.RemoveHouseFromView(HuisToRemove);

                    if (newSelectedIndex > -1 && newSelectedIndex < _houses.Count)
                    {
                        this._view.SetSelectedHouseInView((huis)_houses[newSelectedIndex]);
                    }
                }
            }
        }
        public void Save()
        {
            updateHouseWithViewValues(_selectedhouse);
            if (!this._houses.Contains(_selectedhouse))
            {
                this._houses.Add(_selectedhouse);
                this._view.AddHouseToView(_selectedhouse);
            }
            else
            {
                this._view.UpdateViewWithChangedHouse(_selectedhouse);
            }
            _view.SetSelectedHouseInView(_selectedhouse);
            this._view.CanModifyID = false;
        }
    }
}
