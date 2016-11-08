using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comercio
    {
        private string _dueño;
        private List<Articulo> _misArticulos;
        private List<Venta> _misVentas;

        public Comercio(string dueño)
        {
            this._dueño = dueño;
            this._misArticulos = new List<Articulo>();
            this._misVentas = new List<Venta>();
        }

        public void ComprarArticulo(Articulo articuloComprado)
        {
            int i = 0;
            for (; i < this._misArticulos.Count; i++)
            {
                if (articuloComprado == this._misArticulos[i])
                {
                    this._misArticulos[i].Stock = this._misArticulos[i] + articuloComprado;
                    break;
                }                    
            }

            if (i == this._misArticulos.Count)
                this._misArticulos.Add(articuloComprado);

        }

        public static void MostrarArticulos(Comercio ComercioAMostrar)
        {
            foreach (var item in ComercioAMostrar._misArticulos)
            {
                if(item.HayStock(1))
                Console.WriteLine(item.NombreYCodigo);
            }
        }

        public static void MostrarGanancia(Comercio ComercioParaResumen)
        {
            double total=0;

            foreach (var item in ComercioParaResumen._misVentas)
            {
                total += item.RetornarGanancia();
            }

            Console.WriteLine("GananciaTotal: " + total);
        }
        
        public void VenderArticulo(Articulo articuloSolicitado, int cantidad)//No muestra si el articulo existe o no el comercio.
        {
            Venta articuloVendido;
            Articulo aux=null;
            int flag = 0;

            foreach (var item in this._misArticulos)
            {
                if (articuloSolicitado == item)
                {
                    aux=item;
                    flag = 1;
                }
            }

            if (flag == 1)
            {
                if (articuloSolicitado.HayStock(cantidad))
                {
                    aux.Stock = aux - cantidad;
                    articuloVendido = new Venta(aux, cantidad);
                    this._misVentas.Add(articuloVendido);
                }
                else
                {
                    Console.WriteLine("No hay stock de este producto: " + articuloSolicitado.NombreYCodigo);
                }
            }
            else {
                Console.WriteLine("Este producto no se encuentra en el local: " + articuloSolicitado.NombreYCodigo);
            }

            
            /*       
            for (int i = 0; i < this._misArticulos.Count; i++)
            {
                if (articuloSolicitado == this._misArticulos[i])
                {
                    if (articuloSolicitado.HayStock(cantidad))
                    {
                        this._misArticulos[i].Stock = this._misArticulos[i] - cantidad;
                        articuloVendido = new Venta(this._misArticulos[i], cantidad);
                        this._misVentas.Add(articuloVendido);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("No hay stock de este producto: " + articuloSolicitado.NombreYCodigo);
                    }
                }
            }*/
        
        }
         

    }
}
