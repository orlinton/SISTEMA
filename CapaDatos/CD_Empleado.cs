using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Empleado
    {

        private ConexionBD Conexion = new ConexionBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable VistaEmpleado()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "VistaEmpleado";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable VerTodosLosRoles()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "VerTodosLosRoles";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public void CrearEmpleado(string nombreEmpleado, string apellidoEmpleado, string telefonoEmpleado, string cargoEmpleado, DateTime fechaInicio, string Nota, string usuario, string contraseña, int idRol)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "CrearEmpleado";
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@nombreEmpleado", nombreEmpleado);
                Comando.Parameters.AddWithValue("@apellidoEmpleado", apellidoEmpleado);
                Comando.Parameters.AddWithValue("@telefonoEmpleado", telefonoEmpleado);
                Comando.Parameters.AddWithValue("@cargoEmpleado", cargoEmpleado);
                Comando.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                Comando.Parameters.AddWithValue("@nota", Nota);
                Comando.Parameters.AddWithValue("@usuario", usuario);
                Comando.Parameters.AddWithValue("@contraseña", contraseña);
                Comando.Parameters.AddWithValue("@idRol", idRol);

                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                Console.WriteLine("Error al crear empleado con usuario y rol: " + ex.Message);
            }
            finally
            {
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }
        }

        public void EliminarEmpleado(int idEmpleado)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "EliminarEmpleado";
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);

                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                Console.WriteLine("Error al eliminar empleado: " + ex.Message);
            }
            finally
            {
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }
        }

        public void ActualizarEmpleado(int idEmpleado, string nombreEmpleado, string apellidoEmpleado, string telefonoEmpleado, string cargoEmpleado, DateTime fechaInicio, string nota, string usuario, string contraseña, int idRol)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "ActualizarEmpleado";
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                Comando.Parameters.AddWithValue("@nombreEmpleado", nombreEmpleado);
                Comando.Parameters.AddWithValue("@apellidoEmpleado", apellidoEmpleado);
                Comando.Parameters.AddWithValue("@telefonoEmpleado", telefonoEmpleado);
                Comando.Parameters.AddWithValue("@cargoEmpleado", cargoEmpleado);
                Comando.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                Comando.Parameters.AddWithValue("@nota", nota);
                Comando.Parameters.AddWithValue("@usuario", usuario);
                Comando.Parameters.AddWithValue("@contraseña", contraseña);
                Comando.Parameters.AddWithValue("@idRol", idRol);

                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                Console.WriteLine("Error al actualizar empleado: " + ex.Message);
            }
            finally
            {
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }
        }
    }
}

    


