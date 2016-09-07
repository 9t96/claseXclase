using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerretePinturasTP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Pinturas Ferrete";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(label1.Text);

            MessageBox.Show("Hola");
        }


        private void btnCaF_Click(object sender, EventArgs e)
        {


        }
    }
}
