using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Alumno
    {
        public string nombre;
        public int legajo;

        public Alumno(int legajo, string nombre)
        {
            this.nombre = nombre;
            this.legajo = legajo;
        }

        
        public static bool operator ==(Alumno alumno1, Alumno alumno2)
        {
            return (alumno1.legajo == alumno2.legajo);
        }

        public static bool operator !=(Alumno alumno1, Alumno alumno2)
        {
            return !(alumno1.legajo == alumno2.legajo);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override bool Equals(object o)
        {
           return true;
        }
    }
}
