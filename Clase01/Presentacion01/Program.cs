using System;

namespace Presentacion01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese nombre del producto: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese precio: ");
            string precioString = Console.ReadLine();

            //Formas válidas de parsear
            //decimal precio = decimal.Parse(precioString);
            //decimal precio = Convert.ToDecimal(precioString);

            if (decimal.TryParse(precioString, out decimal precio))
            {
                decimal precioConIva = precio + precio * 0.21M;

                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Producto: {0} \nPrecio: {1}$", nombre, precioString);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Escribiste cualquier cosa, me cierro.");
            }
        }
    }
}
