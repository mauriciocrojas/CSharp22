using System;
using System.Collections.Generic;

namespace BibliotecaDeClases
{
    public class Empresa
    {
        List<Puesto> posicionesAbiertas;
        int cantPuestosACubrir;

        public event Action<bool> BusquedasRealizadas;

        public Empresa(int puestosACubrir)
        {
            this.cantPuestosACubrir = puestosACubrir;
            posicionesAbiertas = new List<Puesto>();
        }

        public List<Puesto> Posiciones
        {
            get => posicionesAbiertas;
        }


        public List<Puesto> AbrirBusqueda()
        {

            if (posicionesAbiertas.Count <= cantPuestosACubrir)
            {
                posicionesAbiertas.Add(GeneradorDeDatos.GetUnPuesto);

            }
            else
            {
                BusquedasRealizadas.Invoke(true);
            }


            return posicionesAbiertas;
        }

    }
}
