using static System.Console;

namespace CoreEscuela.Util
{

    public static class Printer
    {
        public static void DrawLine(int tam)
        {
            WriteLine( "".PadLeft(tam,'='));
        }

        public static void WriteTitle(string titulo)
        {
            var size = titulo.Length+4;
            DrawLine(size);
            WriteLine($"| {titulo} |");
            DrawLine(size);
        }
    }
}