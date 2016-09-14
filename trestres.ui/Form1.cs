using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace trestres.ui
{
    public partial class Form1 : Form
    {
        public claseTres.Carrera miRace;

        public Form1()
        {
            InitializeComponent();
            foreach (claseTres.Efabricante item in Enum.GetValues(typeof(claseTres.Efabricante)))
            {
                this.comboBox1.Items.Add(item);
            }
            this.comboBox1.SelectedIndex = 1;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox2.SelectedIndex = 1;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            //this.miRace = new claseTres.Carrera();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxNombreCarrera.Text = "LA CARRERA";
            textBoxLugarCarrera.Text = "ACAHOYYA";
            textBoxFechaCarrera.Text = "ACAYAAHORA";

            miRace = new claseTres.Carrera();
            //miRace = new claseTres.Carrera(textBoxNombreCarrera.Text.ToString(), textBoxLugarCarrera.Text.ToString(), textBoxFechaCarrera.Text.ToString());
            this.gbCarrera.Enabled = false;
        }

        private void textBoxGBCarrera_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFechaCarrera_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLugarCarrera_TextChanged(object sender, EventArgs e)
        {

        }
        //Creo un auto y lo agrego. Muestro el piloto
        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            claseTres.Auto auto = new claseTres.Auto(this.textBoxNombrePiloto.Text.ToString(), (claseTres.Efabricante)this.comboBox1.SelectedItem);
            this.miRace.agregarAuto(auto);

            MostrarListPiloto();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Carrera_Enter(object sender, EventArgs e)
        {

        }

        public void MostrarListPiloto()
        {
            this.listBox1.Items.Clear();
            foreach (claseTres.Auto item in miRace.listaAutos)
            {
                this.listBox1.Items.Add(item.datosEnString);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXtiempo_Click(object sender, EventArgs e)
        {
            miRace.CorrerCarreraTime(int.Parse(this.textBoxToK.Text));
            this.textBox1.Text = miRace.MostrarCarreraTiempo();
            //this.textBox1.Text = miRace.MostrarGanador();
        }

        private void btnXkilometro_Click(object sender, EventArgs e)
        {
            miRace.CorrerCarrera(int.Parse(this.textBoxToK.Text));
            this.textBox1.Text = miRace.MostrarCarreraKilometros();
        }

        private void textBoxToK_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOrdenarMarca_Click(object sender, EventArgs e)
        {
            this.miRace.listaAutos.Sort(claseTres.Auto.ordenarXMarcaDesc);
            MostrarListPiloto();
        }

        private void btnOrdenarxPiloto_Click(object sender, EventArgs e)
        {
            this.miRace.listaAutos.Sort(claseTres.Auto.ordenarXMarcaDesc);
            MostrarListPiloto();
        }

        private void btnORDEnar_Click(object sender, EventArgs e)
        {
            if (rdBtnAsc.Checked == true)
            {
                if (this.comboBox2.SelectedIndex == 1)
                {
                    this.miRace.listaAutos.Sort(claseTres.Auto.ordenarXPilotoAsc);                   
                }
                this.miRace.listaAutos.Sort(claseTres.Auto.ordenarXMarcAsc);
            }

            if (rdbtnDesc.Checked == true)
            {
                if (this.comboBox2.SelectedIndex == 1)
                {
                    this.miRace.listaAutos.Sort(claseTres.Auto.ordenarXPilotoDesc);
                }
                this.miRace.listaAutos.Sort(claseTres.Auto.ordenarXMarcaDesc);
            }

            MostrarListPiloto();
        }

    }
    
}
