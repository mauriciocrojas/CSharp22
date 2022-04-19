using System.Text;

namespace Centralita
{
    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }

    public class Llamada
    {



        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;


        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion
        {
            get { return duracion; }
        }

        public string NroDestino
        {
            get { return nroDestino; }
        }

        public string NroOrigen
        {
            get { return nroOrigen; }
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duración: {duracion}");
            sb.AppendLine($"Nro Origen: {nroOrigen}");
            sb.AppendLine($"Nro Destino: {nroDestino}");

            return sb.ToString();
        }


        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {

            return (int)(llamada1.Duracion - llamada2.Duracion);
        }


    }
}
