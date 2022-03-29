using System;
using System.Text;

namespace Veterinaria
{
    //Clase (sustantivo en singular)
    public class Gato
    {
        //Atributos
        private string nombre;
        private DateTime fechaNacimiento;
        private double peso;


        //Constructor
        public Gato(string nombre, DateTime fechaNacimiento)
        {
            SetNombre(nombre);
            //this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }

        //Método
        public void SetNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                nombre = "Sin nombre";
            }

            this.nombre = nombre.Trim();
        }


        //Método de instancia
        public void AsignarPeso(double peso)
        {
            //Con el this hago referencia a los atributos de instancia
            //que serían los atributos del objeto
            if (peso < 0)
            {
                peso = 0;
            }

            this.peso = peso;
        }

        public double ObtenerPeso()
        {
            return peso;
        }

        //Lo estatico no necesita una instancia, puedo llamarlo desde su clase
        //(DateTime.Now)

        //las propiedades de instancia solo se pueden acceder
        //desde la refererencia de un objeto que ya existe (objeto x = new objeto())
        //no puedo accederlo desde la clase

        //ToString() metodo de instancia de DateTime

        public string ObtenerDatos()
        {
            //El objeto vive en el heap
            StringBuilder sb = new StringBuilder();

            //Salto de linea
            sb.AppendLine("Datos del gato: ");
            sb.AppendLine($"Nombre: {nombre.ToUpper()}");
            sb.AppendLine($"Fecha de nacimiento: {fechaNacimiento.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Peso: {peso}");
            //Anida todo y lo vuelve un solo string
            return sb.ToString();

            //Formato compuesto
            //sb.AppendFormat("Nombre del gato: {0} ", nombre);

            ////Sin salto de linea
            //sb.Append("Fecha de nacimiento: ");
            //sb.Append(fechaNacimiento.ToString("dd/MM/yyyy"));

        }
    }
}
