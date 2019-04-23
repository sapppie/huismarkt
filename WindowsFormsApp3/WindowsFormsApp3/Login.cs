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
    class Login
    {
        public void LoginAction(string username, string password)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Integrated Security=True");
            string query = "Select * from Login where username = '" + username + "'and password = '" + password + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                //als deze if true is hide hij de loginform en word de mainform geopend
                FormMain objmain = new FormMain();
                LoginForm LF = new LoginForm();
                LF.Hide();
                objmain.Show();
            }
            else
            {
                //als het false is wordt er een popup gegeven met "Wrong user or password"
                MessageBox.Show("Wrong user or password");
            }
        }
    }
}
