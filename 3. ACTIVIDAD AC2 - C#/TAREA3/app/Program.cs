

// TAREA 3: Codifica un programa “Calculadora”, con las 4 operacions básicas, sumar restar,
// multiplicar y dividir siguiendo estos pasos:
// Pide al usuario que introduzca dos números
// Pregunta la operación con los siguiente códigos numéricos (1- suma, 2-resta,
// 3-multiplicación, 4-división)
// Pregunta si finaliza o añade más números


using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaro las variables
            int numero1, numero2, operacion;

            // Solicito al usuario que introduzca dos números
            Console.WriteLine("Introduce el primer número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            // Presento opciones al usuario para que seleccione e introduzca solo una
            Console.WriteLine("¿Qué operación quieres realizar?");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            operacion = Convert.ToInt32(Console.ReadLine());

            // Procesamos los datos con un swuitch 
            switch (operacion)
            {
                case 1:
                    Console.WriteLine("El resultado de la suma es " + (numero1 + numero2));
                    break;
                case 2:
                    Console.WriteLine("El resultado de la resta es " + (numero1 - numero2));
                    break;
                case 3:
                    Console.WriteLine("El resultado de la multiplicación es " + (numero1 * numero2));
                    break;
                case 4:
                    Console.WriteLine("El resultado de la división es " + (numero1 / numero2));
                    break;
                default:
                    Console.WriteLine("Operación no válida");
                    break;
            }

            // Preguntar al usuario si desea hacer otra operación o terminar
            Console.WriteLine("¿Quieres realizar otra operación? (s/n)");
            string respuesta = Console.ReadLine();
            
            if (respuesta == "s")
            {
                // Llamo al método Main() para que autoinicie el programa
                Main(args);
            }
        }
    }
}


