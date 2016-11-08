using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Articulo
    {
        private int _codigo;
        private string _nombre;
        private float _precioCosto;
        private float _precioVenta;
        private int _stock;

        public Articulo(int codigo, string nombre, float precioCosto, int cantidad)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this.PrecioCosto = precioCosto;
            this._stock = cantidad;
        }

        public string NombreYCodigo
        {
            get {
                return string.Concat(this._nombre +" "+ this._codigo);
            }
        }

        public float PrecioCosto
        {
            set
            {
                this._precioCosto = value;
                this._precioVenta = (value * (float)1.3);
            }
        }

        public float PrecioVenta    
        {
            get {
                return this._precioVenta;
            }
        }

        public int Stock
        {
            set
            {
                this._stock = value;
            }
        }

        public bool HayStock(int cantidad)
        {
            if (this._stock >= cantidad)
                return true;

            return false;
        }

        public static bool operator ==(Articulo articuloUno, Articulo articuloDos)
        {
            if (articuloUno._nombre == articuloDos._nombre && articuloUno._codigo == articuloDos._codigo)
                return true;

            return false;
        }

        public static bool operator !=(Articulo articuloUno, Articulo articuloDos)
        { 
            return !(articuloUno==articuloDos);
        }

        public static int operator +(Articulo articuloUno, Articulo articuloDos)
        {
            return articuloUno._stock + articuloDos._stock;
        }

        public static int operator -(Articulo articuloUno, int cantidad)
        {
            return articuloUno._stock - cantidad;
        }







    }
}
