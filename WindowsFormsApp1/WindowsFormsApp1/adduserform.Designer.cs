
namespace WindowsFormsApp1
{
    partial class adduserform
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
            this.add_category_head_pannel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.add_product_lbl = new System.Windows.Forms.Label();
            this.add_category_pannel = new System.Windows.Forms.Panel();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.emial_tb = new System.Windows.Forms.TextBox();
            this.fullname_tb = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.fullname = new System.Windows.Forms.Label();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.add_category_update_btn = new System.Windows.Forms.Button();
            this.add_category_save_btn = new System.Windows.Forms.Button();
            this.add_user_name_lbl = new System.Windows.Forms.Label();
            this.add_category_head_pannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.add_category_pannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_category_head_pannel
            // 
            this.add_category_head_pannel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.add_category_head_pannel.Controls.Add(this.pictureBox1);
            this.add_category_head_pannel.Controls.Add(this.add_product_lbl);
            this.add_category_head_pannel.Location = new System.Drawing.Point(0, 1);
            this.add_category_head_pannel.Name = "add_category_head_pannel";
            this.add_category_head_pannel.Size = new System.Drawing.Size(270, 82);
            this.add_category_head_pannel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.wrong;
            this.pictureBox1.Location = new System.Drawing.Point(230, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // add_product_lbl
            // 
            this.add_product_lbl.AutoSize = true;
            this.add_product_lbl.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_product_lbl.Location = new System.Drawing.Point(70, 42);
            this.add_product_lbl.Name = "add_product_lbl";
            this.add_product_lbl.Size = new System.Drawing.Size(123, 23);
            this.add_product_lbl.TabIndex = 0;
            this.add_product_lbl.Text = "ADD product";
            // 
            // add_category_pannel
            // 
            this.add_category_pannel.BackColor = System.Drawing.Color.Wheat;
            this.add_category_pannel.Controls.Add(this.password_tb);
            this.add_category_pannel.Controls.Add(this.emial_tb);
            this.add_category_pannel.Controls.Add(this.fullname_tb);
            this.add_category_pannel.Controls.Add(this.password_lbl);
            this.add_category_pannel.Controls.Add(this.email_lbl);
            this.add_category_pannel.Controls.Add(this.fullname);
            this.add_category_pannel.Controls.Add(this.username_tb);
            this.add_category_pannel.Controls.Add(this.add_category_update_btn);
            this.add_category_pannel.Controls.Add(this.add_category_save_btn);
            this.add_category_pannel.Controls.Add(this.add_user_name_lbl);
            this.add_category_pannel.Location = new System.Drawing.Point(0, 80);
            this.add_category_pannel.Name = "add_category_pannel";
            this.add_category_pannel.Size = new System.Drawing.Size(271, 281);
            this.add_category_pannel.TabIndex = 5;
            // 
            // password_tb
            // 
            this.password_tb.BackColor = System.Drawing.Color.Wheat;
            this.password_tb.Location = new System.Drawing.Point(25, 168);
            this.password_tb.Multiline = true;
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(204, 22);
            this.password_tb.TabIndex = 25;
            // 
            // emial_tb
            // 
            this.emial_tb.BackColor = System.Drawing.Color.Wheat;
            this.emial_tb.Location = new System.Drawing.Point(25, 117);
            this.emial_tb.Multiline = true;
            this.emial_tb.Name = "emial_tb";
            this.emial_tb.Size = new System.Drawing.Size(204, 22);
            this.emial_tb.TabIndex = 24;
            // 
            // fullname_tb
            // 
            this.fullname_tb.BackColor = System.Drawing.Color.Wheat;
            this.fullname_tb.Location = new System.Drawing.Point(25, 71);
            this.fullname_tb.Multiline = true;
            this.fullname_tb.Name = "fullname_tb";
            this.fullname_tb.Size = new System.Drawing.Size(204, 22);
            this.fullname_tb.TabIndex = 23;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.Location = new System.Drawing.Point(22, 147);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(71, 18);
            this.password_lbl.TabIndex = 21;
            this.password_lbl.Text = "Password";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.Location = new System.Drawing.Point(22, 96);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(48, 18);
            this.email_lbl.TabIndex = 20;
            this.email_lbl.Text = "Email";
            // 
            // fullname
            // 
            this.fullname.AutoSize = true;
            this.fullname.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname.Location = new System.Drawing.Point(22, 50);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(79, 18);
            this.fullname.TabIndex = 19;
            this.fullname.Text = "Full Name";
            // 
            // username_tb
            // 
            this.username_tb.BackColor = System.Drawing.Color.Wheat;
            this.username_tb.Location = new System.Drawing.Point(25, 25);
            this.username_tb.Multiline = true;
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(204, 22);
            this.username_tb.TabIndex = 18;
            // 
            // add_category_update_btn
            // 
            this.add_category_update_btn.BackColor = System.Drawing.Color.Tan;
            this.add_category_update_btn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_category_update_btn.Location = new System.Drawing.Point(133, 222);
            this.add_category_update_btn.Name = "add_category_update_btn";
            this.add_category_update_btn.Size = new System.Drawing.Size(75, 33);
            this.add_category_update_btn.TabIndex = 17;
            this.add_category_update_btn.Text = "Update";
            this.add_category_update_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.add_category_update_btn.UseVisualStyleBackColor = false;
            // 
            // add_category_save_btn
            // 
            this.add_category_save_btn.BackColor = System.Drawing.Color.Tan;
            this.add_category_save_btn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_category_save_btn.Location = new System.Drawing.Point(52, 222);
            this.add_category_save_btn.Name = "add_category_save_btn";
            this.add_category_save_btn.Size = new System.Drawing.Size(75, 33);
            this.add_category_save_btn.TabIndex = 15;
            this.add_category_save_btn.Text = "Save";
            this.add_category_save_btn.UseVisualStyleBackColor = false;
            this.add_category_save_btn.Click += new System.EventHandler(this.add_category_save_btn_Click);
            // 
            // add_user_name_lbl
            // 
            this.add_user_name_lbl.AutoSize = true;
            this.add_user_name_lbl.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_user_name_lbl.Location = new System.Drawing.Point(22, 4);
            this.add_user_name_lbl.Name = "add_user_name_lbl";
            this.add_user_name_lbl.Size = new System.Drawing.Size(84, 18);
            this.add_user_name_lbl.TabIndex = 4;
            this.add_user_name_lbl.Text = "User Name";
            // 
            // adduserform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 360);
            this.Controls.Add(this.add_category_pannel);
            this.Controls.Add(this.add_category_head_pannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adduserform";
            this.Text = "adduserform";
            this.add_category_head_pannel.ResumeLayout(false);
            this.add_category_head_pannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.add_category_pannel.ResumeLayout(false);
            this.add_category_pannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel add_category_head_pannel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label add_product_lbl;
        private System.Windows.Forms.Panel add_category_pannel;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.TextBox emial_tb;
        private System.Windows.Forms.TextBox fullname_tb;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label fullname;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.Button add_category_update_btn;
        private System.Windows.Forms.Button add_category_save_btn;
        private System.Windows.Forms.Label add_user_name_lbl;
    }
}