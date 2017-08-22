using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseDos
{
    class Program
    {
        static void Main(string[] args)
        {
            //metodo de instancia
            persona unaPersona = new persona();
            unaPersona.SlaudarDos();
            
            //metodos de clase
            persona.Saludar();
            Console.ReadLine();
            
        }
    }
}
