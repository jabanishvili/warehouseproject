
namespace WindowsFormsApp1
{
    partial class addcategoryform
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
            this.add_category_lbl = new System.Windows.Forms.Label();
            this.add_category_pannel = new System.Windows.Forms.Panel();
            this.category_tb = new System.Windows.Forms.TextBox();
            this.add_category_update_btn = new System.Windows.Forms.Button();
            this.add_category_save_btn = new System.Windows.Forms.Button();
            this.add_category_category_lbl = new System.Windows.Forms.Label();
            this.add_category_head_pannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.add_category_pannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_category_head_pannel
            // 
            this.add_category_head_pannel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.add_category_head_pannel.Controls.Add(this.pictureBox1);
            this.add_category_head_pannel.Controls.Add(this.add_category_lbl);
            this.add_category_head_pannel.Location = new System.Drawing.Point(1, 1);
            this.add_category_head_pannel.Name = "add_category_head_pannel";
            this.add_category_head_pannel.Size = new System.Drawing.Size(270, 89);
            this.add_category_head_pannel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.wrong;
            this.pictureBox1.Location = new System.Drawing.Point(232, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // add_category_lbl
            // 
            this.add_category_lbl.AutoSize = true;
            this.add_category_lbl.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_category_lbl.Location = new System.Drawing.Point(66, 49);
            this.add_category_lbl.Name = "add_category_lbl";
            this.add_category_lbl.Size = new System.Drawing.Size(131, 23);
            this.add_category_lbl.TabIndex = 0;
            this.add_category_lbl.Text = "ADD Category";
            // 
            // add_category_pannel
            // 
            this.add_category_pannel.BackColor = System.Drawing.Color.Wheat;
            this.add_category_pannel.Controls.Add(this.category_tb);
            this.add_category_pannel.Controls.Add(this.add_category_update_btn);
            this.add_category_pannel.Controls.Add(this.add_category_save_btn);
            this.add_category_pannel.Controls.Add(this.add_category_category_lbl);
            this.add_category_pannel.Location = new System.Drawing.Point(1, 90);
            this.add_category_pannel.Name = "add_category_pannel";
            this.add_category_pannel.Size = new System.Drawing.Size(271, 157);
            this.add_category_pannel.TabIndex = 3;
            // 
            // category_tb
            // 
            this.category_tb.BackColor = System.Drawing.Color.Wheat;
            this.category_tb.Location = new System.Drawing.Point(13, 45);
            this.category_tb.Multiline = true;
            this.category_tb.Name = "category_tb";
            this.category_tb.Size = new System.Drawing.Size(204, 22);
            this.category_tb.TabIndex = 18;
            // 
            // add_category_update_btn
            // 
            this.add_category_update_btn.BackColor = System.Drawing.Color.Tan;
            this.add_category_update_btn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_category_update_btn.Location = new System.Drawing.Point(142, 94);
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
            this.add_category_save_btn.Location = new System.Drawing.Point(38, 94);
            this.add_category_save_btn.Name = "add_category_save_btn";
            this.add_category_save_btn.Size = new System.Drawing.Size(75, 33);
            this.add_category_save_btn.TabIndex = 15;
            this.add_category_save_btn.Text = "Save";
            this.add_category_save_btn.UseVisualStyleBackColor = false;
            this.add_category_save_btn.Click += new System.EventHandler(this.add_category_save_btn_Click);
            // 
            // add_category_category_lbl
            // 
            this.add_category_category_lbl.AutoSize = true;
            this.add_category_category_lbl.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_category_category_lbl.Location = new System.Drawing.Point(11, 13);
            this.add_category_category_lbl.Name = "add_category_category_lbl";
            this.add_category_category_lbl.Size = new System.Drawing.Size(68, 18);
            this.add_category_category_lbl.TabIndex = 4;
            this.add_category_category_lbl.Text = "Category";
            // 
            // addcategoryform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 248);
            this.Controls.Add(this.add_category_pannel);
            this.Controls.Add(this.add_category_head_pannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addcategoryform";
            this.Text = "addcategoryform";
            this.add_category_head_pannel.ResumeLayout(false);
            this.add_category_head_pannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.add_category_pannel.ResumeLayout(false);
            this.add_category_pannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel add_category_head_pannel;
        private System.Windows.Forms.Label add_category_lbl;
        private System.Windows.Forms.Panel add_category_pannel;
        private System.Windows.Forms.TextBox category_tb;
        private System.Windows.Forms.Button add_category_update_btn;
        private System.Windows.Forms.Button add_category_save_btn;
        private System.Windows.Forms.Label add_category_category_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}