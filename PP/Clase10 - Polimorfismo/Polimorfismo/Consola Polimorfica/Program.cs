using System;
using System.Collections.Generic;
using Entidades;

namespace Consola_Polimorfica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Personaje> miLista = new List<Personaje>();

            Arquero unArquero = new Arquero("El Legolas", 50, 12);

            miLista.Add(new Mago("El Magote", 100, 1));

            miLista.Add(new Arquero("El Legolas", 50, 12));

            miLista.Add(new Dragon("DRAGONITE", 50, 12, 2000));

            #region MyRegion
            //foreach (Personaje item in miLista)
            //{
            //    Console.WriteLine(item.Nombre);

            //    if (item is Mago unMago)
            //    {
            //        Console.WriteLine(unMago.UsarMagia());
            //    }

            //    if (item.GetType() == typeof(Mago))
            //    {

            //    }

            //}

            #endregion

            foreach (Personaje item in miLista)
            {
                //  Console.WriteLine(item.DevolverMensaje()); 
                item.Ataque_01();

                ((Arquero)item).Disparar();

                // unArquero.Disparar();
            }



        }
    }
}
