//Ejercicio I08 - Dibujando un triángulo rectángulo

//Escribir un programa que imprima por consola un 
//triángulo como el siguiente:

//*
//***
//*****
//*******
//*********

//El usuario indicará cuál será la altura del triángulo 
//ingresando un número entero positivo. 
//Para el ejemplo anterior, la altura ingresada fue de 5.

//Utilizar sentencias de iteración y selectivas.



using System;

namespace EjercicioI08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numIngresado;
            string simbolo = "*";

            Console.WriteLine("Ingrese un numero: ");
            int.TryParse(Console.ReadLine(), out numIngresado);

            for (int i = 0; i <= numIngresado; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(simbolo);
                }
                Console.Write("\n");
            }
        }
    }
}
