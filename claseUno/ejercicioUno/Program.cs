using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioUno
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int maximo=0;
            int minimo=0;
            int contador;
            int acumulador=0;
            float promedio;
            int primerNumeroPar;
            bool encontrPrimerNumeroPar=false;
            int cantidadPares = 0;
            int lugarDelPrimerPar;
            int lugarDelUltimoImpar;

            /*
             while(contador<5)
             {
                contador++;
             }
            */
            for (contador = 0; contador < 5; contador++)
            {
                Console.WriteLine("Ingrese el numero");
                while(! int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Error, reingrese");
                }

                if (contador == 0)
                {
                    maximo = numero;
                    minimo = numero;
                }
                else
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }

                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                }

                if (numero % 2 == 0)
                {
                    cantidadPares++;
                    if (encontrPrimerNumeroPar == false)
                    {
                        lugarDelPrimerPar = contador;
                        encontrPrimerNumeroPar = true;
                        primerNumeroPar = numero;
                    }
                    
                }

                acumulador += numero;
            }

            promedio = acumulador / 7;
            
            //3,4,5,10,8,2,1
            

            Console.WriteLine("El numero mas grande es: " + maximo);
            Console.WriteLine("El numero mas chico es: " + minimo);
        }
    }
}
