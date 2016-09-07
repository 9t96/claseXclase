using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDieciseis
{
    class Program
    {
        static void Main()
        {
            Alumno a1 = new Alumno();
            Alumno a2 = new Alumno();
            Alumno a3 = new Alumno();

            a1.nombre = "Juan Martin";
            a1.apellido = "Del Potro";
            a1.legajo = 0001;

            a2.nombre = "Roger";
            a2.apellido = "Federer";
            a2.legajo = 0002;

            a3.nombre = "Andy";
            a3.apellido = "Murray";
            a3.legajo = 0003;

            a1.Estudiar(4,7);
            a2.Estudiar(7,9);
            a3.Estudiar(3,2);

            a1.CalcularFinal();
            a2.CalcularFinal();
            a3.CalcularFinal();

            a1.Mostrar();
            a2.Mostrar();
            a3.Mostrar();

            Console.ReadKey(); 
        }
    }
}
