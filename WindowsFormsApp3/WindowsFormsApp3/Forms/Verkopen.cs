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

namespace HuizenmarktApp
{
    public partial class Verkopen : Form
    {
        SQLCAC sQLConn = new SQLCAC();
        SqlCommand command;
        SQLstrings str = new SQLstrings();
        string imgLoc = "";
        public Verkopen()
        {
            InitializeComponent();
            GetUsers();
        }
        public static void Popup(string pop)
        {
            MessageBox.Show("Teveel karakters in "+pop+". Maximale invoer is 50.");
        }
        private void TextBox12_TextChanged(object sender, EventArgs e){}

        private void GetUsers()
        {
            try
            {
                SqlConnection conn = new SqlConnection(sQLConn.Connstring());
                String query = str.VerkoopGetUser();
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox1.Items.Add(dr["username"].ToString());
                }
                conn.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(sQLConn.Connstring());
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    housePic.ImageLocation = imgLoc;
                    //https://www.youtube.com/watch?v=BqyAAGMfTD8
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public int MaxId()
        {
            SqlConnection conn = new SqlConnection(sQLConn.Connstring());

            int idmax;
            using (SqlCommand myCommand = conn.CreateCommand())
            {
                conn.Open();
                myCommand.CommandText = "SELECT MAX(Id) FROM Houses";
                int maxId = Convert.ToInt32(myCommand.ExecuteScalar());
                idmax = maxId;
                conn.Close();
            }
            //int idmax=maxId;
            return idmax + 1;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(sQLConn.Connstring());

            try
            {

                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                int id = MaxId();
                if (id == 0)
                {
                    id = 1;
                }
                string sql = str.VerkoopInsert() + id + ",'" + street.Text + "','" + acres.Text + "','" + housenr.Text + "','" + rooms.Text + "','" + garage.Text + "','" + price.Text + "','" + city.Text + "','" + postcode.Text + "','" + year.Text + "','" + about.Text + "','" + soorthuis.Text + "','" + energielabel.Text + "','" + garagecap.Text + "','"+ comboBox1.Text+"',@img)";
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                command = new SqlCommand(sql, conn);
                command.Parameters.Add(new SqlParameter("@img", img));
                int x = command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(x.ToString() + " record(s) saved.");
                Verkopen admin = new Verkopen();
                this.Hide();
                admin.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void Label1_Click(object sender, EventArgs e){}

        private void Garage_TextChanged(object sender, EventArgs e){}

        private void Button3_Click(object sender, EventArgs e)
        {
            Selectie s = new Selectie();
            this.Hide();
            s.Show();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
