using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecyoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SolictarDatos.SolicitarNombre(""));
            Console.WriteLine(SolictarDatos.SolicitarApellido(""));
            Console.WriteLine(SolictarDatos.SolicitarCedula(""));
            Console.WriteLine(SolictarDatos.SolicitarCorreo(""));
        }

    }
}
