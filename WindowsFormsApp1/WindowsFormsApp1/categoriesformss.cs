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
    public partial class categoriesformss : Form
    {
        public categoriesformss()
        {
            InitializeComponent();
        }

        private void pictureBoxx_categoryform_Click(object sender, EventArgs e)
        {
            addcategoryform acf = new addcategoryform();
            acf.ShowDialog();
        }
    }
}
