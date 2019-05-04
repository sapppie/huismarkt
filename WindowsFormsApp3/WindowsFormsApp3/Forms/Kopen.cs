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

namespace HuizenmarktApp
{
    
    public partial class Kopen : Form
    {
        SQLCAC sQLConn = new SQLCAC();
        public Kopen()
        {
            House.HouseGet();
            InitializeComponent();
            string u = Session.UserID;
            try
            {
                SqlConnection conn = new SqlConnection(sQLConn.Connstring());
                String query = "select * from Houses";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int table = 0;                
                    foreach (DataRow dr in dt.Rows)
                {                 
                    listView.Items.Add(dr["Id"].ToString());
                    listView.Items[table].SubItems.Add(dr["City"].ToString());
                    listView.Items[table].SubItems.Add(dr["Street"].ToString() + " " + dr["HouseNR"].ToString());
                    listView.Items[table].SubItems.Add(dr["PostCode"].ToString());
                    table++;
                }
                conn.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
        public string ID;
        public string Street;
        public string Acres;
        public string Housenr;
        public string Rooms;
        public string Garage;
        public string Price;
        public string City;
        public string Postcode;
        public string Yearofbuilt;
        public string Aboutthehouse;
        public string Soorthuis;
        public string Energielable;
        public string Garagecapacity;
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            foreach (ListViewItem item in listView.SelectedItems)
            {
                int text = Convert.ToInt32(listView.SelectedItems[0].Text);
                try
                {
                    SqlConnection conn = new SqlConnection(sQLConn.Connstring());
                    String query = "select * from Houses where id='" + text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
          
                    
                    foreach (DataRow dr in dt.Rows)
                    {
                      city.Text = dr["City"].ToString();
                      address.Text = dr["Street"].ToString() + dr["HouseNR"].ToString();
                      acres.Text = dr["Acres"].ToString();
                      year.Text = dr["YearOfBuilt"].ToString();
                      energylabel.Text = dr["EnergyLable"].ToString();
                      rooms.Text = dr["Rooms"].ToString();
                      garage.Text = dr["Garage"].ToString();
                      spotsavailable.Text = dr["GarageCapacity"].ToString();
                      typeofhouse.Text = dr["SoortHuis"].ToString();
                      price.Text = dr["Price"].ToString();
                      about.Text = dr["AboutHouses"].ToString();
                      Byte[] data = new Byte[0];
                      data = (Byte[])(dr["Image"]);
                      MemoryStream mem = new MemoryStream(data);
                      pictureBox1.Image = Image.FromStream(mem);
                    }
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
            
        }


        public void getimage()
        {
            SqlConnection conn = new SqlConnection(sQLConn.Connstring());

            SqlDataAdapter ad = new SqlDataAdapter(new SqlCommand("SELECT Image from Houses where id=2", conn));
            DataSet dataSet = new DataSet();
            ad.Fill(dataSet);
            if (dataSet.Tables[0].Rows.Count == 1)
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(dataSet.Tables[0].Rows[0]["Image"]);
                MemoryStream mem = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(mem);
            }

            //DataSet ds = new DataSet();
            MessageBox.Show("connection succesfull");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Kopen_Load(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Selectie s = new Selectie();
            this.Hide();
            s.Show();
        }
    }
}
