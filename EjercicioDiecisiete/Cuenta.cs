using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDiecisiete
{
    public class Cuenta
    {
        private string _nombre;
        private long _nroCuenta;
        private double _saldo;
        private ETipoInteres _tipoInteres;

        public string getNombre()
        {
            string nombre;

            Console.WriteLine("Por favor ingrese nombre: ");
            nombre = Console.ReadLine();

            return nombre;
        }

        public long getNroCuenta()
        {
            long nroCuenta;

            Console.WriteLine("Por favor ingrese numero de cuenta: ");
            nroCuenta = long.Parse(Console.ReadLine());

            return nroCuenta;
        }

        public double getSaldo()
        {
            double saldo;

            Console.WriteLine("Por favor ingrese saldo: ");
            saldo = double.Parse(Console.ReadLine());

            return saldo;

        }

        public ETipoInteres getTipoInteres()
        {
            int tipoInteres;
            ETipoInteres interes;
            Console.WriteLine("Por favor ingrese tipo de interes: \n 1.TIN\n2.TAE\n3.TIR");
            tipoInteres = int.Parse(Console.ReadLine());
            interes = (ETipoInteres)tipoInteres;

            return interes;
        }

        public void setNombre(string nombre)
        {
            this._nombre = nombre;
        }

        public void setNroCuenta(long nroCuenta)
        {
            this._nroCuenta = nroCuenta;
        }

        public void setSaldo(double saldo)
        {
            this._saldo = saldo;
        }

        public void setTipoInteres(ETipoInteres tipoInteres)
        {
            this._tipoInteres = tipoInteres;
        }

    }
}
