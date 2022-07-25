using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Homework Solution
            Console.WriteLine("--------");
            Console.WriteLine("Por favor, coloca 1 para Validar Suma o 2 para Salir");

            Console.WriteLine("--------");
            Console.WriteLine("1. Validar Suma");
            Console.WriteLine("2. Salir");

            Console.WriteLine("--------");
            Console.WriteLine("Introduce tu Respuesta: ");
            int respuesta = Convert.ToInt32(Console.ReadLine());

            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("Introduce un número: ");
                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Introduce otro número: ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Introduce otro número: ");
                    int c = Convert.ToInt32(Console.ReadLine());

                    if (a + b == c || a + c == b || b + c == a)
                    {
                        Console.WriteLine("SON IGUALES");
                    }
                    else
                    {
                        Console.WriteLine("SON DISTINTOS");
                    }
                    break;
                case 2:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Elige una opción válida.");
                    break;
            }
        }
    }
}