using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaDeClases
{
    public class SqlManejador
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static SqlManejador()
        {
            connectionString = @"Data Source=.;Initial Catalog=SP_2D_2022_C1;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }
        public static int Insert(Alumno alumno)
        {
            try
            {
                if (!(alumno.Dni > 10000000 && alumno.Dni < 45000000) || String.IsNullOrEmpty(alumno.NombreCompleto)
                    || !(alumno.NotaPrimerParcial >= 1 && alumno.NotaPrimerParcial <= 10) || !(alumno.NotaSegundoParcial >= 1 && alumno.NotaSegundoParcial <= 10)
                    || !(alumno.CalificacionFinal >= 1 && alumno.CalificacionFinal <= 10))
                {
                    throw new DatosNoValidosException("Hay datos no validos");
                }


                connection.Open();
                command.CommandText = $"INSERT INTO Alumnos (Dni, NombreCompleto,  NotaUno, NotaDos, CalificacionFinal)" +
                    $"VALUES ('{alumno.Dni}', '{alumno.NombreCompleto}', '{alumno.NotaPrimerParcial}', '{alumno.NotaSegundoParcial}', '{alumno.CalificacionFinal}')";

                return command.ExecuteNonQuery();
            }
            catch (DatosNoValidosException ex)
            {
                throw new DatosNoValidosException(ex.Message);
            }
            catch
            {
                throw new Exception ();
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
