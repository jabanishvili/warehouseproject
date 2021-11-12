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
    public partial class addorderform : Form
    {
        string path = @"data source=DESKTOP-BTHFLIN;initial catalog=prodactDB;integrated security=true";
        SqlConnection con;
        SqlCommand cmd;
        
        public addorderform()
        {
            con = new SqlConnection(path);
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand($"insert into order_table (orderid,orderdata,productid,productname,customerid,customername,price,qty) values ('{Convert.ToInt32(orderid_tb.Text)}',''{Convert.ToInt32(productid_tb.Text)}','{productname_tb.Text}','{Convert.ToInt32(costumerid_tb.Text)},'{Convert.ToInt32(price_tb.Text)},'{Convert.ToInt32(qty_tb.Text)}')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
