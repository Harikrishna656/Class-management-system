
namespace WindowsFormsApp1
{
    partial class home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.label1 = new System.Windows.Forms.Label();
            this.gridview_students = new System.Windows.Forms.DataGridView();
            this.grid_staffs = new System.Windows.Forms.DataGridView();
            this.gride_books = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_staffs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gride_books)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridview_students
            // 
            this.gridview_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_students.Location = new System.Drawing.Point(61, 162);
            this.gridview_students.Name = "gridview_students";
            this.gridview_students.RowHeadersWidth = 51;
            this.gridview_students.RowTemplate.Height = 24;
            this.gridview_students.Size = new System.Drawing.Size(240, 461);
            this.gridview_students.TabIndex = 1;
            // 
            // grid_staffs
            // 
            this.grid_staffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_staffs.Location = new System.Drawing.Point(400, 162);
            this.grid_staffs.Name = "grid_staffs";
            this.grid_staffs.RowHeadersWidth = 51;
            this.grid_staffs.RowTemplate.Height = 24;
            this.grid_staffs.Size = new System.Drawing.Size(240, 461);
            this.grid_staffs.TabIndex = 2;
            // 
            // gride_books
            // 
            this.gride_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gride_books.Location = new System.Drawing.Point(746, 162);
            this.gride_books.Name = "gride_books";
            this.gride_books.RowHeadersWidth = 51;
            this.gride_books.RowTemplate.Height = 24;
            this.gride_books.Size = new System.Drawing.Size(240, 461);
            this.gride_books.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 91);
            this.label2.TabIndex = 4;
            this.label2.Text = "Staffs";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(739, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 91);
            this.label3.TabIndex = 5;
            this.label3.Text = "Books";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gride_books);
            this.Controls.Add(this.grid_staffs);
            this.Controls.Add(this.gridview_students);
            this.Controls.Add(this.label1);
            this.Name = "home";
            this.Size = new System.Drawing.Size(1062, 673);
            this.Load += new System.EventHandler(this.home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_staffs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gride_books)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridview_students;
        private System.Windows.Forms.DataGridView grid_staffs;
        private System.Windows.Forms.DataGridView gride_books;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
