using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseMiercoles
{
    public class Factura:Documento
    {
        public float importe;

        public Factura(int number)
            : base(number)//Llama al constructor de la clase base y le pasa el parametro.
        { }

        public Factura(int number, string fecha, int numerodControl)
            : base(number, fecha, numerodControl)
        { }
    }
}
