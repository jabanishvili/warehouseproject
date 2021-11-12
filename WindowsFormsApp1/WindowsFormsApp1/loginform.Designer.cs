
namespace WindowsFormsApp1
{
    partial class loginform
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
            this.body_panel_lbl = new System.Windows.Forms.Panel();
            this.head_panel_lbl = new System.Windows.Forms.FlowLayoutPanel();
            this.username_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.enter_button = new System.Windows.Forms.Button();
            this.user_picturebox = new System.Windows.Forms.PictureBox();
            this.body_panel_lbl.SuspendLayout();
            this.head_panel_lbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // body_panel_lbl
            // 
            this.body_panel_lbl.BackColor = System.Drawing.Color.Wheat;
            this.body_panel_lbl.Controls.Add(this.enter_button);
            this.body_panel_lbl.Controls.Add(this.textBox2);
            this.body_panel_lbl.Controls.Add(this.textBox1);
            this.body_panel_lbl.Controls.Add(this.password_lbl);
            this.body_panel_lbl.Controls.Add(this.username_lbl);
            this.body_panel_lbl.Location = new System.Drawing.Point(1, 140);
            this.body_panel_lbl.Name = "body_panel_lbl";
            this.body_panel_lbl.Size = new System.Drawing.Size(289, 309);
            this.body_panel_lbl.TabIndex = 0;
            // 
            // head_panel_lbl
            // 
            this.head_panel_lbl.BackColor = System.Drawing.Color.AntiqueWhite;
            this.head_panel_lbl.Controls.Add(this.user_picturebox);
            this.head_panel_lbl.Location = new System.Drawing.Point(1, 2);
            this.head_panel_lbl.Name = "head_panel_lbl";
            this.head_panel_lbl.Size = new System.Drawing.Size(289, 139);
            this.head_panel_lbl.TabIndex = 0;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.Location = new System.Drawing.Point(112, 41);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(74, 18);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Text = "username";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.Location = new System.Drawing.Point(112, 127);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(70, 18);
            this.password_lbl.TabIndex = 1;
            this.password_lbl.Text = "password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 28);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 173);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 28);
            this.textBox2.TabIndex = 3;
            // 
            // enter_button
            // 
            this.enter_button.BackColor = System.Drawing.Color.Tan;
            this.enter_button.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_button.Location = new System.Drawing.Point(95, 231);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(101, 29);
            this.enter_button.TabIndex = 4;
            this.enter_button.Text = "enter";
            this.enter_button.UseVisualStyleBackColor = false;
            // 
            // user_picturebox
            // 
            this.user_picturebox.Image = global::WindowsFormsApp1.Properties.Resources.user;
            this.user_picturebox.InitialImage = null;
            this.user_picturebox.Location = new System.Drawing.Point(2, 2);
            this.user_picturebox.Margin = new System.Windows.Forms.Padding(2);
            this.user_picturebox.Name = "user_picturebox";
            this.user_picturebox.Size = new System.Drawing.Size(287, 139);
            this.user_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_picturebox.TabIndex = 5;
            this.user_picturebox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 450);
            this.Controls.Add(this.head_panel_lbl);
            this.Controls.Add(this.body_panel_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.body_panel_lbl.ResumeLayout(false);
            this.body_panel_lbl.PerformLayout();
            this.head_panel_lbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel body_panel_lbl;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.FlowLayoutPanel head_panel_lbl;
        private System.Windows.Forms.PictureBox user_picturebox;
    }
}

