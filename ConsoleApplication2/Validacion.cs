using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioOnce
{
    public class Validacion
    {
        //LIGADAS AL OBJETO.
        static public int maximo;
        static public int minimo;
        static public int promedio;

        public static bool Validar(int lowLimit, int maxLimit, int number)
        {
            if ((number < lowLimit) || (number > maxLimit))
                return false;

            return true;
        }

        public static void MaxandMin(int number)
        {
            if ((maximo == 0) && (minimo == 0))
            {
                maximo = number;
                minimo = number;
            }
            else
            {
                if (number > maximo)
                  maximo = number;
                if (number < maximo)
                    minimo = number;
            }

            promedio += number;
        }

        public static void MostrarMaxAndMin()
        {
            Console.WriteLine("El numero maximo es: " + maximo);
            Console.WriteLine("El numero minimo es: " + minimo);
            Console.WriteLine("El promedio es: " + (promedio / 10));
        }

    }
}
