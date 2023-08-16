
namespace WindowsFormsApp1
{
    partial class students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(students));
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_dis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update1 = new WindowsFormsApp1.update();
            this.delete1 = new WindowsFormsApp1.delete();
            this.insertcs1 = new WindowsFormsApp1.insertcs();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(66, 572);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(129, 47);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add New";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(328, 572);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(129, 47);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(618, 572);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(129, 47);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_dis
            // 
            this.btn_dis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dis.Location = new System.Drawing.Point(836, 572);
            this.btn_dis.Name = "btn_dis";
            this.btn_dis.Size = new System.Drawing.Size(163, 47);
            this.btn_dis.TabIndex = 5;
            this.btn_dis.Text = "Display";
            this.btn_dis.UseVisualStyleBackColor = true;
            this.btn_dis.Click += new System.EventHandler(this.btn_dis_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(933, 188);
            this.dataGridView1.TabIndex = 8;
            // 
            // update1
            // 
            this.update1.BackColor = System.Drawing.Color.Lime;
            this.update1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.update1.Location = new System.Drawing.Point(141, 152);
            this.update1.Name = "update1";
            this.update1.Size = new System.Drawing.Size(761, 389);
            this.update1.TabIndex = 12;
            // 
            // delete1
            // 
            this.delete1.BackColor = System.Drawing.Color.LightCoral;
            this.delete1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.delete1.Location = new System.Drawing.Point(214, 210);
            this.delete1.Name = "delete1";
            this.delete1.Size = new System.Drawing.Size(597, 198);
            this.delete1.TabIndex = 11;
            // 
            // insertcs1
            // 
            this.insertcs1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insertcs1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.insertcs1.Location = new System.Drawing.Point(57, 240);
            this.insertcs1.Name = "insertcs1";
            this.insertcs1.Size = new System.Drawing.Size(933, 207);
            this.insertcs1.TabIndex = 9;
            // 
            // students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.update1);
            this.Controls.Add(this.delete1);
            this.Controls.Add(this.insertcs1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_dis);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Name = "students";
            this.Size = new System.Drawing.Size(1062, 673);
            this.Load += new System.EventHandler(this.students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_dis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private insertcs insertcs1;
        private delete delete1;
        private update update1;
    }
}
