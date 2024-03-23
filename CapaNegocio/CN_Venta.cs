using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos; // Importa el espacio de nombres de la capa de datos
using CapaEntidad; // Importa el espacio de nombres de la capa de entidad


namespace CapaNegocio
{
    public class CN_Venta
    {
        private ConexionBD Conexion = new ConexionBD();
        private SqlCommand Comando = new SqlCommand();
        

        private CD_Venta capaDatosVenta = new CD_Venta();
        // Método para insertar una venta completa
        public void InsertarVentaCompleta(CE_Venta venta)
        {
            try
            {
                // Llama al método correspondiente en la capa de datos para insertar la venta completa
                capaDatosVenta.InsertarVentaCompleta(venta.IdCliente, venta.IdEmpleado, venta.Fecha, venta.TipoComprobante,
                                                      venta.Iva, venta.IdProducto, venta.Cantidad, venta.PrecioVenta,
                                                      venta.Descuento);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Error al insertar venta: " + ex.Message);
            }
        }
    }
}