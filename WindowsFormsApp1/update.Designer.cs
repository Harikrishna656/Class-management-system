
namespace WindowsFormsApp1
{
    partial class update
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.set_list = new System.Windows.Forms.ComboBox();
            this.txt_where = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_set = new System.Windows.Forms.TextBox();
            this.where_list = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Set Column";
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(364, 328);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(134, 38);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // set_list
            // 
            this.set_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.set_list.FormattingEnabled = true;
            this.set_list.Items.AddRange(new object[] {
            "Roll_no",
            "full_name",
            "email",
            "phone_no"});
            this.set_list.Location = new System.Drawing.Point(75, 91);
            this.set_list.Name = "set_list";
            this.set_list.Size = new System.Drawing.Size(193, 39);
            this.set_list.TabIndex = 19;
            // 
            // txt_where
            // 
            this.txt_where.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_where.Location = new System.Drawing.Point(364, 247);
            this.txt_where.Name = "txt_where";
            this.txt_where.Size = new System.Drawing.Size(352, 38);
            this.txt_where.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ref or Old Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "New Value";
            // 
            // txt_set
            // 
            this.txt_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_set.Location = new System.Drawing.Point(364, 91);
            this.txt_set.Name = "txt_set";
            this.txt_set.Size = new System.Drawing.Size(352, 38);
            this.txt_set.TabIndex = 21;
            // 
            // where_list
            // 
            this.where_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.where_list.FormattingEnabled = true;
            this.where_list.Items.AddRange(new object[] {
            "Roll_no",
            "full_name",
            "email",
            "phone_no"});
            this.where_list.Location = new System.Drawing.Point(75, 247);
            this.where_list.Name = "where_list";
            this.where_list.Size = new System.Drawing.Size(193, 39);
            this.where_list.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "Where Column";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(582, 328);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(134, 38);
            this.btn_cancel.TabIndex = 25;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.where_list);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_set);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.set_list);
            this.Controls.Add(this.txt_where);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_update);
            this.Name = "update";
            this.Size = new System.Drawing.Size(761, 389);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ComboBox set_list;
        private System.Windows.Forms.TextBox txt_where;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_set;
        private System.Windows.Forms.ComboBox where_list;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cancel;
    }
}
