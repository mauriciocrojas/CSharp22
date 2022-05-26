//Consigna
//En un proyecto de consola, crear un método de extensión para la clase string que 
//cuente la cantidad de signos de puntuación punto (.), coma(,) y punto y coma (;) dentro de una cadena.

//Pedir el ingreso de un texto por consola y mostrar la cantidad de signos de puntuación que contiene.

using System;

namespace Entidades
{
    public static class Contador
    {

        public static int ContarSimbolosPuntuacion(this string texto)
        {
            int cont = 0;
            foreach (char caracter in texto)
            {
                if (caracter == ',' || caracter == '.' || caracter == ';')
                {
                    cont++;
                }
            }
            return cont;
        }

        public static int ContarCaracterEspecifico(this string texto, char caracter)
        {
            int cont = 0;
            foreach (char item in texto)
            {
                if (item == caracter)
                {
                    cont++;
                }
            }

            return cont;
        }
    }
}
