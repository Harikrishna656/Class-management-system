using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class students : UserControl
    {
        public students()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=MCA;Integrated Security=True");
        private void btn_dis_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from students;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void students_Load(object sender, EventArgs e)
        {
            insertcs1.Hide();
            update1.Hide();
            delete1.Hide();
            btn_dis_Click(sender, e);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            insertcs1.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            update1.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            delete1.Show();
        }
    }
}
