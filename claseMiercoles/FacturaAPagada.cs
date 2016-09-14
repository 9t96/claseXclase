using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseMiercoles
{
    public class FacturaAPagada:FacturaA
    {
        public string fechaDePago;

        public FacturaAPagada(string fechadepago, FacturaA unaFactura)
            :base(21,unaFactura)
        {
            this.fechaDePago = fechadepago;
        }

    }
}
