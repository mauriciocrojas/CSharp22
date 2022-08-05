using System;
using System.IO;
using System.Text.Json;

namespace BibliotecaDeClases
{
    public static class Serializador<T>
    { 


        public static void Escribir(T datos, string ruta, string nombreArchivo, Action<string> mostrarElementos)
        {
            try
            {

                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamWriter writer = new StreamWriter(ruta + nombreArchivo))
                {
                    JsonSerializerOptions opc = new JsonSerializerOptions();
                    opc.WriteIndented = true;
                    string jsonString = JsonSerializer.Serialize(datos, opc);
                    writer.WriteLine(jsonString);
                }

                mostrarElementos.Invoke("El empleado ha sido serializado correctamente");

            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar guardar archivo json.", ex);
            }
        }

    }
}
