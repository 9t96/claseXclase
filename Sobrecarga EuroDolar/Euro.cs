using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_EuroDolar
{
    public class Euro
    {
        public double _cantidad;

        private Euro(double cantidad)
        {
            this._cantidad = cantidad;
        }

        public static implicit operator Euro(double euro)
        {
            return new Euro(euro);
        } 

        public static explicit operator double(Euro euro)
        {
            return euro._cantidad;
        }

        public static Euro operator +(Euro euro1, double euro2)
        {
            euro1._cantidad = euro1._cantidad + euro2;
            return euro1;
        }

        public static Euro operator +(Euro euro1, Euro euro2)
        {
            euro1._cantidad = euro1._cantidad + euro2._cantidad;
            return euro1;
        }

        public static Euro operator -(Euro euro1, double euro2)
        {
            euro1._cantidad = euro1._cantidad - euro2;
            return euro1;
        }

        public static Euro operator -(Euro euro1, Euro euro2)
        {
            euro1._cantidad = euro1._cantidad - euro2._cantidad;
            return euro1;
        }

        public static bool operator >(Euro euro1, Euro euro2)
        {
            return (euro1 > euro2);
        }

        public static bool operator <(Euro euro1, Euro euro2)
        {
            return (euro1 < euro2);
        }

        public static bool operator ==(Euro euro1, double euro2)
        {
            return (euro1._cantidad == euro2);
        }

        public static bool operator ==(Euro euro1, Euro euro2)
        {
            return (euro1==euro2);        
        }

        public static bool operator !=(Euro euro1, Euro euro2)
        {
            return !(euro1 == euro2);
        }

        public static bool operator !=(Euro euro1, double euro2)
        {
            return !(euro1 == euro2);
        }

    }
}
