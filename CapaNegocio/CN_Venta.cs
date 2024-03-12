using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos; // Importa el espacio de nombres de la capa de datos
using CapaEntidad; // Importa el espacio de nombres de la capa de entidad


namespace CapaNegocio
{
    class CN_Venta
    {
        // Método para realizar una venta
        public int RealizarVenta(int idCliente, int idEmpleado, int idProducto, int cantidad, decimal precioUnitario, string nota)
        {
            try
            {
                // Instancia del objeto de la capa de datos
                CD_Venta cdVenta = new CD_Venta();

                // Llamar al método de la capa de datos para realizar la venta
                return cdVenta.RealizarVenta(idCliente, idEmpleado, idProducto, cantidad, precioUnitario, nota);
            }
            catch (Exception ex)
            {
                // Manejar la excepción si ocurre algún error
                Console.WriteLine("Error al realizar la venta: " + ex.Message);
                return -1; // Retorna un valor negativo para indicar un error
            }
        }
    }
}
