using System;
using System.IO;
using System.Text.Json;

namespace BibliotecaDeClases
{
    public static class Serializador<T>
    {
        public static T Leer(string archivo, Action<string> mostrarElementos)
        {
            try
            {
                T datos;

                //if (Directory.Exists(archivo))
                //{
                using (StreamReader sr = new StreamReader(archivo))
                {

                    //string archivoJson = File.ReadAllText(archivo);
                    //datos = JsonSerializer.Deserialize<T>(archivoJson);

                    if (!string.IsNullOrEmpty(archivo))
                    {
                        datos = JsonSerializer.Deserialize<T>(File.ReadAllText(archivo));
                        mostrarElementos.Invoke("Documento deserializado con exito");
                        //}
                    }
                    else
                    {
                        throw new DirectoryNotFoundException("No encontrado");
                    }


                    return datos;
                }

            }
            catch (DirectoryNotFoundException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar leer archivo json.", ex);
            }

        }
    }
}
