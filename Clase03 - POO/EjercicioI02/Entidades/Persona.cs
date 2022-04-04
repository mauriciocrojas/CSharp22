//Ejercicio I02 - ¿Vos cuántas primaveras tenés?

//Crear una aplicación de consola y una biblioteca de 
//clases que contenga la clase Persona.

//Deberá tener los atributos:

//nombre
//fechaDeNacimiento
//dni
//Deberá tener un constructor que inicialice todos los atributos.

//Construir los siguientes métodos para la clase:

//Setter y getter para cada uno de los atributos.
//CalcularEdad será privado y retornará la edad de la persona 
//calculándola a partir de la fecha de nacimiento.
//Mostrar retornará una cadena de texto con todos los datos de 
//la persona, incluyendo la edad actual.
//EsMayorDeEdad si es mayor de edad devuelve el valor: 
//“Es mayor de edad", sino devuelve “es menor”.
//Instanciar 3 objetos de tipo Persona en el método Main.
//Mostrar quiénes son mayores de edad y quiénes no.

using System;
using System.Text;

namespace Entidades
{
    public class Persona
    {
       private string nombre;
       private DateTime fechaDeNacimiento;
       private int dni;

        public Persona (string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        private void SetNombre(string value)
        {
            nombre = value;
        }

        private string GetNombre()
        {
            return nombre;
        }

        private void SetFechaDeNacimiento(DateTime value)
        {

                fechaDeNacimiento = value;
            
        }

        private DateTime GetFechaDeNacimiento()
        {
            return fechaDeNacimiento;
        }

        private void SetDni(int value)
        {
            dni = value;
        }

        private int GetDni()
        {
            return dni;
        }

        private int CalcularEdad(DateTime fechaDeNacimiento)
        {
            DateTime fechaActual = DateTime.Now;

            int edad = fechaActual.Year - fechaDeNacimiento.Year;

            return edad;

        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}\n" +
                $"DNI: {dni}\n" +
                $"Fecha de nacimiento: {GetFechaDeNacimiento()}\n" +
                $"Edad: {CalcularEdad(fechaDeNacimiento)}" 
                );

            return sb.ToString();
        }

        public string EsMayorDeEdad (Persona persona)
        {

            DateTime edad = DateTime.Today;

            if (edad.Year - persona.fechaDeNacimiento.Year >= 18)
            {
                return "Es mayor de edad";
            }

            return "Es menor de edad";
        }
    }
}
