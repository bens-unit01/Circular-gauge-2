using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestJauge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
           circularGauge21.Value = float.Parse(txtNouvelleValeur.Text);
        }
    }
}
