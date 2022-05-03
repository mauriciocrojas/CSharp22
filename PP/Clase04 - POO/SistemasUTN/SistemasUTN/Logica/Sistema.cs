using System;


namespace Logica
{
    //Clase estática, todo dentro estático
    public static class Sistema
    {
        static Usuario[] usuariosRegistrados;

        //Nunca se va a hacer un new()
        //Por eso no es público, y es estático
        static Sistema()
        {
            usuariosRegistrados = new Usuario[5];
            CargarUsuariosHardcodeados();
        }

        private static void CargarUsuariosHardcodeados()
        {
            usuariosRegistrados[0] = new Usuario("Pepe", "asd123");
            usuariosRegistrados[1] = new Usuario("Juana", "arco123");
            usuariosRegistrados[2] = new Usuario("Romeo", "roro123");
            usuariosRegistrados[3] = new Usuario("Julieta", "juli123");
            usuariosRegistrados[4] = new Usuario("John", "snow123");
        }

        public static void MostrarUsuarios()
        {
            Console.WriteLine("\nLista de usuarios:\n");
            for (int i = 0; i <= usuariosRegistrados.Length; i++)
            {
                if (usuariosRegistrados[i] is not null)
                {
                    Console.WriteLine($"{usuariosRegistrados[i].GetNombre()}");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("\n");
        }

        private static int VerificarPosicionLibre()
        {
            for (int i = 0; i < usuariosRegistrados.Length; i++)
            {
                if (usuariosRegistrados[i] is null)
                {
                    return i;
                }

            }
            return -1;
        }


        public static bool CrearNuevoUsuario(string nombre, string password)
        {
            //que haya espacio            //que no exista

            int pos = VerificarPosicionLibre();

            if (pos != -1)
            {
                usuariosRegistrados[pos] = new Usuario(nombre, password);
                return true;
            }
            else
            {
                Console.WriteLine("No queda suficiente espacio para crear nuevos usuarios");
                return false;
            }


        }

        public static bool CambiarContra(string nombre, string password)
        {
            //que haya espacio
            //que no exista

            usuariosRegistrados[0].ModificarContra(password);

            return true;
        }

        public static bool ChequearUsuario(string nombre, string pass)
        {

            if (string.IsNullOrEmpty(nombre.Trim()) || string.IsNullOrEmpty(pass.Trim()))
            {
                return false;
            }

            for (int i = 0; i < usuariosRegistrados.Length; i++)
            {
                if (usuariosRegistrados[i] != null)
                {
                    if (nombre.Trim() == usuariosRegistrados[i].GetNombre().Trim())
                    {
                        return usuariosRegistrados[i].ComprobarPass(pass);
                    }

                }
            }

            return true;
        }

    }
}
