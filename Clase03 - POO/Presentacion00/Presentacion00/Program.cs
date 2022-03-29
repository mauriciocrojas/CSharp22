using System;
using Veterinaria;

namespace Presentacion00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancio los objetos
            Gato garfield = new Gato("Garfield", new DateTime(2018, 03, 28));
            Gato garfield2 = new Gato("Garfield", new DateTime(2018, 03, 28));
            Gato garfield3 = garfield;
            Gato felix = new Gato(null, new DateTime(1, 1, 1));

            // Invoco métodos de instancia
            garfield.AsignarPeso(5);
            garfield2.AsignarPeso(5);
            felix.AsignarPeso(3);

            //double pesoGarfield = garfield.ObtenerPeso();
            //double pesoFelix = felix.ObtenerPeso();


            //Console.WriteLine($"El peso de Garfield es: {pesoGarfield}");
            //Console.WriteLine($"El peso de Felix es: {pesoFelix}");

            //Metodo estatico (de clase), no se necesita instanciar un objeto para invocarlo (CW)
            Console.WriteLine($"{garfield.ObtenerDatos()}");
            Console.WriteLine($"{felix.ObtenerDatos()}");

            //Llama a ToString que viene del tipo padre Object
            Console.WriteLine("Objeto: {0} ", garfield);

            Console.WriteLine("\nGarfield es un objeto, Garfield2 otro, " +
                "\nGarfield3 una copia del primero (Gato garfield3 = garfield)\n");

            //Operador == Por defecto compara si apuntan a la misma
            //direccion de memoria (son la misma instancia)
            //Da false porque no son el mismo objeto en memoria
            Console.WriteLine("¿Son iguales garfield == garfield2? {0}", garfield == garfield2);

            //Da true (ambas guardan la misma referencia)
            Console.WriteLine("¿Son iguales garfield == garfield3? {0}", garfield == garfield3);

            //Equals es un método de instancia que sirve para comparar un objeto con otro, da false
            //Por defecto, compara si son la misma instancia en memoria.
            Console.WriteLine("¿Son iguales garfield.Equals(garfield2)? {0}", garfield.Equals(garfield2));

            Console.WriteLine("¿Son iguales garfield.Equals(garfield3)? {0}", garfield.Equals(garfield3));

            //Metodo estático para comparar si dos objetos son la misma instancia en memoria
            Console.WriteLine("¿Son iguales ReferenceEquals(garfield, garfield2)? {0}", ReferenceEquals(garfield, garfield2));

            Console.WriteLine("¿Son iguales ReferenceEquals(garfield, garfield3)? {0}", ReferenceEquals(garfield, garfield3));

            //Console.Clear();

            //GetHashCode es un método de instancia que devuelve un código  
            //único para identificar a una instancia en memoria
            Console.WriteLine("\nInstancias en memoria de los siguiente objetos: ");
            Console.WriteLine($"{nameof(garfield)}: {garfield.GetHashCode()}");
            Console.WriteLine($"{nameof(garfield2)}: {garfield2.GetHashCode()}");
            Console.WriteLine($"{nameof(garfield3)}: {garfield3.GetHashCode()}");

        }
    }
}
