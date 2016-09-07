using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novo_projecto
{
    public class Producto
    {
        private int _cantidad;

        private Producto(int cantidad)
        {
            this._cantidad = cantidad;
        }

        public static explicit operator Producto(int cantidad)
        { 
            return new Producto(cantidad);
        }
        
        public static int operator +(Producto prod1, Producto prod2)
        {
             return  prod1._cantidad + prod2._cantidad;           
        }
    
    }
}
