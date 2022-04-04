//Ejercicio I02 - ¿Vos cuántas primaveras tenés?

//Crear una aplicación de consola y una biblioteca de 
//clases que contenga la clase Persona.

//Deberá tener los atributos:

//nombre
//fechaDeNacimiento
//dni
//Deberá tener un constructor que inicialice todos los atributos.

//Construir los siguientes métodos para la clase:

//Setter y getter para cada uno de los atributos.
//CalcularEdad será privado y retornará la edad de la persona 
//calculándola a partir de la fecha de nacimiento.
//Mostrar retornará una cadena de texto con todos los datos de 
//la persona, incluyendo la edad actual.
//EsMayorDeEdad si es mayor de edad devuelve el valor: 
//“Es mayor de edad", sino devuelve “es menor”.
//Instanciar 3 objetos de tipo Persona en el método Main.
//Mostrar quiénes son mayores de edad y quiénes no.

using Entidades;
using System;

namespace EjercicioI02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona persona1 = new Persona("Carlos", new DateTime(1990, 3, 22), 12333999);
            Persona persona2 = new Persona("Susana", new DateTime(2010, 6, 11), 31213213);
            Persona persona3 = new Persona("Berta", new DateTime(1925, 9, 23), 45646445);



            Console.WriteLine(persona1.EsMayorDeEdad(persona1));
            Console.WriteLine(persona1.Mostrar());

            Console.WriteLine(persona2.EsMayorDeEdad(persona2));
            Console.WriteLine(persona2.Mostrar());

            Console.WriteLine(persona3.EsMayorDeEdad(persona3));
            Console.WriteLine(persona3.Mostrar());

            Console.ReadKey();


            //Persona[] personas = new Persona[] { persona1, persona2, persona3 };

            //foreach (Persona persona in personas)
            //{
            //    Console.WriteLine(persona.EsMayorDeEdad(persona));
            //}
        }
    }
}
