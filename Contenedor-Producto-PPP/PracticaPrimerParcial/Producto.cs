using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPrimerParcial
{
    public class Producto
    {
        private int _codigoDeBarra;
        private string _nombre;
        private double _precio;
        private eTipoComestible _tipo;

        private Producto(int codigoDeBarra)
        {
            this._codigoDeBarra = codigoDeBarra;
        }

        public Producto(int codigoBarras, string nombre, eTipoComestible tipo):this(codigoBarras)
        {
            this._tipo = tipo;
            this._nombre = nombre;
        }

        public Producto(int codigoBarras, string nombre, eTipoComestible tipo, double precio):this(codigoBarras,nombre,tipo)
        {
            this._precio = precio;
        }

        public static bool operator ==(Producto uno, Producto dos)
        { 
            return !(uno._codigoDeBarra!=dos._codigoDeBarra);
        }

        public static bool operator !=(Producto uno, Producto dos)
        {
            return !(uno._codigoDeBarra != dos._codigoDeBarra);
        }

        public static bool operator ==(Producto uno, eTipoComestible tipo)
        {
            return !(uno._tipo != tipo);
        }

        public static bool operator !=(Producto uno, eTipoComestible tipo)
        {
            return !(uno._tipo != tipo); 
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.Append(" Nombre: " + this._nombre);
            str.Append(" Precio: $" + this._precio);
            str.Append(" Tipo: " + this._tipo.ToString());
            str.Append(" CodigoBarras: " + this._codigoDeBarra);

            return str.ToString();
        }
    }
}
