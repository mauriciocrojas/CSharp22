using System;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {

        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(ConsoleColor colorTinta, float tinta)
        {
            this.Color = colorTinta;
            this.UnidadesDeEscritura = tinta;
        }

        public ConsoleColor Color
        {
            get => this.colorTinta;
            set => this.colorTinta = value;
        }

        public float UnidadesDeEscritura
        {
            get => this.tinta;
            set => this.tinta = value;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            //for (int i = 0; i < texto.Length; i++)
            //{
            //    this.UnidadesDeEscritura -= 0.3F;
            //}

            this.UnidadesDeEscritura -= texto.Length * 0.3f;

            return new EscrituraWrapper(Color, texto);
        }

        public bool Recargar(int unidades)
        {

            this.UnidadesDeEscritura += unidades;
            return true;

        }

        public override string ToString()
        {
            string cadena = $"Bolígrafo color {Color}, nivel de tinta {UnidadesDeEscritura}";
            return cadena;
        }
    }
}
