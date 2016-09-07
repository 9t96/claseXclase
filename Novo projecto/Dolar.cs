using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novo_projecto
{
    public class Dolar
    {
        public double _cantidad;

        public Dolar(int cantidad)
        {
            this._cantidad = cantidad;
        }

        public static implicit operator Dolar(int cantidad)
        {
            return new Dolar(cantidad);
        }

        public static Dolar operator +(Dolar dolar, Peso peso)
        {
            dolar._cantidad = dolar._cantidad + (peso._cantidad / 15);
            
            return dolar;
        }
            
    }
}
