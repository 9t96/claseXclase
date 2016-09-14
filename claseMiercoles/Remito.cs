using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseMiercoles
{
    public class Remito:Documento
    {
        public string fecha;

        public Remito(int number)
            : base(number)
        { }

        public Remito(int number, string fecha, int numerodControl)
            : base(number,fecha, numerodControl)
        { }

    }
}
