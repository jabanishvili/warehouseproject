
namespace WindowsFormsApp1
{
    partial class addorderform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.customerid_lbl = new System.Windows.Forms.Label();
            this.customername_lbl = new System.Windows.Forms.Label();
            this.productid_lbl = new System.Windows.Forms.Label();
            this.productname_lbl = new System.Windows.Forms.Label();
            this.orderdate_lbl = new System.Windows.Forms.Label();
            this.price_lbl = new System.Windows.Forms.Label();
            this.customerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.qty_lbl = new System.Windows.Forms.Label();
            this.costumerid_tb = new System.Windows.Forms.TextBox();
            this.costumername_tb = new System.Windows.Forms.TextBox();
            this.productid_tb = new System.Windows.Forms.TextBox();
            this.productname_tb = new System.Windows.Forms.TextBox();
            this.price_tb = new System.Windows.Forms.TextBox();
            this.qty_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.orderid_tb = new System.Windows.Forms.TextBox();
            this.add_category_head_pannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // add_category_head_pannel
            // 
            this.add_category_head_pannel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.add_category_head_pannel.Controls.Add(this.panel3);
            this.add_category_head_pannel.Controls.Add(this.panel2);
            this.add_category_head_pannel.Controls.Add(this.flowLayoutPanel1);
            this.add_category_head_pannel.Controls.Add(this.panel1);
            this.add_category_head_pannel.Controls.Add(this.pictureBox1);
            this.add_category_head_pannel.Controls.Add(this.add_product_lbl);
            this.add_category_head_pannel.Dock = System.Windows.Forms.DockStyle.Top;
            this.add_category_head_pannel.Location = new System.Drawing.Point(0, 0);
            this.add_category_head_pannel.Name = "add_category_head_pannel";
            this.add_category_head_pannel.Size = new System.Drawing.Size(743, 82);
            this.add_category_head_pannel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.wrong;
            this.pictureBox1.Location = new System.Drawing.Point(685, 3);
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
            this.add_product_lbl.Location = new System.Drawing.Point(313, 38);
            this.add_product_lbl.Name = "add_product_lbl";
            this.add_product_lbl.Size = new System.Drawing.Size(110, 23);
            this.add_product_lbl.TabIndex = 0;
            this.add_product_lbl.Text = "ADD orders";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 88);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(233, 224);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 176);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 205);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Wheat;
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(3, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(305, 154);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Wheat;
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Location = new System.Drawing.Point(307, 85);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(436, 154);
            this.panel5.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(3, 163);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(298, 262);
            this.panel6.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Wheat;
            this.panel7.Controls.Add(this.button2);
            this.panel7.Controls.Add(this.button1);
            this.panel7.Controls.Add(this.qty_tb);
            this.panel7.Controls.Add(this.price_tb);
            this.panel7.Controls.Add(this.productname_tb);
            this.panel7.Controls.Add(this.productid_tb);
            this.panel7.Controls.Add(this.qty_lbl);
            this.panel7.Controls.Add(this.dateTimePicker1);
            this.panel7.Controls.Add(this.productname_lbl);
            this.panel7.Controls.Add(this.price_lbl);
            this.panel7.Controls.Add(this.productid_lbl);
            this.panel7.Controls.Add(this.orderdate_lbl);
            this.panel7.Location = new System.Drawing.Point(307, 237);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(436, 267);
            this.panel7.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(3, 163);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(298, 252);
            this.panel8.TabIndex = 13;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(3, 163);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(298, 259);
            this.panel9.TabIndex = 13;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Wheat;
            this.panel10.Controls.Add(this.orderid_tb);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.costumername_tb);
            this.panel10.Controls.Add(this.costumerid_tb);
            this.panel10.Controls.Add(this.customername_lbl);
            this.panel10.Controls.Add(this.customerid_lbl);
            this.panel10.Location = new System.Drawing.Point(3, 240);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(305, 264);
            this.panel10.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productid,
            this.productname,
            this.PRICE,
            this.qty});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(436, 154);
            this.dataGridView1.TabIndex = 0;
            // 
            // productid
            // 
            this.productid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productid.HeaderText = "Product ID";
            this.productid.Name = "productid";
            this.productid.Width = 83;
            // 
            // productname
            // 
            this.productname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productname.HeaderText = "Product Name";
            this.productname.Name = "productname";
            // 
            // PRICE
            // 
            this.PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PRICE.HeaderText = "Price";
            this.PRICE.Name = "PRICE";
            this.PRICE.Width = 56;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            this.qty.Width = 48;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerid,
            this.customername});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(305, 154);
            this.dataGridView2.TabIndex = 14;
            // 
            // customerid_lbl
            // 
            this.customerid_lbl.AutoSize = true;
            this.customerid_lbl.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerid_lbl.Location = new System.Drawing.Point(32, 34);
            this.customerid_lbl.Name = "customerid_lbl";
            this.customerid_lbl.Size = new System.Drawing.Size(86, 16);
            this.customerid_lbl.TabIndex = 0;
            this.customerid_lbl.Text = "Customer ID";
            // 
            // customername_lbl
            // 
            this.customername_lbl.AutoSize = true;
            this.customername_lbl.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customername_lbl.Location = new System.Drawing.Point(32, 113);
            this.customername_lbl.Name = "customername_lbl";
            this.customername_lbl.Size = new System.Drawing.Size(107, 16);
            this.customername_lbl.TabIndex = 2;
            this.customername_lbl.Text = "Customer Name";
            // 
            // productid_lbl
            // 
            this.productid_lbl.AutoSize = true;
            this.productid_lbl.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productid_lbl.Location = new System.Drawing.Point(51, 37);
            this.productid_lbl.Name = "productid_lbl";
            this.productid_lbl.Size = new System.Drawing.Size(76, 16);
            this.productid_lbl.TabIndex = 4;
            this.productid_lbl.Text = "Product ID";
            // 
            // productname_lbl
            // 
            this.productname_lbl.AutoSize = true;
            this.productname_lbl.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productname_lbl.Location = new System.Drawing.Point(51, 116);
            this.productname_lbl.Name = "productname_lbl";
            this.productname_lbl.Size = new System.Drawing.Size(97, 16);
            this.productname_lbl.TabIndex = 6;
            this.productname_lbl.Text = "Product Name";
            // 
            // orderdate_lbl
            // 
            this.orderdate_lbl.AutoSize = true;
            this.orderdate_lbl.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderdate_lbl.Location = new System.Drawing.Point(52, 170);
            this.orderdate_lbl.Name = "orderdate_lbl";
            this.orderdate_lbl.Size = new System.Drawing.Size(75, 16);
            this.orderdate_lbl.TabIndex = 1;
            this.orderdate_lbl.Text = "Order Date";
            // 
            // price_lbl
            // 
            this.price_lbl.AutoSize = true;
            this.price_lbl.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_lbl.Location = new System.Drawing.Point(277, 37);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(40, 16);
            this.price_lbl.TabIndex = 3;
            this.price_lbl.Text = "Price";
            // 
            // customerid
            // 
            this.customerid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerid.HeaderText = "Customer ID";
            this.customerid.Name = "customerid";
            // 
            // customername
            // 
            this.customername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customername.HeaderText = "Customer Name";
            this.customername.Name = "customername";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(44, 189);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // qty_lbl
            // 
            this.qty_lbl.AutoSize = true;
            this.qty_lbl.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty_lbl.Location = new System.Drawing.Point(277, 116);
            this.qty_lbl.Name = "qty_lbl";
            this.qty_lbl.Size = new System.Drawing.Size(30, 16);
            this.qty_lbl.TabIndex = 8;
            this.qty_lbl.Text = "Qty";
            // 
            // costumerid_tb
            // 
            this.costumerid_tb.Location = new System.Drawing.Point(26, 56);
            this.costumerid_tb.Name = "costumerid_tb";
            this.costumerid_tb.Size = new System.Drawing.Size(155, 20);
            this.costumerid_tb.TabIndex = 3;
            // 
            // costumername_tb
            // 
            this.costumername_tb.Location = new System.Drawing.Point(26, 132);
            this.costumername_tb.Name = "costumername_tb";
            this.costumername_tb.Size = new System.Drawing.Size(155, 20);
            this.costumername_tb.TabIndex = 4;
            // 
            // productid_tb
            // 
            this.productid_tb.Location = new System.Drawing.Point(44, 59);
            this.productid_tb.Name = "productid_tb";
            this.productid_tb.Size = new System.Drawing.Size(154, 20);
            this.productid_tb.TabIndex = 9;
            // 
            // productname_tb
            // 
            this.productname_tb.Location = new System.Drawing.Point(44, 135);
            this.productname_tb.Name = "productname_tb";
            this.productname_tb.Size = new System.Drawing.Size(154, 20);
            this.productname_tb.TabIndex = 10;
            // 
            // price_tb
            // 
            this.price_tb.Location = new System.Drawing.Point(261, 56);
            this.price_tb.Name = "price_tb";
            this.price_tb.Size = new System.Drawing.Size(154, 20);
            this.price_tb.TabIndex = 11;
            // 
            // qty_tb
            // 
            this.qty_tb.Location = new System.Drawing.Point(261, 135);
            this.qty_tb.Name = "qty_tb";
            this.qty_tb.Size = new System.Drawing.Size(154, 20);
            this.qty_tb.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(214, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "make order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tan;
            this.button2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(323, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 27);
            this.button2.TabIndex = 14;
            this.button2.Text = "delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Order ID";
            // 
            // orderid_tb
            // 
            this.orderid_tb.Location = new System.Drawing.Point(26, 207);
            this.orderid_tb.Name = "orderid_tb";
            this.orderid_tb.Size = new System.Drawing.Size(155, 20);
            this.orderid_tb.TabIndex = 6;
            // 
            // addorderform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 512);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.add_category_head_pannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addorderform";
            this.Text = "addorderform";
            this.add_category_head_pannel.ResumeLayout(false);
            this.add_category_head_pannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel add_category_head_pannel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label add_product_lbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn customername;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.TextBox qty_tb;
        private System.Windows.Forms.TextBox price_tb;
        private System.Windows.Forms.TextBox productname_tb;
        private System.Windows.Forms.TextBox productid_tb;
        private System.Windows.Forms.Label qty_lbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label productname_lbl;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.Label productid_lbl;
        private System.Windows.Forms.Label orderdate_lbl;
        private System.Windows.Forms.TextBox costumername_tb;
        private System.Windows.Forms.TextBox costumerid_tb;
        private System.Windows.Forms.Label customername_lbl;
        private System.Windows.Forms.Label customerid_lbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox orderid_tb;
        private System.Windows.Forms.Label label1;
    }
}