using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuizenmarktApp
{
    public partial class Selectie : Form
    {
        public Selectie()
        {
            InitializeComponent();
            Admin();
        }
        private void Admin()
            {
            if (Session.UserID == "Admin")
            {
                this.Show();
            }
            else
            {
                this.Hide();
                Kopen k = new Kopen();
                k.Show();
            }
        }
        private void Kopen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kopen k = new Kopen();
            k.Show();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Verkopen v = new Verkopen();
            this.Hide();
            v.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            this.Hide();
            l.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            viewmyhouse v = new viewmyhouse();
            this.Hide();
            v.Show();
        }
    }
}
