using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Usuario
    {
        private string cadenaConexion = "Data Source=DESKTOP-JOJRB03\\SQLEXPRESS;Initial Catalog=BDventa;User ID=PC;Password=password;";

        public bool AutenticarUsuario(string nombreUsuario, string contraseña)
        {
            bool autenticado = false;

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consulta = "SELECT COUNT(*) FROM USUARIO WHERE usuario = @Usuario AND contraseña = @Contraseña";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Usuario", nombreUsuario);
                comando.Parameters.AddWithValue("@Contraseña", contraseña);

                try
                {
                    conexion.Open();
                    int resultado = (int)comando.ExecuteScalar();
                    autenticado = (resultado > 0);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al autenticar usuario: " + ex.Message);
                }
            }

            return autenticado;
        }

        public int ObtenerIdRol(string nombreUsuario)
        {
            int idRol = -1;

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consulta = "SELECT IdRol FROM USUARIO WHERE usuario = @Usuario";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Usuario", nombreUsuario);

                try
                {
                    conexion.Open();
                    object resultado = comando.ExecuteScalar();
                    if (resultado != null)
                    {
                        idRol = Convert.ToInt32(resultado);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener el ID de rol: " + ex.Message);
                }
            }

            return idRol;
        }
    }
}