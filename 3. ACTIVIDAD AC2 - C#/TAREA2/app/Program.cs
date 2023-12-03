

// TAREA 2: Codifica un programa que pida números al usuario y finalice la ejecución con el número 0.
// Cuando acabe, deberá mostrar por consola cuantos fueron pares y cuantos impares.



using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaro las variables
            int numero=1; 
            int pares=0; 
            int impares=0;

            // Bucle para pedir números al usuario hasta que introduzca el 0
            while (numero != 0)
            {
                // Solicito números
                Console.WriteLine("Introduzca un número:");
                numero = Convert.ToInt32(Console.ReadLine());

                // Compruebo si el número es par o impar
                if (numero % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }

            // Muestro el resultado
            Console.WriteLine("Números pares: {0}", pares);
            Console.WriteLine("Números impares: {0}", impares);

            
        }
    }
}


