using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioCampu_Clase7
{
    public class Cajon
    {
        public List<Fruta> kjon;
        public int volumen;

        private Cajon()
        {
            kjon = new List<Fruta>();
        }

        public Cajon(int volumen)
        {
            this.volumen = volumen;
        }

        /*Métodos públicos y de instancia:
        CalcularEspacioDisponible: calculará cuánto espacio queda en el cajón
        MostrarContenido: retornará un string con el volumen total ocupado del cajón, el volumen total y los datos de las frutas
        AgregarFruta(Fruta) agregará una nueva fruta a la lista, si hay espacio.
        QuitarFruta: quitará una fruta al azar.Utilizar Random.*/

        public int CalcularEspacioDisponible()
        {
            return 0;
        }

        public string MostrarContenido()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("Volumen ocupado: " + this.volumen);
            strBuilder.Append("  Capacidad del cajon: " + this.volumen);
            foreach (Fruta fruta in this.kjon)
            {
                strBuilder.Append("/n Fruta-->" + "Peso: " + fruta.peso + " Volumen: " + fruta.volumen);
            }
            return strBuilder.ToString();
        }

        public void AgregarFruta(Fruta fruit)
        {
            this.kjon.Add(fruit);
        }

        public void QuitarFruta()
        {
            Random random = new Random();
            this.kjon.RemoveAt(random.Next(0, (this.kjon.Count()) ));
        }
    }
}
