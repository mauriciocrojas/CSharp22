//Consigna
//En un proyecto de consola, crear un método de extensión para la clase string que 
//cuente la cantidad de signos de puntuación punto (.), coma(,) y punto y coma (;) dentro de una cadena.

//Pedir el ingreso de un texto por consola y mostrar la cantidad de signos de puntuación que contiene.

using Entidades;
using System;

namespace TestConsola
{
    public class Program
    {
        static void Main(string[] args)
        {
            string texto = "hola, Juan Carlos; cómo estás.?";
            Console.WriteLine("La cantidad de simbolos de puntuación en el texto: " + texto + " es: " + texto.ContarSimbolosPuntuacion());


            string texto2 = "hola, buenos dias a todos";
            Console.WriteLine(texto2.ContarCaracterEspecifico('a'));

        }
    }
}
