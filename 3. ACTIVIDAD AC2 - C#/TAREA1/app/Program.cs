
// TAREA 1: Escribe un programa que introduciendo tres notas de un alumno por consola, calcule la
// media e indique si está suspendido o aprobado (nota media mayor o igual a 5)


using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaro variables
            int nota1, nota2, nota3;

            // Solicito notas al usuario
            Console.WriteLine("Introduzca la primera nota:");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca la segunda nota:");
            nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca la tercera nota:");
            nota3 = Convert.ToInt32(Console.ReadLine());

            // Calculamos la nota media
            int media = (nota1 + nota2 + nota3) / 3;

            // Respondemos si está aprobado o suspendido
            if (media >= 5)
            {
                Console.WriteLine("Aprobado con una media de "+ media);   // ó Console.WriteLine("Aprobado con una media de {0}", media);
            }
            else
            {
                Console.WriteLine("Suspendido con una media de "+ media);  // ó Console.WriteLine("Suspendido con una media de {0}", media);
            }

            

        }
    }
}
