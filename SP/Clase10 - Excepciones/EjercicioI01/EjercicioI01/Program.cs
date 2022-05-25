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
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MiClase miClase = new MiClase(5);
                //Console.WriteLine(MiClase.Lanzar());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException.Message);
                //throw new Exception(ex.Message, ex);
            }
        }
    }
}
