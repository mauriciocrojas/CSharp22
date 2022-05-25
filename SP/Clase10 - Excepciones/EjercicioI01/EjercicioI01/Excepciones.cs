//Ejercicio I01 - Lanzar y atrapar
//Consigna
//Crear una aplicación de consola y agregar el código necesario para:

//Crear dos excepciones propias (nuevas clases que hereden de Exception)
//con los nombres UnaExcepcion y MiExcepcion.
//Crear una clase llamada MiClase y dentro colocar un método estático y
//dos constructores de instancia.
//Dentro del método estático lanzar una excepción DivideByZeroException (sólo lanzarla).
//Capturar la excepción del punto anterior en uno de los constructores de instancia y
//relanzarla hacia el otro constructor de instancia.
//En este segundo constructor se deberá instanciar otro objeto del tipo MiClase,
//capturando su excepción. Crear una excepción propia llamada UnaException 

//(utilizar la propiedad InnerException para almacenar la excepción original) y volver a lanzarla.
//Generar la clase OtraClase con un método de instancia, donde se instancie un objeto MiClase 
//y se capture la excepción anterior. Este método generará una excepción propia llamada MiException y la lanzará.
//MiException será capturada en el método Main, mostrando el mensaje de error que esta almacena por
//pantalla y los mensajes de todas las excepciones almacenadas en sus propiedades InnerException.


using System;

namespace EjercicioI01
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion(string mensaje) : this(mensaje, null)
        {

        }

        public UnaExcepcion(string mensaje, Exception ex)
            : base(mensaje, ex)
        {

        }
    }

    //Sin uso
    public class OtraExcepcion : Exception
    {
        public OtraExcepcion(string mensaje) : this(mensaje, null)
        {

        }

        public OtraExcepcion(string mensaje, Exception ex)
            : base(mensaje, ex)
        {

        }
    }
    //

    public class MiClase
    {
        public static int Lanzar()
        {
            int divisor = 5;
            int dividendo = 0;
            if (dividendo == 0)
            {
                throw new UnaExcepcion("Error al intentar dividir por 0");
            }
            int resultado = divisor / dividendo;
            return resultado;
        }

        public int numero;

        public MiClase()
        {
            try
            {
                this.numero = Lanzar();

            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                throw new Exception("Excepcion en el contructor MiClase", ex);
            }
        }
        public MiClase(int numero) : this()
        {

        }
    }

}
