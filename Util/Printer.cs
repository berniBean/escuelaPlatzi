using static System.Console;

namespace CoreEscuela.Util
{

    public static class Printer
    {
        public static void DibujarLinea(int tam)
        {
            WriteLine( "".PadLeft(tam,'='));
        }

        public static void WriteTitle(string titulo)
        {
            var size = titulo.Length+4;
            DibujarLinea(size);
            WriteLine($"| {titulo} |");
            DibujarLinea(size);
        }
    }
}