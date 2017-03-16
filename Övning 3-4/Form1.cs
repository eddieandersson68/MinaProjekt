using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxEngelska_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            string engelska = tbxEngelska.Text;
            string svenska = tbxSvenska.Text;

            lblSvar.Text = engelska + " betyder " + svenska + " på Svenska. ";
        }
    }
}
