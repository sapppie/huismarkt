﻿using System;
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
        SQLCAC sQLConn;
        SqlCommand command;

        public int MaxId()
        {
            SqlConnection conn = new SqlConnection(@"Data Source = housebase.database.windows.net; Initial Catalog = HuizenMarkt; User ID = nhlandriesvdsluis; Password = Welkom!2; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

            int idmax;
            using (SqlCommand myCommand = conn.CreateCommand())
            {
                conn.Open();
                myCommand.CommandText = "SELECT MAX(Id) FROM Bidding";
                int maxId = Convert.ToInt32(myCommand.ExecuteScalar());
                idmax = maxId;
                conn.Close();
            }
            //int idmax=maxId;
            return idmax + 1;
        }
        public int MaxBid()
        {
            SqlConnection conn = new SqlConnection(@"Data Source = housebase.database.windows.net; Initial Catalog = HuizenMarkt; User ID = nhlandriesvdsluis; Password = Welkom!2; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

            conn.Open();
            string sql = "SELECT Bid FROM Bidding Where House='" + House + "'";
            using (SqlCommand myCommand =new SqlCommand(sql,conn))
            {
                using (SqlDataReader reader = myCommand.ExecuteReader())
                {

                    int bidmax;
                    if (reader.HasRows)
                    {
                        conn.Close();
                        conn.Open();

                        myCommand.CommandText = "SELECT MAX(Bid) FROM Bidding Where House='" + House + "'";

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
            SQLstrings.KopenGetHouseID();
            SqlConnection conn = new SqlConnection(@"Data Source = housebase.database.windows.net; Initial Catalog = HuizenMarkt; User ID = nhlandriesvdsluis; Password = Welkom!2; Connect Timeout = 30; Encrypt = True; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

            try
            {
                string user = Session.UserID;
                
                int id = MaxId();
                if (id == 0)
                {
                    id = 1;
                }
                string sql = "INSERT INTO Bidding(ID,USERNAME,HOUSE,BID)Values("+id+",'"+user+"','"+House+"','"+BidValue.Text+"')";
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                command = new SqlCommand(sql, conn);
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
