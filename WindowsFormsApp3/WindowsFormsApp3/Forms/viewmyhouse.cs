using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuizenmarktApp
{
    public partial class viewmyhouse : Form
    {
        SQLCAC sQLConn = new SQLCAC();
        SqlCommand command = new SqlCommand();
        public viewmyhouse()
        {
            InitializeComponent();
            try
            {
                SqlConnection conn = new SqlConnection(sQLConn.Connstring());
                String query = "select * from Houses where username='" + Session.UserID + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    city.Text = dr["City"].ToString();
                    street.Text = dr["Street"].ToString();
                    postcode.Text = dr["postcode"].ToString();
                    housenr.Text= dr["HouseNR"].ToString();
                    acres.Text = dr["Acres"].ToString();
                    year.Text = dr["YearOfBuilt"].ToString();
                    energylabel.Text = dr["EnergyLable"].ToString();
                    rooms.Text = dr["Rooms"].ToString();
                    garage.Text = dr["Garage"].ToString();
                    spotsavailable.Text = dr["GarageCapacity"].ToString();
                    typeofhouse.Text = dr["SoortHuis"].ToString();
                    price.Text = dr["Price"].ToString();
                    about.Text = dr["AboutHouses"].ToString();
                    //Byte[] data = new Byte[0];
                    //data = (Byte[])(dr["Image"]);
                    //MemoryStream mem = new MemoryStream(data);
                    //pictureBox1.Image = Image.FromStream(mem);
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(sQLConn.Connstring());
            string query = "UPDATE HOUSES SET Street='" + street.Text + "',Acres='" + acres.Text + "',HouseNR='" + housenr.Text + "',Rooms='" + rooms.Text + "',Garage='" + garage.Text + "',Price='" + price.Text + "',City='" + city.Text + "',PostCode='" + postcode.Text + "',YearOfBuilt='" + year.Text + "',AboutHouses='" + about.Text + "',SoortHuis='" + typeofhouse.Text + "',EnergyLable='" + energylabel.Text + "',GarageCapacity='" + spotsavailable.Text + "' WHERE USERNAME='" + Session.UserID + "'";
            if (conn.State != ConnectionState.Open)
                conn.Open();
            command = new SqlCommand(query, conn);
            int x = command.ExecuteNonQuery();
            conn.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Selectie s = new Selectie();
            this.Hide();
            s.Show();
        }
    }
}
