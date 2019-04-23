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

namespace WindowsFormsApp3
{
    public partial class AdminForm : Form
    {
        SqlConnection conn = new SqlConnection("");
        SqlCommand command;
        string imgLoc = "";
        public AdminForm()
        {
            InitializeComponent();
        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select picture";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    housePic.ImageLocation = imgLoc;
                https://www.youtube.com/watch?v=BqyAAGMfTD8
                }
            }
            catch
            {

            }
        }
    }
}
