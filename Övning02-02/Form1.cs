using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Metoden visar en meddelande ruta
        private void button1_Click(object sender, EventArgs e)
        {
            // Här visas meddelande rutan.
            MessageBox.Show("är det roligt att programmera?", "Övning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
