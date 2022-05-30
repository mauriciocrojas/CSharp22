using System;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            ((IAcciones)this).UnidadesDeEscritura = unidades;
        }

        ConsoleColor IAcciones.Color
        {
            get => ConsoleColor.Gray;
            set => throw new NotImplementedException();
        }

        float IAcciones.UnidadesDeEscritura
        {
            get => this.tamanioMina;
            set => this.tamanioMina = value;
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            //for (int i = 0; i < texto.Length; i++)
            //{
            //    this.tamanioMina -= 0.1F;
            //}

            ((IAcciones)this).UnidadesDeEscritura -= texto.Length * 0.1f;

            return new EscrituraWrapper(((IAcciones)this).Color, texto);

        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            string cadena = $"Bolígrafo color {((IAcciones)this).Color}, nivel de tinta {((IAcciones)this).UnidadesDeEscritura}";
            return cadena;
        }
    }
}
