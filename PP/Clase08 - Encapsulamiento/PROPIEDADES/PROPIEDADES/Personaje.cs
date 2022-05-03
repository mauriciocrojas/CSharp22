using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROPIEDADES
{
    public class Personaje
    {
        int id;
        string nombre;
        int poder;
        bool esMagico;

        public Personaje(int id, string nombre, int poder, bool esMagico)
        {
            this.id = id;
            this.nombre = nombre;
            this.poder = poder;
            this.esMagico = esMagico;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public int Poder 
        { 
           set { poder = value; }
        }
    }
}
