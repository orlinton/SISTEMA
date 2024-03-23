using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Cliente
    {

        private ConexionBD Conexion = new ConexionBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable vistaProducto()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "vistaCliente";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public void InsertarCliente(string nombre, string direccion, string telefono)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "InsertarCliente";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Nombre", nombre);
                Comando.Parameters.AddWithValue("@Direccion", direccion);
                Comando.Parameters.AddWithValue("@Telefono", telefono);

                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                Console.WriteLine("Error al insertar cliente: " + ex.Message);
            }
            finally
            {
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }
        }


        public void EliminarCliente(int idcliente)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "EliminarCliente";
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@Id_cliente", idcliente);

                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                Console.WriteLine("Error al eliminar cliente: " + ex.Message);
            }
            finally
            {
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }
        }
        public void ActualizarCliente(int idCliente, string nombre, string direccion, string telefono)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "ActualizarCliente";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Id_cliente", idCliente);
                Comando.Parameters.AddWithValue("@nombre", nombre);
                Comando.Parameters.AddWithValue("@direccion", direccion);
                Comando.Parameters.AddWithValue("@telefono", telefono);

                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                Console.WriteLine("Error al actualizar cliente: " + ex.Message);
            }
            finally
            {
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }
        }


    }
}
