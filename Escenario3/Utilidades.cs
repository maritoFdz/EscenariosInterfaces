using System.Text.RegularExpressions;

namespace Escenario3
{
    public static class Utilidades
    {
        public static bool ValidarCorreo(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo))
                return false;

            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patron);
        }

        public static bool PasswordCorrecta(string contra, int minLongitud)
        {
            if (string.IsNullOrWhiteSpace(contra))
                return false;

            return contra.Length >= minLongitud;
        }
    }
}
