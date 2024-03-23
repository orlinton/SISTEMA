using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Categoria
    {
        private ConexionBD Conexion = new ConexionBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;


        public DataTable VistaCategoria()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "VistaCategoria ";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }


        public void InsertarCategoria(string nombreCategoria)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "InsertarCategoria";
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@nombCategoria", nombreCategoria);

                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar categoría: " + ex.Message);
            }
            finally
            {
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }
        }

        public void ActualizarCategoria(int idCategoria, string nombreCategoria)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "ActualizarCategoria";
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@IdCategoria", idCategoria);
                Comando.Parameters.AddWithValue("@nombCategoria", nombreCategoria);

                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar categoría: " + ex.Message);
            }
            finally
            {
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }
        }

        public void EliminarCategoria(int idCategoria)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "EliminarCategoria";
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@IdCategoria", idCategoria);

                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar categoría: " + ex.Message);
            }
            finally
            {
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }
        }
    }
}