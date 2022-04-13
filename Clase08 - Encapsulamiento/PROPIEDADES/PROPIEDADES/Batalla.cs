using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROPIEDADES
{
    public class Batalla
    {

        List<Personaje> listaPersonajes;
      
        // propiedad indexada

        public Personaje this[int indice]
        {
            get
            {
                if (indice > -1 && indice < listaPersonajes.Count)
                    return listaPersonajes[indice];

                return null;
            }

            set
            {
                listaPersonajes[indice] = value;
            }
        }

        public Personaje this[string auxNombre]
        {
            get
            {

                foreach (Personaje item in listaPersonajes)
                {
                    if (item.Nombre == auxNombre)
                    {
                        return item;
                    }
                }
                return null;
            }
        }

        public List<Personaje> ListaPersonajes
        {
            get { return listaPersonajes; }
        }

        public Batalla()
        {
            listaPersonajes = new List<Personaje>();


            listaPersonajes.Add(new Personaje(5, "El gnomo", 100, true));
            listaPersonajes.Add(new Personaje(4, "la bruja", 100, true));
            listaPersonajes.Add(new Personaje(6, "la arquera", 100, true));
            listaPersonajes.Add(new Personaje(7, "el tanque", 100, true));
        }

        public void AgregarPersonaje(Personaje aux)
        {
            listaPersonajes.Add(aux);
        }

    }
}
