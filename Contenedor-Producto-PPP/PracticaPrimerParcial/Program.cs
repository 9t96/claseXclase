using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPrimerParcial
{
    class Program
    {
        static void Main()
        {
            Producto ProductoUno = new Producto(666,"JamonDelDiablo", eTipoComestible.Solido,2);
            Producto ProductoDos = new Producto(33, "JamonDeDios", eTipoComestible.Solido,10);
            Producto ProductoTres = new Producto(55, "Sprite", eTipoComestible.Liquido, 10);
            Producto ProductoCuatro = new Producto(666, "JamonDelDiablo", eTipoComestible.Solido);
            
            Container ContenerdorUno = new Container(2, "Skanka");
            Container ContenerdorDos = new Container(3, "Skanka");
            
            List<Producto> listaProducto = new List<Producto>();
            
            ContenerdorUno.Agregar(ProductoUno);
            ContenerdorUno.Agregar(ProductoDos);
            
            if(! ContenerdorUno.Agregar(ProductoTres)) {
            Console.WriteLine("No se pudo");
            }
           
            ContenerdorDos.Agregar(ProductoUno);
            ContenerdorDos.Agregar(ProductoDos);
            
            if (!ContenerdorDos.Agregar(ProductoCuatro)) {
            Console.WriteLine("No se pudo");
            }
            
            ContenerdorDos.Agregar(ProductoTres);

            Console.WriteLine(Container.Mostrar(ContenerdorUno));
            Console.WriteLine(Container.Mostrar(ContenerdorDos));
            
            listaProducto = ContenerdorDos - eTipoComestible.Liquido;
            
            Console.WriteLine(" Lista Extraida ");
            
            foreach (Producto item in listaProducto) {
                Console.WriteLine(item.Mostrar());
            }
            
            Console.ReadLine();
        }
    }
}
