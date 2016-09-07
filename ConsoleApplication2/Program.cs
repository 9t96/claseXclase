using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioOnce
{
    class Program
    {
        static void Main()
        {
            int number;
            int contador=0;

            for (; contador<10;contador++)
            {
                Console.WriteLine("Ingrese un numero: ");
                number = int.Parse(Console.ReadLine());
                if (Validacion.Validar(-100, 100, number))
                {
                    Validacion.MaxandMin(number);
                }
                else
                    contador--;

            }

            Validacion.MostrarMaxAndMin();

            Console.ReadKey();       
        }
    }


}




