using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteFacturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Ferrete Factiracion";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(textBox1.Text);
            double numero2 = double.Parse(textBox2.Text);
            double numero3 = double.Parse(textBox3.Text);

            numero1 += numero3 += numero2;

            MessageBox.Show((numero1).ToString());
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(textBox1.Text);
            double numero2 = double.Parse(textBox2.Text);
            double numero3 = double.Parse(textBox3.Text);

            numero1 += numero2 += numero3;
            numero1 = numero1 / 3;
            MessageBox.Show((numero1).ToString());
           
        }

        private void btnPrecioFinal_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(textBox1.Text);
            double numero2 = double.Parse(textBox2.Text);
            double numero3 = double.Parse(textBox3.Text);

            numero1 += numero2 += numero3;

            double final = ((numero1) + (numero1* 1.21));

            MessageBox.Show((final).ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
