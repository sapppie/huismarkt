using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Collections;
using HuizenmarktApp.MVC;

namespace HuizenmarktApp
{
    
    public partial class Kopen : Form, IHouseView
    {
        SQLCAC sQLConn = new SQLCAC();
        HouseController _controller;
        IList houses = new ArrayList();
        Byte[] data = new Byte[0];
        public string SelectedHouse;
        Bid b = new Bid();



        public Kopen()
        {
            InitializeComponent();
            filllist();

            HouseController controller = new HouseController(this,houses);
            controller.LoadView();
            this.ShowDialog();
        }        

        public void SetController(HouseController controller)
        {
            _controller = controller;
        }
        public void filllist()
        {

            try
            {
                SqlConnection conn = new SqlConnection(sQLConn.Connstring());
                String query = SQLstrings.KopenGetHouses();
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //int table = 0;                
                foreach (DataRow dr in dt.Rows)
                {
                    //listView.Items.Add(dr["Id"].ToString());
                    //listView.Items[table].SubItems.Add(dr["City"].ToString());
                    //listView.Items[table].SubItems.Add(dr["Street"].ToString() + " " + dr["HouseNR"].ToString());
                    //listView.Items[table].SubItems.Add(dr["PostCode"].ToString());

                    //table++;
                    houses.Add(new huis(dr["Id"].ToString(), dr["Street"].ToString(), dr["Acres"].ToString(), 
                        dr["HouseNR"].ToString(), dr["Rooms"].ToString(), dr["Garage"].ToString(),
                        dr["Price"].ToString(), dr["City"].ToString(), dr["PostCode"].ToString(),
                        dr["Yearofbuilt"].ToString(), dr["AboutHouses"].ToString(), dr["soorthuis"].ToString(),
                        dr["energylable"].ToString(), dr["garagecapacity"].ToString(), data = (Byte[])(dr["Image"])));
                }
                conn.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public void ClearView()
        {
            //Define Columns in grid
            this.listView.Columns.Clear();

            this.listView.Columns.Add("ID", 150, HorizontalAlignment.Left);
            this.listView.Columns.Add("City", 300, HorizontalAlignment.Left);
            this.listView.Columns.Add("Address", 150, HorizontalAlignment.Left);
            this.listView.Columns.Add("Postcode", 150, HorizontalAlignment.Left);

            //Add rows to grid
            this.listView.Items.Clear();
        }

        public void AddHouseToView(huis h)
        {
            ListViewItem parent;
            parent = this.listView.Items.Add(h.ID);
            parent.SubItems.Add(h.City);
            parent.SubItems.Add(h.Street+h.HouseNR);
            parent.SubItems.Add(h.Postcode);
        }

        public void UpdateViewWithChangedHouse(huis h)
        {
            ListViewItem rowToUpdate = null;
            foreach (ListViewItem row in this.listView.Items)
            {
                if(row.Text == h.ID)
                {
                    rowToUpdate = row;
                }

                if (rowToUpdate != null)
                {
                    rowToUpdate.Text = h.ID;
                    rowToUpdate.SubItems[1].Text = h.City;
                    rowToUpdate.SubItems[2].Text = h.Street+h.HouseNR;
                    rowToUpdate.SubItems[3].Text = h.Postcode;
                }
            }
        }
        public bool CanModifyID
        {
            set { this.IDtxt.Enabled = value; }
        }
        public void RemoveHouseFromView(huis h)
        {
            ListViewItem rowToRemove = null;
            foreach (ListViewItem row in this.listView.Items)
            {
                if (row.Text == h.ID)
                {
                    rowToRemove = row;
                }

                if (rowToRemove != null)
                {
                    this.listView.Items.Remove(rowToRemove);
                    this.listView.Focus();
                }
            }
        }

        public string GetIdOfSelectedHouseInView()
        {
            if (this.listView.SelectedItems.Count > 0)
                return this.listView.SelectedItems[0].Text;
            else
                return "";
        }

        public void SetSelectedHouseInView(huis h)
        {
            foreach (ListViewItem row in this.listView.Items)
            {
                if (row.Text == h.ID)
                {
                    row.Selected = true;
                }
            }
        }

        #region publicstringsforMVC
        public string Street
        {
            
            get { return this.street.Text; }
            set { this.street.Text = value; }
        }
        public string ID
        {

            get { return this.IDtxt.Text; }
            set { this.IDtxt.Text = value; }
        }
        public string Acres
        {

            get { return this.acres.Text; }
            set { this.acres.Text = value; }
        }
        public string HouseNR
        {

            get { return this.Housenr.Text; }
            set { this.Housenr.Text = value; }
        }
        public string Rooms
        {

            get { return this.rooms.Text; }
            set { this.rooms.Text = value; }
        }
        public string Garage
        {

            get { return this.garage.Text; }
            set { this.garage.Text = value; }
        }
        public string Price
        {

            get { return this.price.Text; }
            set { this.price.Text = value; }
        }
        public string City
        {

            get { return this.city.Text; }
            set { this.city.Text = value; }
        }
        public string Postcode
        {

            get { return this.postcode.Text; }
            set { this.postcode.Text = value; }
        }
        public string Yearofbuilt
        {

            get { return this.year.Text; }
            set { this.year.Text = value; }
        }
        public string Aboutthehouse
        {

            get { return this.about.Text; }
            set { this.about.Text = value; }
        }
        public string Soorthuis
        {

            get { return this.typeofhouse.Text; }
            set { this.typeofhouse.Text = value; }
        }
        public string Energielable
        {

            get { return this.energylabel.Text; }
            set { this.energylabel.Text = value; }
        }
        public string Garagecapacity
        {

            get { return this.spotsavailable.Text; }
            set { this.spotsavailable.Text = value; }
        }
        public Byte[] Immage
        {

            get {
                Byte[] data = new Byte[0];
                
                data = (Byte[])(new ImageConverter()).ConvertTo(pictureBox1.Image, typeof(byte[]));
                    return data; }
            set {
                Byte[] data = new Byte[0];
                data = value;
                MemoryStream mem = new MemoryStream(data);
                this.pictureBox1.Image = Image.FromStream(mem); }
        }
        #endregion 

        private void Button2_Click(object sender, EventArgs e)
        {
            Selectie s = new Selectie();
            this.Hide();
            s.Show();
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView.SelectedItems.Count > 0)
            {
                this._controller.SelectedHouseChanged(listView.SelectedItems[0].Text);
                b.House = listView.SelectedItems[0].Text;
                HighestBid.Text = b.MaxBid().ToString();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            b.Show();
        }

       
    }
    }

