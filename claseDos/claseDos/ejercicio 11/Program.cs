using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int minimo = 0;
            int maximo = 0;
            float promedio = 0;
            int acumulador = 0;
            int contadorNumeros = 0;

            while(contadorNumeros < 10)
            {
                Console.WriteLine("Ingrese un numero entre -100 y 100: ");
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Error, reingrese!");
                }
                while (! Validacion.Validar(100, -100, numero))
                {
                    Console.WriteLine("Error, ingrese un numero entre -100 y 100: ");
                    while (!int.TryParse(Console.ReadLine(), out numero))
                    {
                        Console.WriteLine("Error, reingrese!");
                    }
                }

                if (contadorNumeros == 0)
                {
                    minimo = numero;
                    maximo = numero;
                }
                else
                {
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                }
                contadorNumeros++;
                acumulador += numero;
            }

            promedio = acumulador / contadorNumeros;

            Console.WriteLine("Valor máximo: " + maximo);
            Console.WriteLine("Valor mínimo: " + minimo);
            Console.WriteLine("Promedio: " + promedio);
            Console.ReadLine();

        }
    }
}
