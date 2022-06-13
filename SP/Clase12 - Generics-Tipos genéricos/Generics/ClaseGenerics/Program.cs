using System;
using System.Collections.Generic;

namespace ClaseGenerics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Gondola<string> gondolaPalabras = new Gondola<string>(1, 10, "Palabras");
            Gondola<Bebida> gondolaBebidas = new Gondola<Bebida>(2, 20, "Bebidas");
            Gondola<Juguete> gondolaJuguetes = new Gondola<Juguete>(3, 30, "Juguetes");
            Gondola<Avion> gondolaAviones = new Gondola<Avion>(4, 50, "Avion");

            Bebida bebida = new Bebida();
            Juguete juguete = new Juguete();
            Avion avion = new Avion();

            //gondolaPalabras.PrimerElemento();
            //gondolaBebidas.PrimerElemento();
            //gondolaJuguetes.PrimerElemento();
            //gondolaAviones.PrimerElemento();

            gondolaPalabras.GuardarObjeto("string");
            gondolaBebidas.GuardarObjeto(bebida);
            gondolaJuguetes.GuardarObjeto(juguete);
            gondolaAviones.GuardarObjeto(avion);


            ///

            Inventario<Juguete, Moto> inventario1 = new Inventario<Juguete, Moto>();
            inventario1.ToString();
        }
    }
}