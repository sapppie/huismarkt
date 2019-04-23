using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=housebase.database.windows.net;Initial Catalog=HuizenMarkt;User ID=nhlandriesvdsluis;Password=Welkom!2;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                String query = "select * from Houses";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem street = new ListViewItem(dr["Street"].ToString()+" "+dr["HouseNR"].ToString() + " " + dr["City"].ToString() + " " + dr["PostCode"].ToString());
                    //ListViewItem housenr = new ListViewItem(dr["HouseNR"].ToString());
                    //ListViewItem city = new ListViewItem(dr["City"].ToString());
                    //ListViewItem postcode = new ListViewItem(dr["PostCode"].ToString());
                   listView1.Items.Add(street);
                   //listView1.Items.Add(housenr);
                   //listView1.Items.Add(city);
                   //listView1.Items.Add(postcode);
                }
                //DataSet ds = new DataSet();
                //MessageBox.Show("connection succesfull");
                conn.Close();
            }
            catch (Exception es)

            {

                MessageBox.Show(es.Message);



            }
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //foreach (DataRow dr in dt.Rows)
            //{
            //    ListViewItem item = new ListViewItem(dr["Street"].ToString());
            //    listView1.Items.Add(item);
            //}
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }
    }
}
