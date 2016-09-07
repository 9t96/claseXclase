using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Aula
    {
        public int numero;
        public Alumno[] listaAlumnos;
        public int indice;

        public Aula()
        { 
            this.listaAlumnos = new Alumno[10];           
        }

        public static void mostrarAlumno(Aula aulita)
        {
            foreach (Alumno misAlumnos in aulita.listaAlumnos)
            {
                if((object)misAlumnos!=null)
                Console.WriteLine("Nombre: {0}",misAlumnos.nombre);
            }
        }
        /// <summary>
        /// Devuelve el indice del primer elemeno "null" de lo contratio retorna -1.
        /// </summary>
        /// <returns></returns>
        public int obtenerIndice()
        {
            int i;
            
            for (i = 0; i < this.listaAlumnos.Length; i++)
            {
                if((object)this.listaAlumnos[i]==null)
                break;
            }
            
            if (i < this.listaAlumnos.Length)
                return i;

            return -1;
        }
        /// <summary>
        /// Retorna el indice donde se encuentra el alumno pasa por referencia, de lo contrario retorna -1.
        /// </summary>
        /// <param name="niño"></param>
        /// <returns></returns>
        public int obtenerIndice(Alumno niño)
        {
            if (!(this.existeAlumno(niño)))
            {
                int i;
                for (i = 0; i < this.listaAlumnos.Length; i++)
                {
                    if (this.listaAlumnos[i] == niño)                   
                    break;
                }
                return i;
            }
            return -1;
        }
        
        public void AgregarAlumno(Alumno chico)
        {
            if(!(this.existeAlumno(chico)))
            {
                int i = this.obtenerIndice(); //Busca la primera posicion nula de la lista y agrega el alumno.
                if (i != -1)
                {
                this.listaAlumnos[i] = chico;
                }
            }
            else
                Console.Write("No hay espacio o ya existe");

        }

        public void BorrarAlumno(Alumno chico)
        {
            for (int i = 0; i < this.listaAlumnos.Length;i++)
            {
                if (((object)this.listaAlumnos[i] != null) && (this.listaAlumnos[i] == chico))
                {
                    this.listaAlumnos[i] = null;
                }
            }
        }

        //Retorna true si el alumno pasado esta en el "aula"(lista/array).
        public bool existeAlumno(Alumno alumno)
        {
            for (int i = 0; i < this.listaAlumnos.Length; i++)
            {
                if ( (object)this.listaAlumnos[i] != null && (object)this.listaAlumnos[i] == alumno)      //Se fija que la posicion del subindice no sea nula y que el alumno este en el "aula"(lista/array).        
                    return true;
            }

            return false;
        }

        //Verifica que el alumno pasado por referencia este en el "aula"(lista/array).
        public static bool operator ==(Aula aula, Alumno alumno)
        {
            if (aula.obtenerIndice(alumno) != -1)
                return true;
            return false;
        }

        //Agrega el alumno pasado por referencia al "aula"(lista/array).
        public static Aula operator +(Aula aula, Alumno alumno)
        {
            aula.AgregarAlumno(alumno);
            return aula;
        }

        //Quita el alumno pasado por referencia del "aula"(lista/array).
        public static Aula operator -(Aula aula, Alumno alumno)
        {
            aula.BorrarAlumno(alumno);
            return aula;
        }
        
        //Se fija si el alumno1 esta en el "Aula".
        public static bool operator !=(Aula aula, Alumno alumno1)
        {
            if (!(aula.obtenerIndice(alumno1) != -1))
                return true;
            return false;
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
