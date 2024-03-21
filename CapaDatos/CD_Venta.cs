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
        public void InsertarVentaCompleta( int idCliente, int idEmpleado, DateTime fecha, string factura, decimal iva,  int idProducto, int cantidad, decimal precioUnitario,string descuento )
        {
            try
            {
                // Abrir la conexión
                SqlConnection connection = Conexion.AbrirConexion();

                // Configurar el comando para llamar al procedimiento almacenado
                Comando.Connection = connection;
                Comando.CommandText = "RegistrarVenta";
                Comando.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros al comando
                Comando.Parameters.AddWithValue("@id_cliente", idCliente);
                Comando.Parameters.AddWithValue("@id_empleado", idEmpleado);
                Comando.Parameters.AddWithValue("@fecha", fecha);
                Comando.Parameters.AddWithValue("@tipo_Comprovante", factura); 
                Comando.Parameters.AddWithValue("@iva", iva); 

                Comando.Parameters.AddWithValue("@id_producto", idProducto);
                Comando.Parameters.AddWithValue("@cantidad", cantidad);
                Comando.Parameters.AddWithValue("@precio_venta", precioUnitario);
                Comando.Parameters.AddWithValue("@descuento", descuento); 
               

                // Ejecutar el comando
                Comando.ExecuteNonQuery();

                // Cerrar la conexión
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                Console.WriteLine("Error al insertar la venta completa: " + ex.Message);
            }
            finally
            {
                // Limpiar los parámetros y cerrar la conexión
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();
            }
        }
    }

}
