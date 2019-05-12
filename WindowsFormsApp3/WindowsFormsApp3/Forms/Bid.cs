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
    public partial class Bid : Form
    {
        public Bid()
        {
            InitializeComponent();
        }
        public string House;
        SqlCommand command;

        public int MaxId()
        {
            SqlConnection conn = new SqlConnection(SQLCAC.Connstring());

            int idmax;
            using (SqlCommand myCommand = conn.CreateCommand())
            {
                conn.Open();
                myCommand.CommandText = SQLCAC.BidMaxID();
                int maxId = Convert.ToInt32(myCommand.ExecuteScalar());
                idmax = maxId;
                conn.Close();
            }
            //int idmax=maxId;
            return idmax + 1;
        }
        public int MaxBid()
        {
            SqlConnection conn = new SqlConnection(SQLCAC.Connstring());

            conn.Open();
            using (SqlCommand myCommand =new SqlCommand(SQLCAC.BidGet(House), conn))
            {
                using (SqlDataReader reader = myCommand.ExecuteReader())
                {

                    int bidmax;
                    if (reader.HasRows)
                    {
                        conn.Close();
                        conn.Open();

                        myCommand.CommandText = SQLCAC.BidGetMaxBid(House);

                        int maxId = Convert.ToInt32(myCommand.ExecuteScalar());
                        bidmax = maxId;

                        conn.Close();

                    }
                    else
                    {
                        bidmax = 0;
                        conn.Close();

                    }
                    return bidmax;

                }



                //int idmax=maxId;
            }
        }
        private void BidButton_Click(object sender, EventArgs e)
        {
            SQLCAC.KopenGetHouseID();
            SqlConnection conn = new SqlConnection(SQLCAC.Connstring());

            try
            {
                string user = Session.UserID;
                
                int id = MaxId();
                if (id == 0)
                {
                    id = 1;
                }
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                command = new SqlCommand(SQLCAC.BidInsert(id, user, House, BidValue.Text), conn);
                int x = command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(x.ToString() + " record(s) saved.");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }
    }
}
