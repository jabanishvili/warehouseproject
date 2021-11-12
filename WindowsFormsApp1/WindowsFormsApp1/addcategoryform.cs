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
    public partial class addcategoryform : Form
    {
        string path = @"data source=DESKTOP-BTHFLIN;initial catalog=prodactDB;integrated security=true";
        SqlConnection con;
        SqlCommand com;
        public addcategoryform()
        {
            con = new SqlConnection(path);
            InitializeComponent();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_category_save_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            com = new SqlCommand($"insert into category_table (categoryname) values ('{category_tb.Text}')", con);
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
