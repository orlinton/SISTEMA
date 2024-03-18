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
        public void InsertarVentaCompleta(DateTime fecha, int idCliente, int idEmpleado, decimal total, int idProducto, int cantidad, decimal precioUnitario, decimal subtotal)
        {
            using (SqlConnection connection = Conexion.AbrirConexion())
            {
                SqlCommand command = new SqlCommand("InsertarVentaCompleta", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Definir parámetros
                command.Parameters.AddWithValue("@fecha", fecha);
                command.Parameters.AddWithValue("@id_cliente", idCliente);
                command.Parameters.AddWithValue("@id_empleado", idEmpleado);
                command.Parameters.AddWithValue("@total", total);
                command.Parameters.AddWithValue("@id_producto", idProducto);
                command.Parameters.AddWithValue("@cantidad", cantidad);
                command.Parameters.AddWithValue("@precio_unitario", precioUnitario);
                command.Parameters.AddWithValue("@subtotal", subtotal);

                // Ejecutar el comando
                command.ExecuteNonQuery();
            }
        }

    }
}