using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_EuroDolar
{
    public class Dolar
    {
        public double _cantidad;

        private Dolar(double cantidad)
        {
            this._cantidad = cantidad;
        }
      
        public static explicit operator double(Dolar dolar)
        {
            return dolar._cantidad;
        }

        public static implicit operator Dolar(double dolar)
        {
            return new Dolar(dolar);
        }

        public static Dolar operator +(Dolar dolar1, double dolar2)
        {
            dolar1._cantidad = dolar1._cantidad + dolar2;
            return dolar1;
        }

        public static Dolar operator +(Dolar dolar1, Dolar dolar2)
        {
            dolar1._cantidad = dolar1._cantidad + dolar2._cantidad;
            return dolar1;
        }

        public static Dolar operator -(Dolar dolar1, double dolar2)
        {
            dolar1._cantidad = dolar1._cantidad - dolar2;
            return dolar1;
        }
        
        public static Dolar operator -(Dolar dolar1, Dolar dolar2)
        {
            dolar1._cantidad = dolar1._cantidad - dolar2._cantidad;
            return dolar1;
        }

        public static bool operator >(Dolar dolar1, Dolar dolar2)
        {
            return (dolar1 > dolar2);
        }

        public static bool operator <(Dolar dolar1, Dolar dolar2)
        {
            return (dolar1 < dolar2);
        }

        public static bool operator ==(Dolar dolar1, double dolar2)
        {
            return (dolar1._cantidad == dolar2);
        }

        public static bool operator ==(Dolar dolar1, Dolar dolar2)
        {
            return (dolar1 == dolar2);
        }

        public static bool operator !=(Dolar dolar1, Dolar dolar2)
        {
            return !(dolar1 == dolar2);
        }

        public static bool operator !=(Dolar dolar1, double dolar2)
        {
            return !(dolar1 == dolar2);
        }

    }
}
