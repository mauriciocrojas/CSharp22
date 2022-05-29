using System.Collections.Generic;

namespace ClaseGenerics
{
    public class Gondola<T>
    {
        int idGondola;
        int cantidadEstantes;
        string sector;
        List<T> listaElementos;

        private Gondola()
        {
            listaElementos = new List<T>();
        }

        public Gondola(int idGondola, int cantidadEstantes, string sector) : this()
        {
            this.idGondola = idGondola;
            this.cantidadEstantes = cantidadEstantes;
            this.sector = sector;
        }

        public int ListaElentos
        {
            get { return listaElementos.Count; }
        }

        public T PrimerElemento()
        {
            return listaElementos[0];
        }

        public bool GuardarObjeto(T objetoAGuardar)
        {
            return true;
        }
    }
}
