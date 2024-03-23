using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Empleado
    {
        private CD_Empleado CDempleado = new CD_Empleado();

        public void CrearEmpleado(CE_Empleado empleado)
        {
            // Aquí podrías agregar lógica adicional, como validar los datos antes de insertarlos en la base de datos
            // Luego, llamar al método correspondiente en la capa de datos para insertar el empleado
            CDempleado.CrearEmpleado(empleado.Nombre, empleado.Apellido, empleado.Telefono, empleado.Cargo, empleado.FechaInicio, empleado.Nota, empleado.Usuario,  empleado.Contraseña, empleado.IdRol);
        }

        public void ActualizarEmpleado(int idEmpleado, string nombreEmpleado, string apellidoEmpleado, string telefonoEmpleado, string cargoEmpleado, DateTime fechaInicio, string nota, string usuario, string contraseña,  int idRol)
        {
            // Aquí podrías agregar lógica adicional, como validar los datos antes de actualizarlos en la base de datos
            // Luego, llamar al método correspondiente en la capa de datos para actualizar el empleado
            CDempleado.ActualizarEmpleado(idEmpleado, nombreEmpleado, apellidoEmpleado, telefonoEmpleado, cargoEmpleado, fechaInicio, nota, usuario, contraseña, idRol);
        }

        public void EliminarEmpleado(int idEmpleado)
        {
            // Aquí podrías agregar lógica adicional, como verificar si el empleado tiene dependencias antes de eliminarlo
            // Luego, llamar al método correspondiente en la capa de datos para eliminar el empleado
            CDempleado.EliminarEmpleado(idEmpleado);
        }
    }
}
