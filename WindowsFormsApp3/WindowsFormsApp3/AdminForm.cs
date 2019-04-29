using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class AdminForm : Form
    {
        SqlConnection conn = new SqlConnection("");
        SqlCommand command;
        string imgLoc = "";
        public AdminForm()
        {
            InitializeComponent();
        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select picture";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    housePic.ImageLocation = imgLoc;
                //https://www.youtube.com/watch?v=BqyAAGMfTD8
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                string sql = "INSERT INTO Houses(Street,Acres,HouseNR,Rooms,Garage,Price,City,PostCode,YearOfBuilt,AboutHouse,SoortHuis,EnergyLable,GarageCapacity,Image)VALUES("+street.Text+",'"+acres.Text+"','"+housenr.Text+ "','" + rooms.Text+ "','" + garage.Text+ "','" + price.Text+ "','" + city.Text+ "','" + postcode.Text+ "','" + year.Text+ "','" + about.Text+ "','" + soorthuis.Text+ "','" + energielabel.Text+ "','" + garagecap.Text+ "',@img)";
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                command = new SqlCommand(sql, conn);
                command.Parameters.Add(new SqlParameter("@img", img));
                int x = command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(x.ToString() + " record(s) saved.");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
