
namespace WindowsFormsApp1
{
    partial class addproductform
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
            this.category_cb_addproduct = new System.Windows.Forms.ComboBox();
            this.description_tb = new System.Windows.Forms.TextBox();
            this.price_tb = new System.Windows.Forms.TextBox();
            this.qty_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.description_lbl = new System.Windows.Forms.Label();
            this.price_lbl = new System.Windows.Forms.Label();
            this.QTY = new System.Windows.Forms.Label();
            this.productname_tb = new System.Windows.Forms.TextBox();
            this.add_category_update_btn = new System.Windows.Forms.Button();
            this.add_category_save_btn = new System.Windows.Forms.Button();
            this.add_product_name_lbl = new System.Windows.Forms.Label();
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
            this.add_category_head_pannel.Location = new System.Drawing.Point(2, 3);
            this.add_category_head_pannel.Name = "add_category_head_pannel";
            this.add_category_head_pannel.Size = new System.Drawing.Size(270, 82);
            this.add_category_head_pannel.TabIndex = 3;
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
            this.add_product_lbl.Location = new System.Drawing.Point(70, 43);
            this.add_product_lbl.Name = "add_product_lbl";
            this.add_product_lbl.Size = new System.Drawing.Size(123, 23);
            this.add_product_lbl.TabIndex = 0;
            this.add_product_lbl.Text = "ADD product";
            // 
            // add_category_pannel
            // 
            this.add_category_pannel.BackColor = System.Drawing.Color.Wheat;
            this.add_category_pannel.Controls.Add(this.category_cb_addproduct);
            this.add_category_pannel.Controls.Add(this.description_tb);
            this.add_category_pannel.Controls.Add(this.price_tb);
            this.add_category_pannel.Controls.Add(this.qty_tb);
            this.add_category_pannel.Controls.Add(this.label4);
            this.add_category_pannel.Controls.Add(this.description_lbl);
            this.add_category_pannel.Controls.Add(this.price_lbl);
            this.add_category_pannel.Controls.Add(this.QTY);
            this.add_category_pannel.Controls.Add(this.productname_tb);
            this.add_category_pannel.Controls.Add(this.add_category_update_btn);
            this.add_category_pannel.Controls.Add(this.add_category_save_btn);
            this.add_category_pannel.Controls.Add(this.add_product_name_lbl);
            this.add_category_pannel.Location = new System.Drawing.Point(2, 84);
            this.add_category_pannel.Name = "add_category_pannel";
            this.add_category_pannel.Size = new System.Drawing.Size(271, 290);
            this.add_category_pannel.TabIndex = 4;
            // 
            // category_cb_addproduct
            // 
            this.category_cb_addproduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category_cb_addproduct.FormattingEnabled = true;
            this.category_cb_addproduct.Location = new System.Drawing.Point(25, 214);
            this.category_cb_addproduct.Name = "category_cb_addproduct";
            this.category_cb_addproduct.Size = new System.Drawing.Size(204, 21);
            this.category_cb_addproduct.TabIndex = 26;
            // 
            // description_tb
            // 
            this.description_tb.BackColor = System.Drawing.Color.Wheat;
            this.description_tb.Location = new System.Drawing.Point(25, 168);
            this.description_tb.Multiline = true;
            this.description_tb.Name = "description_tb";
            this.description_tb.Size = new System.Drawing.Size(204, 22);
            this.description_tb.TabIndex = 25;
            // 
            // price_tb
            // 
            this.price_tb.BackColor = System.Drawing.Color.Wheat;
            this.price_tb.Location = new System.Drawing.Point(25, 117);
            this.price_tb.Multiline = true;
            this.price_tb.Name = "price_tb";
            this.price_tb.Size = new System.Drawing.Size(204, 22);
            this.price_tb.TabIndex = 24;
            // 
            // qty_tb
            // 
            this.qty_tb.BackColor = System.Drawing.Color.Wheat;
            this.qty_tb.Location = new System.Drawing.Point(25, 71);
            this.qty_tb.Multiline = true;
            this.qty_tb.Name = "qty_tb";
            this.qty_tb.Size = new System.Drawing.Size(204, 22);
            this.qty_tb.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Category";
            // 
            // description_lbl
            // 
            this.description_lbl.AutoSize = true;
            this.description_lbl.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_lbl.Location = new System.Drawing.Point(22, 147);
            this.description_lbl.Name = "description_lbl";
            this.description_lbl.Size = new System.Drawing.Size(83, 18);
            this.description_lbl.TabIndex = 21;
            this.description_lbl.Text = "Description";
            // 
            // price_lbl
            // 
            this.price_lbl.AutoSize = true;
            this.price_lbl.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_lbl.Location = new System.Drawing.Point(22, 96);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(41, 18);
            this.price_lbl.TabIndex = 20;
            this.price_lbl.Text = "Price";
            // 
            // QTY
            // 
            this.QTY.AutoSize = true;
            this.QTY.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QTY.Location = new System.Drawing.Point(22, 50);
            this.QTY.Name = "QTY";
            this.QTY.Size = new System.Drawing.Size(33, 18);
            this.QTY.TabIndex = 19;
            this.QTY.Text = "Qty";
            // 
            // productname_tb
            // 
            this.productname_tb.BackColor = System.Drawing.Color.Wheat;
            this.productname_tb.Location = new System.Drawing.Point(25, 25);
            this.productname_tb.Multiline = true;
            this.productname_tb.Name = "productname_tb";
            this.productname_tb.Size = new System.Drawing.Size(204, 22);
            this.productname_tb.TabIndex = 18;
            // 
            // add_category_update_btn
            // 
            this.add_category_update_btn.BackColor = System.Drawing.Color.Tan;
            this.add_category_update_btn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_category_update_btn.Location = new System.Drawing.Point(133, 251);
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
            this.add_category_save_btn.Location = new System.Drawing.Point(52, 251);
            this.add_category_save_btn.Name = "add_category_save_btn";
            this.add_category_save_btn.Size = new System.Drawing.Size(75, 33);
            this.add_category_save_btn.TabIndex = 15;
            this.add_category_save_btn.Text = "Save";
            this.add_category_save_btn.UseVisualStyleBackColor = false;
            this.add_category_save_btn.Click += new System.EventHandler(this.add_category_save_btn_Click);
            // 
            // add_product_name_lbl
            // 
            this.add_product_name_lbl.AutoSize = true;
            this.add_product_name_lbl.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_product_name_lbl.Location = new System.Drawing.Point(22, 4);
            this.add_product_name_lbl.Name = "add_product_name_lbl";
            this.add_product_name_lbl.Size = new System.Drawing.Size(105, 18);
            this.add_product_name_lbl.TabIndex = 4;
            this.add_product_name_lbl.Text = "Product Name";
            // 
            // addproductform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 373);
            this.Controls.Add(this.add_category_pannel);
            this.Controls.Add(this.add_category_head_pannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addproductform";
            this.Text = "addproductform";
            this.add_category_head_pannel.ResumeLayout(false);
            this.add_category_head_pannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.add_category_pannel.ResumeLayout(false);
            this.add_category_pannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel add_category_head_pannel;
        private System.Windows.Forms.Label add_product_lbl;
        private System.Windows.Forms.Panel add_category_pannel;
        private System.Windows.Forms.TextBox productname_tb;
        private System.Windows.Forms.Button add_category_update_btn;
        private System.Windows.Forms.Button add_category_save_btn;
        private System.Windows.Forms.Label add_product_name_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label description_lbl;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.Label QTY;
        private System.Windows.Forms.TextBox qty_tb;
        private System.Windows.Forms.TextBox price_tb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox category_cb_addproduct;
        private System.Windows.Forms.TextBox description_tb;
    }
}