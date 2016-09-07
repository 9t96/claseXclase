using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDieciseis
{
    public class Alumno
    {
        private byte _nota2;
        private byte _nota1;
        private float _notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;

        public void CalcularFinal()
        {
            Random rndNumber = new Random();
            if (this._nota1 >= 4 && this._nota2 >= 4)
                this._notaFinal = rndNumber.Next(4, 11);
            else
                this._notaFinal = -1;
               
        }

        public void Estudiar(byte nota1,byte nota2)
        {
            this._nota1 = nota1;
            this._nota2 = nota2;
        }

        public void Mostrar()
        {
            if (this._notaFinal != -1)
                Console.WriteLine("Nombre:{0} {1} Nota 1: {2}\t Nota 2: {3} Nota Final: {4}",nombre,apellido,_nota1,_nota2,_notaFinal);
            else
                Console.WriteLine("Nombre:{0} {1} Nota 1: {2}\t Nota 2: {3}",nombre,apellido,_nota1,_nota2);
        }

    }
}
