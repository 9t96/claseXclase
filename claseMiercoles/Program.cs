using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseMiercoles
{
    class Program
    {
        static void Main()
        {
            Remito miRemito = new Remito(666);
            Factura miFactura = new Factura(99);          
            FacturaA miFacturaA = new FacturaA(20,miFactura);
            FacturaAPagada miFacturaAPagada = new FacturaAPagada("20/20/20",miFacturaA);
            
            List<Documento> miDocumento = new List<Documento>();

            miDocumento.Add(miFactura);
            miDocumento.Add(miRemito);
            miDocumento.Add(miFacturaA);
            miDocumento.Add(miFacturaAPagada);
            
            foreach (Documento item in miDocumento)
            {
                item.Mostrar();
            }

            Console.ReadKey();
        }
    }
}
