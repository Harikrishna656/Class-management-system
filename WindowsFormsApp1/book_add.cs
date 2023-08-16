using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class book_add : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=MCA;Integrated Security=True");
        string isi, title, discrip, Author;

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public book_add()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            isi = txt_iso_no.Text;
            if (isi.Length <= 0)
            {
                MessageBox.Show("enter roll number");

            }
            else
            {
                for (int i = 0; i < isi.Length; i++)
                {
                    if (!Char.IsDigit(isi[i]))
                    {
                        MessageBox.Show("only number allowed in isi number ex. 7005");
                        txt_iso_no.Text = "";
                        isi = "";
                    }
                }
            }
            title = txt_title.Text;
            Author = txt_author.Text;
            discrip = txt_discrip.Text;

            if (Author.Length <= 0)
                Author = "null";
            if (title.Length <= 0)
                title = "null";
            if (discrip.Length <= 0)
                discrip = "null";

            if (Author.Length > 0 && title.Length > 0 && isi.Length > 0)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"insert into books values ({isi},\'{title}\',\'{Author}\',\'{discrip}\');", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("successfully added");
                txt_author.Text = "";
                txt_title.Text = "";
                txt_iso_no.Text = "";
                this.Hide();
            }
        }
    }
}
