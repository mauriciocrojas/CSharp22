using System;


namespace Logica
{
    public class Usuario
    {
        //Atributos
       private string nombre;
       private string contrasenia;

        //Constructor
        public Usuario(string nombre, string contrasenia)
        {
            this.nombre = nombre;
            this.contrasenia = contrasenia;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre (string dato)
        {
            this.nombre = dato;
        }

        public bool ComprobarPass(string pass)
        {
            return contrasenia == pass;
        }


        public void ModificarContra(string pass)
        {
            //validaciones
            this.contrasenia = pass;
        }


    }
}
