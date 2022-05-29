using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseGenerics
{
    public class Inventario <T,U,V> 
    {
        List<T> lista;
        U objetoPrincipal;
        V[] arrayDeAlgo;

        public string Mostrar()
        {
            return objetoPrincipal.ToString();
        }
    }
}
