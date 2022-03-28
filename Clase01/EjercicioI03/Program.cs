//Ejercicio I03 - Los primos

//Mostrar por pantalla todos los números primos que haya hasta 
//el número que ingrese el usuario por consola.
//Validar que el dato ingresado por el usuario sea un número.
//Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
//Si ingresa "salir", cerrar la consola.
//Al finalizar, preguntar al usuario si desea volver a operar. 
//Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
//Utilizar sentencias de iteración, selectivas y el operador módulo (%).


using System;

namespace EjercicioI03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numIngresado;
            int contPrimos = 0;
            string answer;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese un número: ");

                while (!(int.TryParse(Console.ReadLine(), out numIngresado)))
                {
                    Console.WriteLine("Error, reingrese el número o digite salir: ");
                    string palabra = Console.ReadLine();
                    if (int.TryParse(palabra, out numIngresado))
                    {
                        break;

                    }
                    else if (palabra == "salir")
                    {
                        Console.WriteLine("Usted a digitado salir, saludos ");
                        Environment.Exit(0);
                    }

                }

                if (numIngresado >= 2) Console.WriteLine("Los numeros primos hasta el numero ingresado son: ");

                for (int i = 1; i <= numIngresado; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            contPrimos++;
                        }
                    }
                    if (contPrimos == 2)
                    {
                        Console.WriteLine("{0} ", i);
                    }
                    contPrimos = 0;
                }

                Console.WriteLine("\n¿Desea hacer otra consulta? si/no");
                answer = Console.ReadLine();

            } while (answer == "si");
        }
    }
}
