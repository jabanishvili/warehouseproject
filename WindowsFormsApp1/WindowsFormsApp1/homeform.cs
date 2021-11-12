using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class homeform : Form
    {
        Form aFrom = null;
        public homeform()
        {
            InitializeComponent();
        }

        void OpenForm(Form form)
        { if (aFrom != null)
            {
                aFrom.Close();
            }
            aFrom = form;
            form.TopLevel = false;
            
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            home_body_pannel.Controls.Add(form);
            home_body_pannel.Tag = form;
            form.BringToFront();
            form.Show();

        }

       
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenForm(new costumerform());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            OpenForm(new userform());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenForm(new productform());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenForm(new categoriesformss());
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenForm(new orderform());
        }
    }
}
