//Ejercicio I01 - Máximo, mínimo y promedio

//Ingresar 5 números por consola, guardándolos en una variable escalar.
//Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.


using System;

namespace EjercicioI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            int acum = 0;
            int prom = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un número: ");

                if (int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    acum += numeroIngresado;

                    if (numeroIngresado < min)
                    {
                        min = numeroIngresado;
                    }
                    if (numeroIngresado > max)
                    {
                        max = numeroIngresado;
                    }
                }
            }
            prom = acum / 5;

            Console.WriteLine($"El numero más alto ingresado es: {max}");
            Console.WriteLine($"El numero más bajo ingresado es: {min}");
            Console.WriteLine($"El acumulado de los números ingresados es: {acum}");
            Console.WriteLine($"El promedio de la suma de lo ingresado es: {prom}");


        }
    }
}

