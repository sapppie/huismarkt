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

namespace HuizenmarktApp
{
    public partial class LoginForm : Form
    {
        //Login l = new Login(username,password);
        public LoginForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = UserText.Text.Trim();
            string password = PassText.Text.Trim();
            Login l = new Login(username,password,this);
        }

        private void PassText_TextChanged(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e){this.Close();}
        private void Button3_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            this.Hide();
            rf.Show();
        }
    }
}
