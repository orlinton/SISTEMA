using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Cargo { get; set; }
        public DateTime FechaInicio { get; set; }
        public string Nota { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public int IdRol { get; set; }
    }
}
