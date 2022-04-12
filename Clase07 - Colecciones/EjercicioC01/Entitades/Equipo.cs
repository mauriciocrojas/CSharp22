//Ejercicio C01 - Estadística deportiva
//Consigna
//Crear un proyecto de biblioteca de clases que contenga las clases Jugador y Equipo:

//Diagrama de clase Estadística Deportiva

//Clase Jugador
//Todos los datos estadísticos del jugador se inicializarán en 0 dentro del constructor privado.
//El promedio de gol sólo se calculará cuando invoquen al método GetPromedioGoles.
//MostrarDatos retornará una cadena de string con todos los datos y estadísticas del jugador.
//Dos jugadores serán iguales si tienen el mismo DNI.
//Clase Equipo
//La lista de jugadores se inicializará sólo en el constructor privado de Equipo.
//La sobrecarga del operador + agregará jugadores a la lista siempre y cuando no exista aún en el 
//equipo y la cantidad de jugadores no supere el límite establecido por el atributo cantidadDeJugadores.
//Crear un proyecto de consola y generar las invocaciones necesarias en el método Main para probar el código.


using System.Collections.Generic;

namespace Entitades
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if (e != null && j != null)
            {
                if (e.jugadores.Count < e.cantidadDeJugadores)
                {
                    foreach (Jugador jug in e.jugadores)
                    {
                        if (jug == j)
                        {
                            return false;
                        }
                    }
                    e.jugadores.Add(j);
                    return true;
                }
            }
            return false;
        }


        public static bool operator -(Equipo e, Jugador j)
        {
            if (e != null && j != null)
            {
                e.jugadores.Remove(j);
                return true;
            }


            return false;
        }
    }
}
