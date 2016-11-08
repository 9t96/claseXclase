using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPrimerParcial
{
    public class Container
    {
        private int _capacidad;
        private string _empresa;
        private List<Producto> _listaProductos;

        private Container()
        {
            this._listaProductos = new List<Producto>();
        }

        public Container(int capacidad,string Empresa):this()
        {
            this._capacidad = capacidad;
            this._empresa = Empresa;
        }

        public static string Mostrar(Container contenedor)
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("------------CONTAINER-----------");
            str.AppendLine(" Empresa: " + contenedor._empresa);
            str.AppendLine(" Capacidad: "+contenedor._capacidad);
            
            foreach (var item in contenedor._listaProductos)
            {
                str.AppendLine(item.Mostrar());
            }

            return str.ToString();
        }

        public static bool operator ==(Container contenedor,Producto uno)
        {
            return contenedor._listaProductos.Contains(uno);
        }

        public static bool operator !=(Container contenedor, Producto uno)
        {
            return contenedor._listaProductos.Contains(uno);
        }

        public static List<Producto> operator -(Container contenedor, eTipoComestible tipo)
        {
            List<Producto> subList = new List<Producto>();   
            
            foreach (var item in contenedor._listaProductos)
            {
                if (item == tipo)
                {
                    subList.Add(item);
                }
            }

            return subList;
        }

        public bool Agregar(Producto uno)
        {
            int flag= 0;

            if (this._listaProductos.Count == this._capacidad)
                return false;
            
            foreach (var item in this._listaProductos)
            {
                if(uno == item)
                {
                    flag++;
                }
            }

            if (flag != 0)
                return false;
            else
                this._listaProductos.Add(uno);

            return true;
        }
        

    }
}
