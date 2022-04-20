using System;

namespace Entidades
{
    public abstract class Personaje
    {

        protected string nombre;
        protected int hp;
        protected int nivel;

        public Personaje(string nombre, int hp, int nivel)
        {
            this.nombre = nombre;
            this.hp = hp;
            this.nivel = nivel;
        }

        public string Nombre
        {
            get { return nombre; }
        }


        public bool Curarse()  // instancia 
        {
            hp = 100;

            return true;
        }

        public virtual string DevolverMensaje()
        {
            return "Saludos desde personaje...";
        }

        public abstract void Ataque_01();  // que cada uno lo codee

    }
}
