using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main()
        {   
            //Creo que un aula que contiene un Array de Alumnos.
            Aula firstAula = new Aula();
            
            //Creo alumnos y los agrego a la lista.
            Alumno alumno1 = new Alumno(20,"pepe");
            Alumno alumno2 = new Alumno(30,"Mariano");
            Alumno alumno3 = new Alumno(76,"Rogelio");
            Alumno alumno4 = new Alumno(56, "coco");


            //Agrego alumnos a la lista con el operador mas sobrecargado.
            firstAula = firstAula + alumno1; 
            firstAula = firstAula + alumno2;
            firstAula = firstAula + alumno3;
            firstAula = firstAula + alumno4;

            //Muestro los Alumnos que agregue por el metodo statico mostrarAlumno.
            Aula.mostrarAlumno(firstAula);

            //Borro los 3 primeros alumnos.
            firstAula = firstAula - alumno1;
            firstAula = firstAula - alumno2;
            firstAula = firstAula - alumno3;
           
            //La salida por consola deberia ser coco.
            Aula.mostrarAlumno(firstAula);

            Console.ReadKey();
        }
    }
}
