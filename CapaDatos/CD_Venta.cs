using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Venta
    {

        private ConexionBD Conexion = new ConexionBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable listarCliente()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "listarCliente";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public int RealizarVenta(int idCliente, int idEmpleado, int idProducto, int cantidad, decimal precioUnitario, string nota)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "RealizarVenta";
                Comando.CommandType = CommandType.StoredProcedure;

                // Definir parámetros del procedimiento almacenado
                Comando.Parameters.AddWithValue("@idCliente", idCliente);
                Comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                Comando.Parameters.AddWithValue("@idProducto", idProducto);
                Comando.Parameters.AddWithValue("@cantidad", cantidad);
                Comando.Parameters.AddWithValue("@precioUnitario", precioUnitario);
                Comando.Parameters.AddWithValue("@nota", nota);

                // Agregar parámetro de retorno para obtener el ID de la venta
                SqlParameter idVentaParam = new SqlParameter("@idVenta", SqlDbType.Int);
                idVentaParam.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(idVentaParam);

                // Ejecutar el comando
                Comando.ExecuteNonQuery();

                // Obtener el ID de la venta generada
                int idVenta = Convert.ToInt32(idVentaParam.Value);

                Conexion.CerrarConexion();

                // Retornar el ID de la venta
                return idVenta;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción y retornar un valor predeterminado (por ejemplo, -1) o lanzar la excepción
                throw ex;
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                Conexion.CerrarConexion();
            }
        }
    }
}