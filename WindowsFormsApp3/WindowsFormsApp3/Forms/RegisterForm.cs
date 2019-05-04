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
    public partial class RegisterForm : Form
    {
        SqlCommand command;
        SQLCAC sQLConn = new SQLCAC();
        public RegisterForm()
        {
            InitializeComponent();
        }
        public int MaxId()
        {
            SqlConnection conn = new SqlConnection(sQLConn.Connstring());

            int idmax;
            using (SqlCommand myCommand = conn.CreateCommand())
            {
                conn.Open();
                myCommand.CommandText = "SELECT MAX(Id) FROM Login";
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

            string query = "Select * from Login where username='" + Uname.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            conn.Open();
            SqlCommand checkusers = new SqlCommand("SELECT COUNT (*) FROM Login WHERE(username = @user)", conn);
            checkusers.Parameters.AddWithValue("@user", Uname.Text);
            int UserExist = (int)checkusers.ExecuteScalar();
            conn.Close();
            if (UserExist > 0)
            {
                //als deze if true is hide hij de loginform en word de mainform geopend
                MessageBox.Show("Sorry deze gebruikersnaam of mail is al bij ons geregistreerd.");
            }
            else
            {
                try
                {
                    string sql = "INSERT INTO Login(Id,username,password,email)VALUES(" + MaxId() +",'"+Uname.Text+"','"+Passwd.Text+"','"+Mail.Text+"')";
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    command = new SqlCommand(sql, conn);
                    int x = command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(x.ToString() + " record(s) saved.");
                    LoginForm l = new LoginForm();
                    this.Hide();
                    l.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Hide();
            lf.Show();

        }
    }
}
