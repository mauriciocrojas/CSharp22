using System.Text;

namespace Centralita
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            franjaHoraria = miFranja;
        }

        public float CostoLlamada
        {
            get { return CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    return base.Duracion * 0.99F;
                case Franja.Franja_2:
                    return base.Duracion * 1.25F;
                default:
                    return base.Duracion * 0.66F;
            }
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"Costo llamada Provincial: {CostoLlamada}");
            sb.AppendLine($"Franja horaria: {franjaHoraria}");

            return sb.ToString();
        }
    }
}
