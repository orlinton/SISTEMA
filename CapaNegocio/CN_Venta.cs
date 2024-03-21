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
            capaDatosVenta.InsertarVentaCompleta(
               venta.IdCliente,
               venta.IdEmpleado,
               venta.Fecha,
               venta.TipoComprobante,
               venta.IVA,
               venta.IdProducto,
               venta.Cantidad,
               venta.PrecioUnitario,
               venta.Descuento
           );
        }
    }
}
