using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecyoFinal
{
    class SolictarDatos
    {
        Validaciones Validaciones = new Validaciones();


        public static string SolicitarNombre(string texto)
        {
            while (true)
            {
                Console.Write("Ingrese su nombre: ");
                texto = Console.ReadLine();
                if (!Validaciones.ValidarString(texto))
                    Console.WriteLine("EL dato tiene cosas invalidas");
                else
                    return texto;
            }
        }
        public static string SolicitarApellido(string texto)
        {
            while (true)
            {
                Console.Write("Ingrese su apellido: ");
                texto = Console.ReadLine();
                if (!Validaciones.ValidarString(texto))
                    Console.WriteLine("EL dato tiene cosas invalidas");

                else
                    return texto;

            }
        }
        public static string SolicitarCedula(string texto)
        {
            while (true)
            {
                Console.Write("Ingrese su cedula: ");
                texto = Console.ReadLine();
                if (!Validaciones.ValidarNumeros(texto))
                    Console.WriteLine("EL dato tiene cosas invalidas");
                else
                    return texto;
            }

        }
        public static string SolicitarCorreo(string texto)
        {
            while (true)
            {
                Console.Write("Ingrese su correo: ");
                texto = Console.ReadLine();
                if (!Validaciones.ValidarCorreo(texto))
                    Console.WriteLine("EL dato tiene cosas invalidas");
                else
                    return texto;
            }

        }
    }
}
