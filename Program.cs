using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.inicializar();
            Printer.WriteTitle("Bienvenidos a la escuela");
            ImpimirCursosEscuela(engine.Escuela);

            Printer.DrawLine(20);
            Printer.DrawLine(20);
            Printer.DrawLine(20);
            Printer.WriteTitle("Pruebas de polimorfismo");

            var alumnoTest = new Alumno{Nombre = "Gato Gary"};

            ObjetoEscuelaBase ob = alumnoTest;
            
            Printer.WriteTitle("Alumno");
            WriteLine($"Alumno:{alumnoTest.Nombre}");
            WriteLine($"Alumno:{alumnoTest.UniqueId}");
            Printer.WriteTitle("ObjetoEscuela");
            WriteLine($"Alumno:{ob.Nombre}");
            WriteLine($"Alumno:{ob.UniqueId}");

            var evaluacion = new Evaluacion(){Nombre="Evaluacion de math", Nota=4.5f};

            ob = evaluacion;
            Printer.WriteTitle("Evaluacion");
            WriteLine($"Alumno: {ob.Nombre}");
            WriteLine($"Alumno: {ob.UniqueId}");
            WriteLine($"Alumno: {ob.GetType()}");

        }

        private static void ImpimirCursosEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Cursos de la Escuela");

            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre  }, Id  {curso.UniqueId}");
                }
            }
        }

    }
}
