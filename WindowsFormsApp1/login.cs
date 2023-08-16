using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "7005" && txt_pass.Text == "hari")
            {
                new main().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid ID or Password");
                txt_pass.Text = "";
                txt_id.Text = "";
            }
        }
    }
}
