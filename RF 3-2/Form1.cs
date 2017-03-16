using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RF_3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int kod = int.Parse(tbxUnicode.Text);
            char tecken = (char)kod;
            
            lblSvar.Text = " detta tecken visas med denna kod    " + tecken.ToString();
        }
    }
}
