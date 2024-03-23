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

        // Método para insertar una venta completa
        public void InsertarVentaCompleta(int idCliente, int idEmpleado, DateTime fecha, string tipoComprobante, decimal iva,
                                           int idProducto, int cantidad, decimal precioVenta, decimal descuento)
        {
            try
            {
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "RegistrarVenta";
                Comando.CommandType = CommandType.StoredProcedure;

                // Parámetros de entrada
                Comando.Parameters.AddWithValue("@id_cliente", idCliente);
                Comando.Parameters.AddWithValue("@id_empleado", idEmpleado);
                Comando.Parameters.AddWithValue("@fecha", fecha);
                Comando.Parameters.AddWithValue("@tipo_Comprovante", tipoComprobante);
                Comando.Parameters.AddWithValue("@iva", iva);
                Comando.Parameters.AddWithValue("@id_producto", idProducto);
                Comando.Parameters.AddWithValue("@cantidad", cantidad);
                Comando.Parameters.AddWithValue("@precio_venta", precioVenta);
                Comando.Parameters.AddWithValue("@descuento", descuento);

                // Ejecutar el comando
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Error al insertar venta: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                Conexion.CerrarConexion();
            }
        }

    }

}
