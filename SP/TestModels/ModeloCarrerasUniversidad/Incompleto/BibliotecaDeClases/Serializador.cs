using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace BibliotecaDeClases
{
    public static class Serializador<T>
    {

        public static T LeerJson(string archivo, Action<string> MostrarElementos)
        {
            T datos;

            using (StreamReader sr = new StreamReader(archivo))
                {

                    string archivoJson = File.ReadAllText(archivo);
                    datos = JsonSerializer.Deserialize<T>(archivoJson);
                    MostrarElementos.Invoke("Documento deserializado con éxito");
                    return datos;
                }

        }
    }
}
