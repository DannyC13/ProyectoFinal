using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProyecyoFinal
{
    class Validaciones
    {
        public static bool ValidarString(string texto)
        {
            string patron = @"^[a-zA-Z]+$";

            Regex regex = new Regex(patron);

            if (regex.IsMatch(texto))
                return true;
            else
                return false;

        }
        public static bool ValidarApellidos(string texto)
        {
            string patron = @"^[a-zA-Z]";

            Regex regex = new Regex(patron);

            if (regex.IsMatch(texto))
                return true;
            else
                return false;
        }
        public static bool ValidarNumeros(string texto)
        {
            string patron = @"^\d{9}$";

            Regex regex = new Regex(patron);

            if (regex.IsMatch(texto))
                return true;
            else
                return false;
        }
        public static bool ValidarCorreo(string texto)
        {
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,}$";

            Regex regex = new Regex(patron);

            if (regex.IsMatch(texto))
                return true;
            else
                return false;
        }
    }
}
