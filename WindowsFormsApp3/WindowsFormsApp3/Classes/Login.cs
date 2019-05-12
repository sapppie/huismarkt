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
            SqlConnection sqlcon = new SqlConnection(SQLCAC.Connstring());
            SqlDataAdapter sda = new SqlDataAdapter(SQLCAC.GetUserFromDB(this.username,this.password), sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            //als deze if true is hide hij de loginform en word de mainform geopend
            if (dtbl.Rows.Count == 1)
            {
                Session.UserID = this.username;
                if(this.username == "Admin")
                { l.SelectionAdmin(); }
                else
                { l.Selection(); }
                
            }
            else
            {
                //als het false is wordt er een popup gegeven met "Wrong user or password"
                MessageBox.Show("Wrong user or password");
            }

        }
    }
}
