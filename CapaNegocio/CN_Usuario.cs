using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos; // Importa el espacio de nombres de la capa de datos
using CapaEntidad; // Importa el espacio de nombres de la capa de entidad

namespace CapaNegocio
{
    public class CN_Usuario
    {

        private CD_Usuario cdUsuario; // Instancia de la clase de acceso a datos para usuarios

        public CN_Usuario()
        {
            cdUsuario = new CD_Usuario(); // Inicializa la instancia de la clase de acceso a datos
        }

        // Método para autenticar un usuario
        public bool AutenticarUsuario(string nombreUsuario, string contraseña)
        {
            return cdUsuario.AutenticarUsuario(nombreUsuario, contraseña);
        }

        // Método para obtener el ID de rol de un usuario
        public int ObtenerIdRol(string nombreUsuario)
        {
            return cdUsuario.ObtenerIdRol(nombreUsuario);
        }
    }
}
