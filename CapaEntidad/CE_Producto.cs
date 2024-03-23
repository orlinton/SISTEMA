using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public int Proveedor { get; set; }
        public int Categoria { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public string UnidadMedida { get; set; }
        public string Nota { get; set; }
        public string Codigo { get; set; }
        public string Ubicacion { get; set; }
    }
}
