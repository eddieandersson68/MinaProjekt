using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnKör_Click(object sender, EventArgs e)
        {
        int talA = int.Parse(tbxA.Text);
        int talB = int.Parse(tbxB.Text);
        int talC = int.Parse(tbxC.Text);
        double summa = talA + talB + talC;
        double medel = summa / 3;
        string text = summa.ToString();
        lblSumma.Text = "summa: " + summa;
        lblMedel.Text = "Medelvärde: " + medel;

    }
}
}
