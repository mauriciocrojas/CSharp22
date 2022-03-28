//Realizar una clase llamada Validador que posea un método 
//estático llamado Validar con la siguiente firma:

//bool Validar(int valor, int min, int max)

//valor: dato a validar.
//min: mínimo valor incluido.
//max: máximo valor incluido.

//Pedir al usuario que ingrese 10 números enteros. 
//Validar con el método desarrollado anteriormente 
//que estén dentro del rango -100 y 100.

//Terminado el ingreso mostrar el valor mínimo ingresado, 
//valor máximo ingresado y el promedio.

using System;

namespace EjercicioI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int acum = 0;


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                int num = int.Parse(Console.ReadLine());

                bool validar = Validator.Validar(num, -100, 100);

                if (validar)
                {
                    acum += num;

                    if (num > max)
                    {
                        max = num;
                    }
                    if (num < min)
                    {
                        min = num;
                    }
                }

            }
            Console.WriteLine($"La cantidad acumulada es de: {acum}\n"+
                $"El promedio ingresado es: {acum/10}\n"+
                $"El valor mínimo ingresado es: {min}\n" +
                $"El valor máximo ingresado es: {max}");
        }
    }


    public class Validator
    {
        public static bool Validar(int valor, int min, int max)
        {

            if (valor >= min && valor <= max)
            {
                return true;
            }

            return false;
        }
    }
}
