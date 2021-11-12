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
    public partial class userform : Form
    {
        public userform()
        {
            InitializeComponent();
        }

        private void useradd_pb_Click(object sender, EventArgs e)
        {
            adduserform auf = new adduserform();
           auf.ShowDialog();
        }
    }
}
