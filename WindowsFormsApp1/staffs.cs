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
    public partial class staffs : UserControl
    {
        public staffs()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=MCA;Integrated Security=True");
        private void btn_dis_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from staffs;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void staffs_Load(object sender, EventArgs e)
        {
            staffs_insert1.Hide();
            staffs_update1.Hide();
            staffs_delete1.Hide();
            btn_dis_Click(sender,e);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
              staffs_insert1.Show();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
             staffs_update1.Show();
 
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
              staffs_delete1.Show();

        }
    }
}
