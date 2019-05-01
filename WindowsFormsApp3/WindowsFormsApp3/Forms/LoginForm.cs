using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class LoginForm : Form
    {
        Login l = new Login();
        public LoginForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Login l = new Login();
            string username = UserText.Text.Trim();
            string password = PassText.Text.Trim();
            l.LoginAction(username,password,this);
            
            //SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Integrated Security=True");
            //string query = "Select * from Login where username = '" + UserText.Text.Trim() + "'and password = '" + PassText.Text.Trim()+"'"; ;
            //SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            //DataTable dtbl = new DataTable();
            //sda.Fill(dtbl);
            //if (dtbl.Rows.Count == 1)
            //{
            //    Kopen objmain = new Kopen();
            //    this.Hide();
            //    objmain.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Wrong user or password");
            //}
        }

        private void PassText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            this.Hide();
            rf.Show();
        }
    }
}
