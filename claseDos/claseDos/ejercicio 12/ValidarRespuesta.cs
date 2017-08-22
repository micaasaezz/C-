using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_12
{
    class ValidarRespuesta
    {
         public static bool ValidaS_N()
         {
             bool esSoN = false;
             char respuesta;

             while (! char.TryParse(Console.ReadLine(), out respuesta))
             {
                 Console.WriteLine("Error, reingrese!");
             }
             
                  
             while ( respuesta.CompareTo('s')  != 0 && respuesta.CompareTo('n') != 0)
             {
                 Console.WriteLine("Error, ingrese s/n!");
                 while(! char.TryParse(Console.ReadLine(), out respuesta))
                 {
                        Console.WriteLine("Error, reingrese!");          
                 }
             } 


             if(respuesta == 's')
             {
                 esSoN = true;
             }
             else if(respuesta == 'n')
             {
                 esSoN = false;
             }

             return esSoN;
         }
    }
}
