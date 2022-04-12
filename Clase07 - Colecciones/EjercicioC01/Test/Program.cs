using Entitades;
using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(4, "Equipo A");
            Jugador jugador0 = new Jugador(32748921, "Messi", 13, 5);
            Jugador jugador1 = new Jugador(24114124, "Ronaldo", 9, 5);
            Jugador jugador2 = new Jugador(43536443, "Pele", 22, 13);
            Jugador jugador3 = new Jugador(76745646, "Palermo", 5, 2);
            Jugador jugador4 = new Jugador(36454252, "Maradona", 5, 10);
            Jugador jugador5 = new Jugador(32748921, "Messi", 13, 5);

            Console.WriteLine("Jugador0:\n" + jugador0.MostrarDatos());
            Console.WriteLine("Jugador1:\n" + jugador1.MostrarDatos());
            Console.WriteLine("Jugador5:\n" + jugador5.MostrarDatos());

            Console.WriteLine($"Jugador0 == Jugador1: {jugador0 == jugador1}");
            Console.WriteLine($"Jugador1 == Jugador5: {jugador0 == jugador5}");

            if (equipo + jugador0)
            {
                Console.WriteLine("Se agregó jugador0");
            }
            else
            {
                Console.WriteLine("El jugador0 ya existe o no hay más lugar");
            }
            if (equipo + jugador1)
            {
                Console.WriteLine("Se agregó jugador1");
            }
            else
            {
                Console.WriteLine("El jugador1 ya existe o no hay más lugar");
            }
            if (equipo + jugador5)
            {
                Console.WriteLine("Se agregó jugador5");
            }
            else
            {
                Console.WriteLine("El jugador5 ya existe o no hay más lugar");
            }
            if (equipo + jugador2)
            {
                Console.WriteLine("Se agregó jugador2");
            }
            else
            {
                Console.WriteLine("El jugador2 ya existe o no hay más lugar");
            }
            if (equipo + jugador3)
            {
                Console.WriteLine("Se agregó jugador3");
            }
            else
            {
                Console.WriteLine("El jugador3 ya existe o no hay más lugar");
            }
            if (equipo + jugador4)
            {
                Console.WriteLine("Se agregó jugador4");
            }
            else
            {
                Console.WriteLine("El jugador4 ya existe o no hay más lugar");
            }
        }
    }
}
