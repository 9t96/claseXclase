using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormmm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string aux;
            aux = this.txtNombre.Text;
            MessageBox.Show(aux);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.label1.Text="Cambie el texto";
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            this.btnAprobarmateria.Visible = false;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.btnAprobarmateria.Visible = true;
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            this.btnAprobarmateria.Visible = true;
        }
    }
}
