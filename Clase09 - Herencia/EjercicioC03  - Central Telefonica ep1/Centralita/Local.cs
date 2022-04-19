using System.Text;

namespace Centralita
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo)
           : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public float CostoLlamada
        {
            get { return costo; }
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"Costo llamada Local: {costo}");

            return sb.ToString();
        }
    }
}   
