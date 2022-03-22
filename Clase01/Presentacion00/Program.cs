using System;

namespace Presentacion
{
    public class Program
    {
        static void Main(string[] args)
        {

            //string nombreCompleto;
            //nombreCompleto = "Juan Perez";
            //string mensaje = nombreCompleto + " Hello Word " + "!";

            int numero = 12;
            numero = CambiarValor(numero);
            Console.WriteLine(numero);


            //Tipo de referencia (clase)
            Persona persona = new Persona()
            {
                Nombre = "Mauricio"
            };
            CambiarValor(persona);

            Console.WriteLine(persona.Nombre);

            string nombre = "Mau";
            int edad = 25;

            Console.WriteLine("Hola {0}, tu edad es: {1}", nombre, edad);
        }

        static int CambiarValor(int numero)
        {
            return numero * 2;
        }

        static void CambiarValor(Persona persona)
        {
            persona.Nombre = "Nuevo nombre";
        }


        public class Persona
        {
            public string Nombre { get; set; }
        }
    }


}


//conversion explicita, hay perdida de información, interviene el programador
//int numero = (int)15.3;

//conversion implícita, no hay perdida de informacion
//float = 15;