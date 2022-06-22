using System;

namespace BibliotecaDeClases
{
    public class Carrera : ICalificacion
    {
        static Random rnd = new Random();

        string nombre; // no modificar linea

        // no modificar metodo
        public Carrera(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; } // no modificar linea

        public decimal CalificacionFinal { get => rnd.Next(1, 10); }

        //completar
        public override string ToString()
        {
            return this.nombre + " - " + $"Puntaje del curso: {CalificacionFinal}";
        }



    }
}
