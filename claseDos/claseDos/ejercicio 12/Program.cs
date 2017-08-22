using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int acumulador = 0;
            bool seguir;

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Error, reingrese!");
                }

                acumulador += numero;

                Console.WriteLine("Desea continuar? (s/n)");
                seguir = ValidarRespuesta.ValidaS_N();

            } while (seguir == true);

            Console.WriteLine("La suma total de numeros ingresados es: " + acumulador);
            Console.ReadLine();
        }
    }
}
