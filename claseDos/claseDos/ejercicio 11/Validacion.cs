using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_11
{
    class Validacion
    {
        public static bool Validar(int maximo, int minimo, int numero) 
        {
            bool logro = false;

            if (numero > minimo && numero < maximo)
            {
                logro = true;
            }

            return logro;
        }

       


    }
}
