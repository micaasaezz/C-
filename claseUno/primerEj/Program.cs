using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerEj
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno;
            int numeroDos;
            int resultado;
            //string dato;

            //numeroUno = 3;
            //numeroDos = 7;
            Console.WriteLine("Ingrese el primer numero:");
            while(!int.TryParse(Console.ReadLine(), out numeroUno))
            {
                Console.WriteLine("Error, reingrese numero");
            }
            Console.WriteLine("Ingrese el segundo numero:");
            while(!int.TryParse(Console.ReadLine(), out numeroDos))
            {
                Console.WriteLine("Error, reingrese numero");
            }
            
            
            resultado = numeroUno + numeroDos;

            Console.Write("El resultado es "+ resultado); 
            Console.Read();
        }
    }
}
