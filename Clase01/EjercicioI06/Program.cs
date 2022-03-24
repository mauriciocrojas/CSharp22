//Ejercicio I06 - Años bisiestos

//Escribir un programa que determine si un año es bisiesto.
//Un año es bisiesto si es múltiplo de 4. Los años múltiplos 
//de 100 no son bisiestos, salvo si ellos también son múltiplos 
//de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
//Pedirle al usuario un año de inicio y otro de fin y mostrar 
//todos los años bisiestos en ese rango.
//Utilizar sentencias de iteración, selectivas y el operador módulo (%).


using System;

namespace EjercicioI06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Ingrese año minimo: ");
            int.TryParse(Console.ReadLine(), out num1);

            Console.WriteLine("Ingrese año maximo: ");
            int.TryParse(Console.ReadLine(), out num2);

            Console.WriteLine($"Rango entre: {num1} y {num2}");
            Console.WriteLine($"Los años bisietos entre el rango seleccionado son: ");

            for(int i = num1; i < num2; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || (i % 4 == 0 && (i % 100 == 0 && i % 400 == 0)))
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
