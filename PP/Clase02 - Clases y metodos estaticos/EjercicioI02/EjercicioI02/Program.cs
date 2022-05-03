//¿Desea continuar?

//Realizar un programa que sume números enteros hasta que el usuario
//lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

//Crear la clase Validador y el método estático ValidarRespuesta,
//que validará el ingreso de respuestas.

//El método devolverá un valor de tipo booleano, TRUE si se ingresó 
//una 'S' y FALSE si se ingresó cualquier otro valor.

using System;

namespace EjercicioI02
{
    internal class Program
    {
  
        static void Main(string[] args)
        {
            int num;
            int acum = 0;
            bool respuesta = true;
            char consulta;

            while (respuesta)
            {
                Console.WriteLine("Ingrese un numero: ");
                if(int.TryParse(Console.ReadLine(), out num))
                {
                    acum += num;

                    Console.WriteLine("¿Desea continuar? (S/N)");

                    if (char.TryParse(Console.ReadLine(), out consulta))
                    {
                        respuesta = Validador.ValidarRespuesta(consulta);

                    }
                    else
                    {
                        respuesta=true;
                    }
                }
                else
                {
                    Console.WriteLine("Error, reingrese numero: ");
                }
            }
            Console.WriteLine($"La suma de los numeros ingresados es: {acum}");
        }
    }


}
