//EjercicioI01 - Sumador

//Crear dos constructores:

//Sumador(int) inicializa cantidadSumas en el valor recibido por parámetro.
//Sumador() inicializa cantidadSumas en cero. Reutilizará al primer constructor.
//El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la siguiente lógica:

//En el caso de Sumar(long, long) sumará los valores numéricos
//En el de Sumar(string, string) concatenará las cadenas de texto.
//Crear un proyecto de consola y agregar un objeto del tipo Sumador en el método Main y probar el código.

//Seguido:

//Generar una conversión explícita que retorne cantidadSumas.

//Sobrecargar el operador + (suma) con dos operadores de tipo Sumador. El resultado será 
//un long correspondiente al resultado de la suma del atributo cantidadSumas de cada argumento.

//Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador. Deberá retornar 
//true si ambos sumadores tienen igual valor en el atributo cantidadSumas.

//Agregar un segundo objeto del tipo Sumador en el método Main y probar el código.

namespace Entidades
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0)
        {
        }


        public long Sumar(long a, long b)
        {
            cantidadSumas++;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            cantidadSumas++;
            return a + " " + b;
        }

        //public int GetCantidadSumas()
        //{
        //    return cantidadSumas;
        //}


        //public static bool operator == (Persona p1, Persona p2)
        //{
        //    if (p1 is not null && p2 is not null)
        //    {
        //        return p1.nombre == p2.nombre;
        //    }

        //    return false;

        //}

        //public static bool operator != (Persona p1, Persona p2)
        //{

        //    if (p1 is not null && p2 is not null)
        //    {
        //        return p1.nombre != p2.nombre;
        //    }

        //    return false;
        //}


        //Generar una conversión explícita que retorne cantidadSumas.
        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        //Sobrecargar el operador + (suma) con dos operadores de tipo Sumador. El resultado será 
        //un long correspondiente al resultado de la suma del atributo cantidadSumas de cada argumento.
        public static long operator + (Sumador a, Sumador b)
        {
            return a.cantidadSumas + b.cantidadSumas;
        }

        //Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador. Deberá retornar 
        //true si ambos sumadores tienen igual valor en el atributo cantidadSumas.
        public static bool operator |(Sumador a, Sumador b)
        {
            return a.cantidadSumas == b.cantidadSumas;
        }

        //Agregar un segundo objeto del tipo Sumador en el método Main y probar el código.



    }
}
