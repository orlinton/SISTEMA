using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Venta
    {
        // Propiedades de la clase CE_Venta
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoComprobante { get; set; }
        public decimal Iva { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Descuento { get; set; }

    }
}
