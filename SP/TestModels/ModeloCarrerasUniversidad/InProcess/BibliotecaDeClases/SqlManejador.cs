using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaDeClases
{
    public class SqlManejador
    {
        string connectionString;
        SqlCommand comando;
        SqlConnection conexion;

        public SqlManejador()
        {
            connectionString = @"Data Source=.;Initial Catalog=SP_2D_2022_C1;Integrated Security=True";
            conexion = new SqlConnection(connectionString);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public int Insertar(Alumno alumno)
        {
            try
            {
                if (!(alumno.Dni > 100000 && alumno.Dni < 45000000) || 
                    String.IsNullOrEmpty(alumno.NombreCompleto) ||
                    !(alumno.NotaPrimerParcial >= 1 && alumno.NotaPrimerParcial <= 10) ||
                    !(alumno.NotaSegundoParcial >= 1 && alumno.NotaSegundoParcial <= 10) ||
                    !(alumno.CalificacionFinal >= 1 && alumno.CalificacionFinal <= 10)
                    )
                {
                    throw new DatosNoValidosException("Hay datos inválidos.");
                }

                conexion.Open();
                comando.CommandText = "Insert into Alumnos values (@Dni, @Nomb,@Not1,@Not2,@CalificacionFinal) ";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Dni", alumno.Dni);
                comando.Parameters.AddWithValue("@Nomb", alumno.NombreCompleto);
                comando.Parameters.AddWithValue("@Not1", alumno.NotaPrimerParcial);
                comando.Parameters.AddWithValue("@Not2", alumno.NotaSegundoParcial);
                comando.Parameters.AddWithValue("@CalificacionFinal", alumno.CalificacionFinal);

                return comando.ExecuteNonQuery();
            }
            catch (DatosNoValidosException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
