using System.Collections.Generic;

namespace ClaseGenerics
{
    public class Inventario<U>
        where U : MedioDeTransporte
    {
        List<U> listaMedioTransporte;

        public void SumarCantidadDeCombustible()
        {
            foreach (U item in listaMedioTransporte)
            {
                item.nombre = "";
                item.MostrarNumeroChasis();
            }
        }
    }
}
