using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaDatos
{
    public class CD_Producto
    {
        private ConexionBD Conexion = new ConexionBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable vistaProducto()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "Vista_Productos";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable ListarCategorias()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarCategorias";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable ListarProveedores()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarProveedores";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }


        public void InsertarProductos(string nombre, string descripcion, decimal precio, int cantidad, int proveedores, int categoria, DateTime fechaIngreso, DateTime fechaCaducidad, string unidadMedida, string nota, string codigo, string ubicacion) 
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "InsertarProducto";
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@nombre", nombre);
                Comando.Parameters.AddWithValue("@descripcion", descripcion);
                Comando.Parameters.AddWithValue("@precio", precio);
                Comando.Parameters.AddWithValue("@cantidad", cantidad);
                Comando.Parameters.AddWithValue("@proveedores", proveedores);
                Comando.Parameters.AddWithValue("@categoria", categoria);
                Comando.Parameters.AddWithValue("@Fecha_ingreso", fechaIngreso);
                Comando.Parameters.AddWithValue("@Fecha_caducidad", fechaCaducidad);
                Comando.Parameters.AddWithValue("@unidad_medida", unidadMedida);
                Comando.Parameters.AddWithValue("@nota", nota);
                Comando.Parameters.AddWithValue("@codigo", codigo);
                Comando.Parameters.AddWithValue("@ubicacion", ubicacion);


                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                Console.WriteLine("Error al insertar producto: " + ex.Message);
            }
            finally
            {
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }
        }

        public void EliminarProducto(int idProducto)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "EliminarProducto";
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.AddWithValue("@IdProducto", idProducto);

                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                Console.WriteLine("Error al eliminar producto: " + ex.Message);
            }
            finally
            {
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }
        }

        public void Actualizar_Producto(int IdProducto, string nombre, string descripcion, decimal precio, int cantidad, int proveedores, int categoria, DateTime fechaIngreso, DateTime fechaCaducidad, string unidadMedida, string nota, string codigo, string ubicacion)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "ActualizarProducto";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@IdProducto", IdProducto);
                Comando.Parameters.AddWithValue("@nombre", nombre);
                Comando.Parameters.AddWithValue("@descripcion", descripcion);
                Comando.Parameters.AddWithValue("@precio", precio);
                Comando.Parameters.AddWithValue("@cantidad", cantidad);
                Comando.Parameters.AddWithValue("@proveedores", proveedores);
                Comando.Parameters.AddWithValue("@categoria", categoria);
                Comando.Parameters.AddWithValue("@Fecha_ingreso", fechaIngreso);
                Comando.Parameters.AddWithValue("@Fecha_caducidad", fechaCaducidad);
                Comando.Parameters.AddWithValue("@unidad_medida", unidadMedida);
                Comando.Parameters.AddWithValue("@nota", nota);
                Comando.Parameters.AddWithValue("@codigo", codigo);
                Comando.Parameters.AddWithValue("@ubicacion", ubicacion);

                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                Console.WriteLine("Error al actualizar producto: " + ex.Message);
            }
            finally
            {
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }
        }

    }
}

