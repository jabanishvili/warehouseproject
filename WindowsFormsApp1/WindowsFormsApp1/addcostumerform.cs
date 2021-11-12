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
    public partial class addcostumerform : Form
    {
        string path = @"data source=DESKTOP-BTHFLIN;initial catalog=prodactDB;integrated security=true";
        SqlConnection con;
        SqlCommand cmd;
        //SqlDataReader sdr;
        public addcostumerform()
        {
            con = new SqlConnection(path);
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_costumer_save_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand($"insert into costumers_table (Name,Phone,Address,Email)values('{costumername_tb.Text}',{Convert.ToInt32(costumerphone_tb.Text)},'{costumer_addres_tb.Text}','{cost_email_tb}')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
