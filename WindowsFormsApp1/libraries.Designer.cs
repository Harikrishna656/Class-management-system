
namespace WindowsFormsApp1
{
    partial class libraries
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(libraries));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_dis = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.book_add1 = new WindowsFormsApp1.book_add();
            this.book_delete1 = new WindowsFormsApp1.book_delete();
            this.book_update1 = new WindowsFormsApp1.book_update();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(60, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(933, 188);
            this.dataGridView1.TabIndex = 22;
            // 
            // btn_dis
            // 
            this.btn_dis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dis.Location = new System.Drawing.Point(840, 575);
            this.btn_dis.Name = "btn_dis";
            this.btn_dis.Size = new System.Drawing.Size(163, 47);
            this.btn_dis.TabIndex = 21;
            this.btn_dis.Text = "Display";
            this.btn_dis.UseVisualStyleBackColor = true;
            this.btn_dis.Click += new System.EventHandler(this.btn_dis_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(622, 575);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(129, 47);
            this.btn_delete.TabIndex = 20;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(332, 575);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(129, 47);
            this.btn_update.TabIndex = 19;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(70, 575);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(129, 47);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "Add New";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // book_add1
            // 
            this.book_add1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.book_add1.Location = new System.Drawing.Point(149, 105);
            this.book_add1.Name = "book_add1";
            this.book_add1.Size = new System.Drawing.Size(741, 421);
            this.book_add1.TabIndex = 23;
            // 
            // book_delete1
            // 
            this.book_delete1.BackColor = System.Drawing.Color.Orange;
            this.book_delete1.Location = new System.Drawing.Point(172, 244);
            this.book_delete1.Name = "book_delete1";
            this.book_delete1.Size = new System.Drawing.Size(707, 231);
            this.book_delete1.TabIndex = 24;
            // 
            // book_update1
            // 
            this.book_update1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.book_update1.Location = new System.Drawing.Point(170, 119);
            this.book_update1.Name = "book_update1";
            this.book_update1.Size = new System.Drawing.Size(709, 416);
            this.book_update1.TabIndex = 25;
            // 
            // libraries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.book_update1);
            this.Controls.Add(this.book_delete1);
            this.Controls.Add(this.book_add1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_dis);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Name = "libraries";
            this.Size = new System.Drawing.Size(1062, 673);
            this.Load += new System.EventHandler(this.libraries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_dis;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private book_add book_add1;
        private book_delete book_delete1;
        private book_update book_update1;
    }
}
