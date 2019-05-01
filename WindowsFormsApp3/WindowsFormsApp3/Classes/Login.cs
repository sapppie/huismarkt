using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Login
    {
               
        public void LoginAction(string username, string password,LoginForm l)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=housebase.database.windows.net;Initial Catalog=HuizenMarkt;User ID=nhlandriesvdsluis;Password=Welkom!2;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string query = "Select * from Login where username = '" + username + "'and password = '" + password + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Session.UserID = username;
                //als deze if true is hide hij de loginform en word de mainform geopend
                Selectie s = new Selectie();
                l.Hide();
                s.Show();
            }
            else
            {
                //als het false is wordt er een popup gegeven met "Wrong user or password"
                MessageBox.Show("Wrong user or password");
            }
        }
    }
}
