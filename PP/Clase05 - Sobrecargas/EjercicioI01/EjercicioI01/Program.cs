using System;
using Entidades;

namespace EjercicioI01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Sumador sumador = new Sumador();
            Sumador sumador2 = new Sumador();

            long resultadoLong = sumador.Sumar(5, 9);
            Console.WriteLine($"Resultado sumador long: {resultadoLong}");
            //Console.WriteLine($"Contador sumas: {sumador.GetCantidadSumas()}\n");
            Console.WriteLine($"Contador sumas sumador: {(int)sumador}");

            string resultadoString = sumador2.Sumar("Daenerys", "Targaryen");
            Console.WriteLine($"Resultado sumador concatenador string: {resultadoString}");
            //Console.WriteLine($"Contador sumas: {sumador.GetCantidadSumas()}");
            Console.WriteLine($"Contador sumas sumador2: {(int)sumador2}");

            Console.WriteLine($"Suma de sumadores: {sumador + sumador2}");

            Console.WriteLine($"¿Son iguales las sumas?: {sumador | sumador2}");

            resultadoLong = sumador.Sumar(1, 9);
            Console.WriteLine($"Resultado suma sumador: {resultadoLong}");
            Console.WriteLine($"Contador sumas sumador: {(int)sumador}");
            Console.WriteLine($"¿Son iguales las sumas?: {sumador | sumador2}");


        }
    }
}
