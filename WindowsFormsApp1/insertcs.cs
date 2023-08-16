using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class insertcs : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=MCA;Integrated Security=True");
        string id, name,Phone, email;

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_email.Text = "";
            txt_name.Text = "";
            txt_phone.Text = "";
            txt_roll.Text = "";
            this.Hide();
        }
        public insertcs()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            id = txt_roll.Text;
            if (id.Length <= 0)
            {
                MessageBox.Show("enter roll number");

            }
            else
            {
                for(int i = 0; i < id.Length; i++)
                {
                    if (!Char.IsDigit(id[i]))
                    {
                        MessageBox.Show("only number allowed in roll number ex. 7005");
                        txt_roll.Text = "";
                        id = "";
                    }
                }  
            }
            name = txt_name.Text;
            email = txt_email.Text;
            if (email.Length <= 0)
                email = "null";
            if (name.Length <= 0)
                name = "null";
            Phone = txt_phone.Text;
            if (Phone.Length > 0)
            {
                for (int i = 0; i < Phone.Length; i++)
                {
                    if (!Char.IsDigit(Phone[i]))
                    {
                        MessageBox.Show("only numbers allowed in Phone number");
                        txt_phone.Text = "";
                        Phone = "";
                    }
                }
            }
            else   if (Phone.Length <= 0)
                    Phone = "null";

            if(email.Length>0 && name.Length>0 && Phone.Length>0 && id.Length > 0)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"insert into students values ({id},\'{name}\',\'{email}\',\'{Phone}\');", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("successfully added");
                txt_email.Text = "";
                txt_name.Text = "";
                txt_phone.Text = "";
                txt_roll.Text = "";
                this.Hide();

            }

        }
    }
}