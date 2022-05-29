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


            Bebida bebida = new Bebida();
            Juguete juguete = new Juguete();


            //gondolaPalabras.PrimerElemento();
            //gondolaBebidas.PrimerElemento();
            //gondolaJuguetes.PrimerElemento();

            gondolaPalabras.GuardarObjeto("string");
            gondolaBebidas.GuardarObjeto(bebida);
            gondolaJuguetes.GuardarObjeto(juguete);


            ///

            Inventario<Juguete, Avion, string> inventario1 = new Inventario<Juguete, Avion, string>();
            inventario1.ToString(); 
        }
    }
}
