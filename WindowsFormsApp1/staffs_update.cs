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
    public partial class staffs_update : UserControl
    {
        public staffs_update()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=MCA;Integrated Security=True");


        String set, where, set_val, where_val, view;

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (set_list.Text == "Ref_id" || set_list.Text == "phone_no")
            {
                set_val = txt_set.Text;
                if (set_val.Length > 0)
                {
                    for (int i = 0; i < set_val.Length; i++)
                    {
                        if (!Char.IsDigit(set_val[i]))
                        {
                            MessageBox.Show("only number allowed in set_val");
                            txt_set.Text = "";
                            set_val = "";
                        }
                    }
                }

            }
            if (where_list.Text == "Ref_id" || where_list.Text == "phone_no")
            {
                where_val = txt_where.Text;
                if (where_val.Length > 0)
                {
                    for (int i = 0; i < where_val.Length; i++)
                    {
                        if (!Char.IsDigit(where_val[i]))
                        {
                            MessageBox.Show("only number allowed in where_val");
                            txt_where.Text = "";
                            where_val = "";
                        }
                    }
                }

            }

            set = set_list.Text;
            set_val = txt_set.Text;
            where = where_list.Text;
            where_val = txt_where.Text;
            if (where_val.Length > 0 && set_val.Length > 0)
            {
                if (set_list.Text == "Ref_id" && where_list.Text == "Ref_id")
                    view = $"update staffs set {set} = {set_val} where {where} = {where_val};";

                else if (set_list.Text == "Ref_id" && where_list.Text != "Ref_id")
                    view = $"update staffs set {set} = {set_val} where {where} = \'{where_val}\';";

                else if (set_list.Text != "Ref_id" && where_list.Text == "Ref_id")
                    view = $"update staffs set {set} = \'{set_val}\' where {where} = {where_val};";

                else
                    view = $"update staffs set {set} = \'{set_val}\' where {where} = \'{where_val}\';";

                set_list.Text = "";
                txt_set.Text = "";
                where_list.Text = "";
                txt_where.Text = "";
                con.Open();
                SqlCommand cmd = new SqlCommand(view, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("successfully updated");
                view = "";
                this.Hide();
            }
        }
    }
}
