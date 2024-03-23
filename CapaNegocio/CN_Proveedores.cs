using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedores
    {
        private CD_Proveedores cdProveedores = new CD_Proveedores(); // Instancia de la capa de datos para proveedores

        public void InsertarProveedor(CE_Proveedores proveedor)
        {
            // Aquí podrías agregar lógica adicional, como validaciones, antes de insertar el proveedor en la base de datos
            cdProveedores.InsertarProveedor(proveedor.Nombre, proveedor.Direccion, proveedor.Telefono, proveedor.Correo, proveedor.Nota);
        }

        public void EliminarProveedor(int idProveedor)
        {
            // Llamada al método de la capa de datos para eliminar el proveedor
            cdProveedores.EliminarProveedor(idProveedor);
        }

        public void ActualizarProveedor(CE_Proveedores proveedor)
        {
            // Aquí podrías agregar lógica adicional, como validaciones, antes de actualizar el proveedor en la base de datos
            cdProveedores.ActualizarProveedor(proveedor.Id_proveedores, proveedor.Nombre, proveedor.Direccion, proveedor.Telefono, proveedor.Correo, proveedor.Nota);
        }
    }

}

