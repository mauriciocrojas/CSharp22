using System;
using Entidades;

namespace TestPorConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.Add("1,2"));
            Console.WriteLine(calculadora.AddConSaltoYVacio(@"1 \ n2,3"));

            //Probamos la excepción
            try
            {

            calculadora.AddNegativo("-50");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
