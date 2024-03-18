using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos; // Importa el espacio de nombres de la capa de datos
using CapaEntidad; // Importa el espacio de nombres de la capa de entidad


namespace CapaNegocio
{
    public class CN_Venta
    {

        private CD_Venta capaDatosVenta = new CD_Venta();

        public void InsertarVentaCompleta(CE_Venta venta)
        {
            // Aquí podrías realizar alguna validación de la venta antes de insertarla en la base de datos

            // Llama al método de la capa de datos para insertar la venta completa
            capaDatosVenta.InsertarVentaCompleta(venta.Fecha, venta.IdCliente, venta.IdEmpleado, venta.Total, venta.IdProducto, venta.Cantidad, venta.PrecioUnitario, venta.Subtotal);
        }
    }
}
