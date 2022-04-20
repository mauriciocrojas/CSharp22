using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mago : Personaje
    {

        private int nivelMagia;


        public Mago(string nombre, int hp, int nivel)
            : base(nombre, hp, nivel)
        {
            nivelMagia = 200;
        }

        public override void Ataque_01()
        {
            nivelMagia -= 20;

        }


        public override string DevolverMensaje()
        {
            /// CASO 1 
            string mensaje = "Saludos desde mago...  ";

            return mensaje + base.DevolverMensaje();
        }


        public string InfoPersonaje()
        {
            return "";
        }



    }
}
