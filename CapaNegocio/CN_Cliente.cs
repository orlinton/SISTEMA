using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        private CD_Cliente cdCliente = new CD_Cliente(); // Instancia de la capa de datos para clientes

        public void InsertarCliente(CE_Cliente cliente)
        {
            // Aquí podrías agregar lógica adicional, como validaciones, antes de insertar el cliente en la base de datos
            cdCliente.InsertarCliente(cliente.Nombre, cliente.Direccion, cliente.Telefono);
        }

        public void EliminarCliente(int idCliente)
        {
            // Llamada al método de la capa de datos para eliminar el cliente
            cdCliente.EliminarCliente(idCliente);
        }

        public void ActualizarCliente(CE_Cliente cliente)
        {
            // Aquí podrías agregar lógica adicional, como validaciones, antes de actualizar el cliente en la base de datos
            cdCliente.ActualizarCliente(cliente.IdCliente, cliente.Nombre, cliente.Direccion, cliente.Telefono);
        }

    }
}
