using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dragon : Personaje
    {

        float alturaVuelo;

        public Dragon(string nombre, int hp, int nivel,float altura) : base(nombre, hp, nivel)
        {
            this.alturaVuelo = altura;
        }

        public override void Ataque_01()
        {
           
        }

        public override string DevolverMensaje()
        {
            return "Soy un dragoncito";
        }

        public string DevolverMensaje(string mensaje)
        {
            return "Soy un dragoncito";
        }


    }
}
