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
    public partial class adduserform : Form
    {
        string path = @"data source=DESKTOP-BTHFLIN;initial catalog=prodactDB;integrated security=true";
        SqlConnection con;
        SqlCommand cmd;
        public adduserform()
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
            cmd = new SqlCommand($"insert into Users_table (UserName,FullName,Email,Password)values('{username_tb.Text}','{fullname_tb.Text}','{emial_tb.Text}','{password_tb.Text}')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
