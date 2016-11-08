using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        private Articulo _articuloVendido;
        private int _cantidad;

        public Venta(Articulo articuloVendido, int Cantidad)
        {
            this._articuloVendido = articuloVendido;
            this._cantidad = Cantidad;
        }

        public float RetornarGanancia()
        {
            return (this._articuloVendido.PrecioVenta * this._cantidad);
        }





    }
}
