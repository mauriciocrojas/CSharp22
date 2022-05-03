using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI02
{
    public class Validador
    {
        public static bool ValidarRespuesta(char respuesta)
        {
            if (respuesta == 's')
            {
                return true;
            }

            return false;
        }
    }
}
