using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class addproductform : Form
    {
        string path = @"data source=DESKTOP-BTHFLIN;initial catalog=prodactDB;integrated security=true";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader sdr;
        
        public addproductform()
        {
            con = new SqlConnection(path);
            InitializeComponent();
            InsertCategory();
        }
        void InsertCategory()
        {
            con.Open();
            cmd = new SqlCommand($"Select * from category_table", con);
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                category_cb_addproduct.Items.Add(sdr[1].ToString());
            }
            sdr.Close();
            con.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_category_save_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand($"insert into product_tb (Name,QTY,Price,Categories,Description)values('{productname_tb.Text}',{Convert.ToInt32(qty_tb.Text)},{Convert.ToInt32(price_tb.Text)},'{category_cb_addproduct.Text}','{description_tb.Text}')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
