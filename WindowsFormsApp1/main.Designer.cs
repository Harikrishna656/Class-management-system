
namespace WindowsFormsApp1
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_staffs = new System.Windows.Forms.Button();
            this.side_panel = new System.Windows.Forms.Panel();
            this.btn_events = new System.Windows.Forms.Button();
            this.btn_students = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.about1 = new WindowsFormsApp1.about();
            this.events1 = new WindowsFormsApp1.libraries();
            this.home1 = new WindowsFormsApp1.home();
            this.staffs1 = new WindowsFormsApp1.staffs();
            this.students1 = new WindowsFormsApp1.students();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.Black;
            this.btn_home.Location = new System.Drawing.Point(12, 150);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(188, 47);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_staffs
            // 
            this.btn_staffs.BackColor = System.Drawing.Color.Transparent;
            this.btn_staffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_staffs.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staffs.ForeColor = System.Drawing.Color.Black;
            this.btn_staffs.Location = new System.Drawing.Point(12, 256);
            this.btn_staffs.Name = "btn_staffs";
            this.btn_staffs.Size = new System.Drawing.Size(188, 47);
            this.btn_staffs.TabIndex = 2;
            this.btn_staffs.Text = "Staffs";
            this.btn_staffs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_staffs.UseVisualStyleBackColor = false;
            this.btn_staffs.Click += new System.EventHandler(this.btn_staffs_Click);
            // 
            // side_panel
            // 
            this.side_panel.BackColor = System.Drawing.Color.Maroon;
            this.side_panel.Location = new System.Drawing.Point(3, 150);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(10, 47);
            this.side_panel.TabIndex = 2;
            // 
            // btn_events
            // 
            this.btn_events.BackColor = System.Drawing.Color.Transparent;
            this.btn_events.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_events.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_events.ForeColor = System.Drawing.Color.Black;
            this.btn_events.Location = new System.Drawing.Point(12, 309);
            this.btn_events.Name = "btn_events";
            this.btn_events.Size = new System.Drawing.Size(188, 47);
            this.btn_events.TabIndex = 3;
            this.btn_events.Text = "Books";
            this.btn_events.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_events.UseVisualStyleBackColor = false;
            this.btn_events.Click += new System.EventHandler(this.btn_events_Click);
            // 
            // btn_students
            // 
            this.btn_students.BackColor = System.Drawing.Color.Transparent;
            this.btn_students.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_students.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_students.ForeColor = System.Drawing.Color.Black;
            this.btn_students.Location = new System.Drawing.Point(12, 203);
            this.btn_students.Name = "btn_students";
            this.btn_students.Size = new System.Drawing.Size(188, 47);
            this.btn_students.TabIndex = 2;
            this.btn_students.Text = "Students";
            this.btn_students.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_students.UseVisualStyleBackColor = false;
            this.btn_students.Click += new System.EventHandler(this.btn_students_Click);
            // 
            // btn_about
            // 
            this.btn_about.BackColor = System.Drawing.Color.Transparent;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.ForeColor = System.Drawing.Color.Black;
            this.btn_about.Location = new System.Drawing.Point(12, 362);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(188, 47);
            this.btn_about.TabIndex = 4;
            this.btn_about.Text = "About";
            this.btn_about.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(12, 623);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(188, 47);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_about);
            this.panel1.Controls.Add(this.btn_students);
            this.panel1.Controls.Add(this.btn_events);
            this.panel1.Controls.Add(this.side_panel);
            this.panel1.Controls.Add(this.btn_staffs);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 673);
            this.panel1.TabIndex = 1;
            // 
            // about1
            // 
            this.about1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("about1.BackgroundImage")));
            this.about1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.about1.Location = new System.Drawing.Point(200, 0);
            this.about1.Name = "about1";
            this.about1.Size = new System.Drawing.Size(1062, 673);
            this.about1.TabIndex = 2;
            // 
            // events1
            // 
            this.events1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("events1.BackgroundImage")));
            this.events1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.events1.Location = new System.Drawing.Point(200, 0);
            this.events1.Name = "events1";
            this.events1.Size = new System.Drawing.Size(1062, 673);
            this.events1.TabIndex = 3;
            // 
            // home1
            // 
            this.home1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home1.BackgroundImage")));
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(200, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1062, 673);
            this.home1.TabIndex = 4;
            // 
            // staffs1
            // 
            this.staffs1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("staffs1.BackgroundImage")));
            this.staffs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffs1.Location = new System.Drawing.Point(200, 0);
            this.staffs1.Name = "staffs1";
            this.staffs1.Size = new System.Drawing.Size(1062, 673);
            this.staffs1.TabIndex = 5;
            // 
            // students1
            // 
            this.students1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("students1.BackgroundImage")));
            this.students1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.students1.Location = new System.Drawing.Point(200, 0);
            this.students1.Name = "students1";
            this.students1.Size = new System.Drawing.Size(1062, 673);
            this.students1.TabIndex = 6;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.students1);
            this.Controls.Add(this.staffs1);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.events1);
            this.Controls.Add(this.about1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.Load += new System.EventHandler(this.main_load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_staffs;
        private System.Windows.Forms.Panel side_panel;
        private System.Windows.Forms.Button btn_events;
        private System.Windows.Forms.Button btn_students;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel1;
        private about about1;
        private libraries events1;
        private home home1;
        private staffs staffs1;
        private students students1;
    }
}

