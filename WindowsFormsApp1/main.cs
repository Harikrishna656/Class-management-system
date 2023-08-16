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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            home1.Show();
        }
        private void btn_home_Click(object sender, EventArgs e)
        {
            side_panel.Height = btn_home.Height;
            side_panel.Top = btn_home.Top;

            home1.Show();

            students1.Hide();
            staffs1.Hide();
            about1.Hide();
            events1.Hide();
        }
        private void btn_students_Click(object sender, EventArgs e)

        {
            side_panel.Height = btn_students.Height;
            side_panel.Top = btn_students.Top;

            students1.Show();

            home1.Hide();
            staffs1.Hide();
            about1.Hide();
            events1.Hide();
        }
        private void btn_staffs_Click(object sender, EventArgs e)
        {
            side_panel.Height = btn_staffs.Height;
            side_panel.Top = btn_staffs.Top;

            staffs1.Show();

            students1.Hide();
            home1.Hide();
            about1.Hide();
            events1.Hide();
        }
        private void btn_events_Click(object sender, EventArgs e)
        {
           side_panel.Height = btn_events.Height;
            side_panel.Top = btn_events.Top;

            events1.Show();

            staffs1.Hide();
            students1.Hide();
            home1.Hide();
            about1.Hide();
        }
        private void btn_about_Click(object sender, EventArgs e)
        {
           side_panel.Height = btn_about.Height;
            side_panel.Top = btn_about.Top;            

            about1.Show();

            staffs1.Hide();
            students1.Hide();
            home1.Hide();
            events1.Hide();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            side_panel.Height = btn_close.Height;
            side_panel.Top = btn_close.Top;
            new login().Close();
            this.Close();
        }
        private void main_load(object sender, EventArgs e)
        {
            home1.Show();
            students1.Hide();
            staffs1.Hide();
            about1.Hide();
            events1.Hide();
        }
    }
}
