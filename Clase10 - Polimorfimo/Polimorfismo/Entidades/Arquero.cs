using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{


    public class Arquero : Personaje
    {

        private ETipoArco tipoArco;

        public Arquero(string nombre, int hp, int nivel)
            : base(nombre, hp, nivel)
        {
        }

        public Arquero(string nombre, ETipoArco tipo) : base(nombre, 100, 1)
        {
        }

        public override void Ataque_01()
        {
            Disparar();
        }

        public void Disparar()
        {
        }

        public void InfoPersonaje()
        {
            
        }


    }
}
