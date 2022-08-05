using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaDeClases
{
    public class SqlManejador
    {

        SqlConnection conexion;
        SqlCommand comando;

        public SqlManejador()
        {
            conexion = new SqlConnection(@"Data Source=.;Database=ExamenPrimerFecha2022;Trusted_Connection=True;");
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;

        }

        public int Insertar(Empleado empleado)
        {
            try
            {
                if (!(empleado.Dni > 100000 && empleado.Dni < 45000000) ||
                    String.IsNullOrEmpty(empleado.NombreCompleto) ||
                    String.IsNullOrEmpty(empleado.Posicion)
                    )
                {
                    throw new DatoErroneoException("Hay datos inválidos.");
                }

                conexion.Open();
                comando.CommandText = "Insert into Empleados values (@Dni, @Nomb,@Posicion,@Dolarizado)";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Dni", empleado.Dni);
                comando.Parameters.AddWithValue("@Nomb", empleado.NombreCompleto);
                comando.Parameters.AddWithValue("@Posicion", empleado.Posicion);


                comando.Parameters.AddWithValue("@Dolarizado", empleado.CalcularHonorarios);

                return comando.ExecuteNonQuery();
            }
            catch (DatoErroneoException ex)
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
