using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    class CE_Venta
    {
        public int Id_venta { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public int Id_cliente { get; set; }
        public int Id_empleado { get; set; }
        public string Nota { get; set; }
        public decimal Total { get; set; }
    }
}
