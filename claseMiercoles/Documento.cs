using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseMiercoles
{
    public class Documento
    {
        public int numero;
        protected string fecha;
        private int numeroDeControl;
        
        public Documento(int number)
        {
            this.numero = number;
        }

        public Documento(int number, string fecha, int numberControl):this(number)
        {
            this.fecha = fecha;
            this.numeroDeControl = numberControl;
        }
        
        public void Mostrar()
        {
            Console.Write(this.numero);
        }
    }
}
