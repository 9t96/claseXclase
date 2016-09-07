using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinturasFerrete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Pinturas Ferrete";
        }

        private void btnFaC_Click(object sender, EventArgs e)
        {

            MessageBox.Show("La temperatura en grados centigrados es: "+temp);
        }

        private void btnCaF_Click(object sender, EventArgs e)
        {
            double temp=double.Parse(textBox1.Text);

            temp = (temp*1.8) + 32;

            MessageBox.Show("La temperatura en Fahrenheit es: " + temp);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            PinturasFerrete.Temperaturas.
        }
    }
}
