using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioDos
{
    class Program
    {
        static void Main()
        {
            int rnd;
            int contador=0;
            int contUno = 0;
            int contDos = 0;
            int contTres = 0;
            int contCuatro = 0;
            int contCinco = 0;
            int contSeis = 0;
            int contSiete = 0;
            int contOcho = 0;
            int contNueve = 0;
            int contDiez = 0;
            int total = 10000;
            Random rand = new Random();
           
            for ( ;contador<total;contador++)
            {         
                
                rnd = rand.Next(1,11);
                
                switch(rnd)
                { 
                    case 1:
                        contUno++;
                        break;
                    case 2:
                        contDos++;
                        break;
                    case 3:
                        contTres++;
                        break;
                    case 4:
                        contCuatro++;
                        break;
                    case 5:
                        contCinco++;
                        break;
                    case 6:
                        contSeis++;
                        break;
                    case 7:
                        contSiete++;
                        break;
                    case 8:
                        contOcho++;
                        break;
                    case 9:
                        contNueve++;
                        break;
                    case 10:
                        contDiez++;
                        break;
                }
            }
            
            Console.WriteLine("1:" + ((contUno*100)/total)+ "%");
            Console.WriteLine("2:" + ((contDos*100)/total)+ "%");
            Console.WriteLine("3:" + ((contTres*100)/total)+ "%");
            Console.WriteLine("4:" + ((contCuatro*100)/total)+ "%");
            Console.WriteLine("5:" + ((contCinco*100)/total)+ "%");
            Console.WriteLine("6:" + ((contSeis*100)/total)+ "%");
            Console.WriteLine("7:" + ((contSiete*100)/total)+ "%");
            Console.WriteLine("8:" + ((contOcho*100)/total)+ "%");
            Console.WriteLine("9:" + ((contNueve*100)/total)+ "%");
            Console.WriteLine("10:" + ((contDiez * 100) / total) + "%");
            Console.ReadKey();

        }

    }
}
