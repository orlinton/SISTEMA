using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Proveedores
    {

        private ConexionBD Conexion = new ConexionBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;


        public DataTable VerProveedores()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "VerProveedores";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }


        public void InsertarProveedor(string nombre, string direccion, string telefono, string correo, string nota)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "InsertarProveedor";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@nombre", nombre);
                Comando.Parameters.AddWithValue("@direccion", direccion);
                Comando.Parameters.AddWithValue("@telefono", telefono);
                Comando.Parameters.AddWithValue("@correo", correo);
                Comando.Parameters.AddWithValue("@nota", nota);

                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                Console.WriteLine("Error al insertar proveedor: " + ex.Message);
            }
            finally
            {
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }
        }

        public void EliminarProveedor(int idProveedor)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "EliminarProveedor";
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@Id_proveedores", idProveedor);

                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                Console.WriteLine("Error al eliminar proveedores: " + ex.Message);
            }
            finally
            {
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }
        }

        public void ActualizarProveedor(int idProveedor, string nombre, string direccion, string telefono, string correo, string nota)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "ActualizarProveedor";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Id_proveedores", idProveedor);
                Comando.Parameters.AddWithValue("@nombre", nombre);
                Comando.Parameters.AddWithValue("@direccion", direccion);
                Comando.Parameters.AddWithValue("@telefono", telefono);
                Comando.Parameters.AddWithValue("@correo", correo);
                Comando.Parameters.AddWithValue("@nota", nota);

                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                Console.WriteLine("Error al actualizar proveedor: " + ex.Message);
            }
            finally
            {
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }
        }
    }
}
