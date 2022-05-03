using System;
using System.Collections.Generic;

namespace PROPIEDADES
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Personaje pj01 = new Personaje(1, "El magote", 100, true);
            Personaje pj02 = new Personaje(2, "PALADINZOTE", 500, false);

            Batalla superCombateFinal = new Batalla();

            Batalla batallita = new Batalla();
            Personaje ggnomo  = superCombateFinal[0];
            superCombateFinal[0] = pj01; // set

            Personaje personajePos1 = superCombateFinal[1]; // get

            superCombateFinal.AgregarPersonaje(pj02);
            superCombateFinal.AgregarPersonaje(pj01);

            // propiedad indexada 

            Personaje personajePos2 = superCombateFinal["El magote"];
            Personaje magote = superCombateFinal[0];

            Personaje personajePos3 = batallita["El magote"];



        }
    }
}
