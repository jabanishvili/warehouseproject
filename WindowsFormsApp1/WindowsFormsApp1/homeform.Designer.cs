
using System;

namespace WindowsFormsApp1
{
    partial class homeform
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
            this.home_head_panel = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.home_users_lbl = new System.Windows.Forms.Label();
            this.home_customers_lbl = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.home_orders_lbl = new System.Windows.Forms.Label();
            this.home_categories_lbl = new System.Windows.Forms.Label();
            this.home_product_lbl = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.home_body_pannel = new System.Windows.Forms.Panel();
            this.home_head_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // home_head_panel
            // 
            this.home_head_panel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.home_head_panel.Controls.Add(this.pictureBox7);
            this.home_head_panel.Controls.Add(this.home_users_lbl);
            this.home_head_panel.Controls.Add(this.home_customers_lbl);
            this.home_head_panel.Controls.Add(this.pictureBox6);
            this.home_head_panel.Controls.Add(this.pictureBox5);
            this.home_head_panel.Controls.Add(this.home_orders_lbl);
            this.home_head_panel.Controls.Add(this.home_categories_lbl);
            this.home_head_panel.Controls.Add(this.home_product_lbl);
            this.home_head_panel.Controls.Add(this.pictureBox4);
            this.home_head_panel.Controls.Add(this.pictureBox3);
            this.home_head_panel.Controls.Add(this.pictureBox2);
            this.home_head_panel.Controls.Add(this.pictureBox1);
            this.home_head_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.home_head_panel.Location = new System.Drawing.Point(0, 0);
            this.home_head_panel.Name = "home_head_panel";
            this.home_head_panel.Size = new System.Drawing.Size(801, 112);
            this.home_head_panel.TabIndex = 0;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::WindowsFormsApp1.Properties.Resources.wrong;
            this.pictureBox7.Location = new System.Drawing.Point(766, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(29, 21);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // home_users_lbl
            // 
            this.home_users_lbl.AutoSize = true;
            this.home_users_lbl.BackColor = System.Drawing.Color.Tan;
            this.home_users_lbl.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_users_lbl.Location = new System.Drawing.Point(686, 78);
            this.home_users_lbl.Name = "home_users_lbl";
            this.home_users_lbl.Size = new System.Drawing.Size(45, 18);
            this.home_users_lbl.TabIndex = 9;
            this.home_users_lbl.Text = "Users";
            // 
            // home_customers_lbl
            // 
            this.home_customers_lbl.AutoSize = true;
            this.home_customers_lbl.BackColor = System.Drawing.Color.Tan;
            this.home_customers_lbl.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_customers_lbl.Location = new System.Drawing.Point(535, 78);
            this.home_customers_lbl.Name = "home_customers_lbl";
            this.home_customers_lbl.Size = new System.Drawing.Size(79, 18);
            this.home_customers_lbl.TabIndex = 8;
            this.home_customers_lbl.Text = "Customers";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.customer;
            this.pictureBox6.Location = new System.Drawing.Point(660, 11);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 64);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.customer_feedback;
            this.pictureBox5.Location = new System.Drawing.Point(524, 11);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // home_orders_lbl
            // 
            this.home_orders_lbl.AutoSize = true;
            this.home_orders_lbl.BackColor = System.Drawing.Color.Tan;
            this.home_orders_lbl.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_orders_lbl.Location = new System.Drawing.Point(414, 78);
            this.home_orders_lbl.Name = "home_orders_lbl";
            this.home_orders_lbl.Size = new System.Drawing.Size(49, 18);
            this.home_orders_lbl.TabIndex = 6;
            this.home_orders_lbl.Text = "orders";
            // 
            // home_categories_lbl
            // 
            this.home_categories_lbl.AutoSize = true;
            this.home_categories_lbl.BackColor = System.Drawing.Color.Tan;
            this.home_categories_lbl.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_categories_lbl.Location = new System.Drawing.Point(281, 78);
            this.home_categories_lbl.Name = "home_categories_lbl";
            this.home_categories_lbl.Size = new System.Drawing.Size(74, 18);
            this.home_categories_lbl.TabIndex = 5;
            this.home_categories_lbl.Text = "categories";
            this.home_categories_lbl.Click += new System.EventHandler(this.home_categories_lbl_Click);
            // 
            // home_product_lbl
            // 
            this.home_product_lbl.AutoSize = true;
            this.home_product_lbl.BackColor = System.Drawing.Color.Tan;
            this.home_product_lbl.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_product_lbl.Location = new System.Drawing.Point(158, 78);
            this.home_product_lbl.Name = "home_product_lbl";
            this.home_product_lbl.Size = new System.Drawing.Size(59, 18);
            this.home_product_lbl.TabIndex = 4;
            this.home_product_lbl.Text = "product";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.cargo;
            this.pictureBox4.Location = new System.Drawing.Point(391, 11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.options_lines;
            this.pictureBox3.Location = new System.Drawing.Point(269, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.shopping_cart_black_shape;
            this.pictureBox2.Location = new System.Drawing.Point(141, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.home;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // home_body_pannel
            // 
            this.home_body_pannel.BackColor = System.Drawing.Color.Wheat;
            this.home_body_pannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_body_pannel.Location = new System.Drawing.Point(0, 112);
            this.home_body_pannel.Name = "home_body_pannel";
            this.home_body_pannel.Size = new System.Drawing.Size(801, 290);
            this.home_body_pannel.TabIndex = 1;
            // 
            // homeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 402);
            this.Controls.Add(this.home_body_pannel);
            this.Controls.Add(this.home_head_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "homeform";
            this.Text = "homeform";
            this.home_head_panel.ResumeLayout(false);
            this.home_head_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        //private void pictureBox2_Click(object sender, EventArgs e)
        //{
        //    OpenForm(new categoriesformss());
        //}
        //private void pictureBox3_Click(object sender, EventArgs e)
        //{
        //    OpenForm(new categoriesformss());
        //}


        private void home_categories_lbl_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private System.Windows.Forms.Panel home_head_panel;
        private System.Windows.Forms.Panel home_body_pannel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label home_orders_lbl;
        private System.Windows.Forms.Label home_categories_lbl;
        private System.Windows.Forms.Label home_product_lbl;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label home_users_lbl;
        private System.Windows.Forms.Label home_customers_lbl;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}