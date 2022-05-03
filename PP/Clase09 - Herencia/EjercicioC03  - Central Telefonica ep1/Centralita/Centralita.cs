using System.Collections.Generic;
using System.Text;

namespace Centralita
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }


        public float GananciasPorLocal
        {
            get { return CalcularGanancia(TipoLlamada.Local); }
        }


        public float GananciasPorProvincial
        {
            get { return CalcularGanancia(TipoLlamada.Provincial); }
        }


        public float GananciasPorTodas
        {
            get { return CalcularGanancia(TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return listaDeLlamadas; }
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;

            foreach (var item in listaDeLlamadas)
            {
                if (item is Local variableLocal)
                {
                    gananciaLocal += variableLocal.CostoLlamada;
                }
                else if (item is Provincial variableProvincial)
                {
                    gananciaProvincial += variableProvincial.CostoLlamada;
                }
            }

            switch (tipo)
            {
                case TipoLlamada.Local:
                    return gananciaLocal;
                case TipoLlamada.Provincial:
                    return gananciaProvincial;
                default:
                    return gananciaLocal + gananciaProvincial;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon social: {razonSocial}");
            sb.AppendLine($"Ganancias Totales: {GananciasPorTodas}");
            sb.AppendLine($"Ganancias Locales: {GananciasPorLocal}");
            sb.AppendLine($"Ganancias Provinciales: {GananciasPorProvincial}");

            sb.AppendLine($"Lista de llamadas: ");
            foreach (var item in listaDeLlamadas)
            {
                if (item is Local llamadaLocal)
                {
                    sb.AppendLine(llamadaLocal.Mostrar());
                }
                else if (item is Provincial llamadaProvincial)
                {
                    sb.AppendLine(llamadaProvincial.Mostrar());
                }
            }

            return sb.ToString();
        }


        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

    }
}
