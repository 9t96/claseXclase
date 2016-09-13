using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class Auto
    {
        private string _nombrePiloto;
        private Efabricante _fabricante;
        private Kilometros _kmRecorridos;
        private Tiempo _tiempoDemorado; 
        public Rueda rdDI;
        public Rueda rdDD;
        public Rueda rdTI;
        public Rueda rdTD;
        public static int ContadorDeobjetos;
        private static  Random _rnd;

        public Efabricante fabricante {

            get {
                return this._fabricante;
            }
        
        }

        public string datosEnString
        {
            get           
            {
                return this.MostarAuto();
            }
        }

        public int obtenerKilometros
        {
            get
            {
                return (int)this._kmRecorridos;
            }
        }
        public int obtenerTiempo
        {
            get
            {
                return (int)this._tiempoDemorado;
            }
        }
                     
        static Auto() //incializacion de atributos.
        {
            Auto.ContadorDeobjetos = 0;
            _rnd = new Random();
        }
        
        public Auto()
        {                                 
            this._fabricante = (Efabricante)_rnd.Next(0,3);
            this.rdDD = new Rueda();
            this.rdDI = new Rueda();
            this.rdTI = new Rueda();
            this.rdTD = new Rueda();
            this._kmRecorridos = 0;
            this._tiempoDemorado = 0;
            Auto.ContadorDeobjetos++;
        }

        public Auto(string nombre, Efabricante fabricante):this()
        {
            this._nombrePiloto = nombre;
            this._fabricante = fabricante;
        }
        
        public static bool comprarAuto(Auto car1, Auto car2)
        {
            if (car1._fabricante == car2._fabricante)
                return true;
            
            return false;
        }

        private string MostarAuto()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine("F: " + this._fabricante + "Name: " + this._nombrePiloto);
            //Console.WriteLine("Fabricante: {0}\t Kilometraje: {1}KM\t Tiempo: {2}",this._fabricante,(int)this._kmRecorridos,(int)this._tiempoDemorado);
            return str.ToString();
        }

        public void VolverAcero()
        {
            this._kmRecorridos = 0;
            this._tiempoDemorado = 0;
        }

        public void AgregarKilometros(int kilometros)
        {
            this._kmRecorridos = this._kmRecorridos +  kilometros;
        }

        public void AgregarTiempo(int time)
        {
            this._tiempoDemorado = this._tiempoDemorado + time;
        }

        public void Agregar(int km,Tiempo tiempo)
        {
            this.AgregarTiempo((int)tiempo);
            this.AgregarKilometros(km);
        }

        public void Agregar(Kilometros km,int tiempo)
        {
            this.AgregarTiempo(tiempo);
            this.AgregarKilometros((int)km);
        }
        
        //DEPRECATED x Propiedad.
        /*public int obtenerKilometros()
        {
            return (int)this._kmRecorridos;
        }

        public int obtenerTiempo()
        {
            return (int)this._tiempoDemorado;
        }*/

    }
}
