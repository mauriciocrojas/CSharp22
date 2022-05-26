﻿//Crear una calculadora de string con un método int Add (string numeros) y 
//automatizar las pruebas unitarias para cada uno de los siguientes puntos.

//SUGERENCIAS
//Comience con el caso de prueba más simple de un string vacío y pase a uno y dos números
//Recuerde resolver las cosas de la forma más sencilla posible
//Recuerde refactorizar después de cada prueba aprobada.
//IMPORTANTE
//El objetivo es aprender a trabajar de forma incremental.

//Hacé una tarea a la vez y tratá de no seguir leyendo los siguientes puntos.

//Parte I
//El método Add debe poder tomar hasta dos números separados por comas, y devolverá su suma.

//Por ejemplo "" o "1" o "1,2" como entradas (para un string vacío devolverá 0).

//Parte II
//Permitir que el método Add maneje una cantidad desconocida de números.

//Parte III
//Permita que el método Add admita salto de línea entre números (en lugar de comas).

//La siguiente entrada está bien: "1 \ n2,3"(será igual a 6).
//La siguiente entrada NO está bien: "1, \ n"(no es necesario probarlo, solo se aclara)
//Parte IV
//Permitir que el método Add soporte diferentes delimitadores.

//Para cambiar un delimitador, el comienzo del string contendrá dos barras, debe verse así:

//// [delimitador] \ n [números ...]

//Por ejemplo: "//; \ n1; 2" debe devolver tres donde el valor predeterminado delimitador es ';'.

//Las barras son opcionales. Todos los escenarios existentes aún deben ser compatibles.

//Parte V
//Si Add recibe un número negativo arrojará una excepción NegativoNoPermitidoException que en su 
//mensaje contendrá el negativo que se recibió.

using System;

namespace Entidades
{
    public class Calculadora
    {

        public int Add(string numeros)
        {
            int resultado = 0;

            if (String.IsNullOrEmpty(numeros))
            {
                return 0;
            }

            foreach (char caracter in numeros)
            {
                if (caracter != ',')
                {
                    resultado += int.Parse(caracter.ToString());
                }
            }

            return resultado;
        }

        public int AddConSaltoYVacio(string numeros)
        {
            int resultado = 0;
            int auxNum;

            if (String.IsNullOrEmpty(numeros))
            {
                return 0;
            }

            foreach (char caracter in numeros)
            {
                if (int.TryParse(caracter.ToString(), out auxNum))
                {
                    resultado += auxNum;
                }
            }

            return resultado;
        }

        public int AddNegativo(string numeros)
        {
            int resultado = 0;
            int auxNum;

            if (String.IsNullOrEmpty(numeros))
            {
                return 0;
            }

            foreach (char caracter in numeros)
            {
                int cont = 0;
                if (caracter == '-' && cont == 0)
                {
                    throw new NegativoNoPermitidoException($"Se ingresó un numero negativo: {numeros}");
                }
                cont++;
            }

            return resultado;
        }
    }
}
