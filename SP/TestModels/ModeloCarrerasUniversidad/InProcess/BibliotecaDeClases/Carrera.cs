using System;

namespace BibliotecaDeClases
{
    public class Carrera : ICalificacion
    {
        string nombre; // no modificar linea

        static Random rnd;

        // no modificar metodo
        public Carrera(string nombre)
        {
            this.nombre = nombre;

            rnd = new Random();

        }

        public string Nombre { get => nombre; } // no modificar linea


        //completar

        public static Random Rnd { get => rnd; }

        public override string ToString()
        {
            return this.nombre + " - " + "Puntaje del curso: ";
        }

        public decimal CalificacionFinal
        {
            get => rnd.Next(1, 10);
        }


    }
}
