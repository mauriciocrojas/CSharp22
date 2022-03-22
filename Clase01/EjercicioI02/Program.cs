//Ejercicio I02 - Error al cubo

//Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
//Se debe validar que el número sea mayor que cero, caso contrario, 
//mostrar el mensaje: "ERROR. ¡Reingresar número!".

using System;

namespace EjercicioI02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            double cuadrado = 0;
            double cubo = 0;

            Console.WriteLine("Ingrese un número: ");
            int.TryParse(Console.ReadLine(), out num);

            while (num <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!: ");
                int.TryParse(Console.ReadLine(), out num);
            }

            cuadrado = Math.Pow(num, 2);
            cubo = Math.Pow(num, 3);

            Console.WriteLine($"El cuadrado del número ingresado es: {cuadrado}, y su cubo es: {cubo}");

        }
    }
}
