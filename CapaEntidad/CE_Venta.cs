using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Venta
    {
        // Propiedades de la venta
        
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public decimal Total { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }
}
