using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novo_projecto
{
    public class Peso
    {
        public double _cantidad;

        private Peso(double cantidad)
        {
            this._cantidad = cantidad;
        }

        public static explicit operator Peso(double cantidad)
        {
            return new Peso(cantidad);
        }

        public static Peso operator +(Peso peso, Dolar dolar)
        {
            peso._cantidad = peso._cantidad + (dolar._cantidad * 15);
            return peso;
        }
    
    }
}
