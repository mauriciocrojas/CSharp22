using System;

namespace BibliotecaDeClases
{
    public class Empleado : ICompensacion
    {
        decimal dni;
        string nombreCompleto;
        bool dolarizado;
        string posicion;
        int remuneracionPretendida;

        private Empleado() {
            remuneracionPretendida = GeneradorDeDatos.Rnd.Next(100000, 300000);
        }

        public Empleado(decimal dni, string nombreCompleto, string posicion, bool dolarizado) : this()
        {
            this.dni = dni;
            this.nombreCompleto = nombreCompleto;
            this.dolarizado = dolarizado;
            this.posicion = posicion;
        }

        public decimal Dni { get => dni; set => dni = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }

        public float CalcularHonorarios { 
            get
            {
             if (dolarizado)
                {
                    return remuneracionPretendida / 300;
                }
                else
                {
                    return remuneracionPretendida;
                }
            }
        }
        public string Posicion { get => posicion;}


    }
}
