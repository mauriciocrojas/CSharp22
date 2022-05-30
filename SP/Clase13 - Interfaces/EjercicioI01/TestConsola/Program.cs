//Parte I:
//La clase Boligrafo implementará la interfaz de forma implícita y en Lapiz de forma explícita.

//En Lapiz:

//El método Escribir reducirá la mina en 0.1 por cada carácter escrito.
//El método Recargar lanzará NotImplementedException.
//El color será gris (grey), sin posibilidad de modificarlo. El set lanzará NotImplementedException.
//La propiedad UnidadesDeEscritura retornará el valor del atributo tamanioMina.
//En Boligrafo:

//El método Escribir reducirá la tinta en 0.3 por cada carácter escrito.
//El método Recargar incrementará la tinta en tantas unidades como se agreguen.
//La propiedad UnidadesDeEscritura retornará el valor del atributo tinta.
//En ambas clases el método ToString retornará un texto informando si es un lápiz o un bolígrafo, 
//el color de escritura y el nivel de tinta.

//Crear un proyecto de consola y agregar el siguiente código en el método Main, modificar si hace falta:

//Parte II
//Declarar la clase CartucheraMultiuso que tendrá un atributo del tipo List<IAcciones>.

//Crear el método RecorrerElementos.

//Se deberá recorrer la lista y gastará 1 unidades de cada elemento.
//Cuando sea necesario, recargará antes de salir del método (cargar 20 unidades).
//Retornará true si se pudo gastar exactamente 1 unidad de todos los elementos.
//Declarar la clase CartucheraSimple que tendrá dos atributos del tipo List<Boligrafo> y List<Lapiz> respectivamente.

//Crear el método RecorrerElementos para que haga exactamente lo mismo que el de CartucheraMultiuso. 
//Recorrer cada lista por su tipo.

//Crear dentro del método Main un objeto del tipo CartucheraMultiuso y otro de CartucheraSimple.

//Cargar sus listas de elementos.
//Llamar a los métodos RecorrerElementos hasta que alguno de ellos retorne false.
//Imprimir por pantalla su retorno.


using Entidades;
using System;


namespace TestConsola
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(ConsoleColor.Green, 20);

            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);

            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);

            Console.ReadKey();
        }
    }
}
