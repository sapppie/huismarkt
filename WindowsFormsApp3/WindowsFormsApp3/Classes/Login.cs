using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace HuizenmarktApp
{
    public partial class Login
    {
        private string _username;
        public string username{ get{return _username;} set{_username = value;}}
        private string _password;
        public string password{ get { return _password; } set { _password = value; }}
        

        public Login(string login,string password, LoginForm l)
        {
            this.username = login;
            this.password = password;
            LoginAction(this.username,this.password,l);
        }
        public void LoginAction(string username, string password, LoginForm l)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=housebase.database.windows.net;Initial Catalog=HuizenMarkt;User ID=nhlandriesvdsluis;Password=Welkom!2;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string query = "Select * from Login where username = '" + this.username + "'and password = '" + this.password + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Session.UserID = this.username;
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
