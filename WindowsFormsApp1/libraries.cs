using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class libraries : UserControl
    {
        public libraries()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=MCA;Integrated Security=True");
        private void btn_dis_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from books;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            book_add1.Show();
        }


        private void libraries_Load(object sender, EventArgs e)
        {
            btn_dis_Click(sender, e);
            book_delete1.Hide();
            book_add1.Hide();
            book_update1.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            book_update1.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            book_delete1.Show();
        }
    }
}
