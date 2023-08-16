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
    public partial class staffs_delete : UserControl
    {
        public staffs_delete()
        {
            InitializeComponent();
        }

        long value;
        string view, id;
        SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=MCA;Integrated Security=True");

        private void btn_delete_Click(object sender, EventArgs e)
        {
            id = txt_value.Text;
            if (id.Length > 0)
            {
                for (int i = 0; i < id.Length; i++)
                {
                    if (!Char.IsDigit(id[i]))
                    {
                        MessageBox.Show("only number allowed in roll number ex. 7005");
                        txt_value.Text = "";
                        id = "";
                    }
                }
            }
            if (id.Length > 0)
            {
                value = int.Parse(txt_value.Text);
                view = $"delete from staffs where Ref_id={value};";
                con.Open();
                SqlCommand cmd = new SqlCommand(view, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("successfully deleted");
                view = "";
                txt_value.Text = "";
                this.Hide();
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            view = "";
            value = 0;
            this.Hide();
        }
    }
}
