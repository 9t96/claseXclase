using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novo_projecto
{
    class Program
    {
        static void Main()
        {
            /*Producto prod1 = (Producto)33;

            int resultado;

            resultado = prod1 + prod1;

            Console.WriteLine(resultado);*/

            Dolar und;
            Peso unp;

            und = 1;
            unp = (Peso)1;

            und = und + unp;
            unp = unp + und;

            Console.WriteLine("und: {0:C}  unp:{1}", und._cantidad, unp._cantidad);
            Console.ReadKey();
        
        }
    }
}
