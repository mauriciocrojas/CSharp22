using Logica;
using System;

//Un sistema que ingresando usuario y contraseña,
//me diga USUARIO LOGUEADO si es correcto, y si no es correcto ,
//ACCESO DENEGADO

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user;
            string pass;
            int option;

            Console.WriteLine("1. Crear usuario");
            Console.WriteLine("2. Cambiar contraseña");
            Console.WriteLine("3. Ver información");
            Console.WriteLine("4. Listar usuarios");
            Console.WriteLine("5. Salir");

            Console.Write("Ingrese una opción: ");
            option = int.Parse(Console.ReadLine());


            switch (option)
            {

                case 1:

                    Console.Clear();
                    Console.WriteLine("Usted seleccionó opción 1)Crear usuario.\n");

                    Console.Write("Ingrese un nombre de usuario: ");
                    user = Console.ReadLine();
                    Console.Write("Ingrese una clave: ");
                    pass = Console.ReadLine();

                    Sistema.CrearNuevoUsuario(user, pass);
                    Sistema.MostrarUsuarios();

                    break;

                case 2:
                    Console.WriteLine("Usted seleccionó opcion 2");
                    break;

                case 3:
                    Console.WriteLine("Usted seleccionó opcion 3");
                    break;

                case 4:
                    Sistema.MostrarUsuarios();
                    break;
                case 5:
                    Console.WriteLine("Usted seleccionó salir, chauchau");
                    break;
            }

        }
    }
}
