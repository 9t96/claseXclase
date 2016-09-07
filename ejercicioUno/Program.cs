using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioUno
{
    class Program
    {
        static void Main()
        {
            int edad;
            int promedio;
            int acumulador = 0;
            int contador;

            
            Console.Title = "ClaudioManzanares";
            Console.Write("Hola mundo");
            Console.ReadKey();

            for(contador=0 ;contador<5; contador++)
            {
                Console.WriteLine("Ingrese edad:");
                edad = int.Parse(Console.ReadLine());
                acumulador = acumulador + edad;
            }

            promedio = acumulador/contador;
            Console.WriteLine("El total es {0} y el promedio {1}",acumulador,promedio);
            Console.ReadKey();
        }
    }
}
