using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FACTURACION_INVENTARIO
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
            VistaClientes();
        }

        private void VistaClientes()
        {

            // Asegúrate de que CD_Producto esté correctamente implementado
            CD_Cliente objprod = new CD_Cliente();
            // Verifica si hay datos en el DataGridView antes de asignar la nueva fuente de datos
            if (dataGridViewCliente.DataSource != null)
            {
                dataGridViewCliente.DataSource = null;
            }
            // Asigna la nueva fuente de datos
            dataGridViewCliente.DataSource = objprod.vistaProducto();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        { // Verificar si todos los campos están llenos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar un nuevo cliente.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método sin agregar el cliente
            }
            // Crear una instancia de la clase CN_Cliente
            CN_Cliente cnCliente = new CN_Cliente();

            // Crear un objeto CE_Cliente con los datos del formulario
            CE_Cliente nuevoCliente = new CE_Cliente
            {
                Nombre = txtNombre.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtDireccion.Text
            };

            // Llamar al método InsertarCliente de la capa de negocios para agregar el nuevo cliente
            cnCliente.InsertarCliente(nuevoCliente);

            // Volver a cargar la vista de clientes después de agregar el cliente
            VistaClientes();

            // Limpiar los controles del formulario después de agregar el cliente
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            // Limpiar los TextBox
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            // Enfocar el primer TextBox
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {// Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridViewCliente.SelectedRows.Count > 0)
            {
                // Obtener el ID del producto seleccionado
                int idCliente = Convert.ToInt32(dataGridViewCliente.SelectedRows[0].Cells["Id_cliente"].Value);

                // Confirmar con el usuario si realmente desea eliminar el producto
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Llamar al método EliminarProducto de la capa de negocio para eliminar el producto
                    CN_Cliente cnCliente = new CN_Cliente();
                    cnCliente.EliminarCliente(idCliente);

                    // Actualizar la vista de productos después de eliminar
                    VistaClientes();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Seleccione Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {// Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridViewCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un cliente para actualizar.", "Cliente no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método si no se ha seleccionado ninguna fila
            }

            // Obtener el ID del cliente seleccionado en el DataGridView
            int idCliente = Convert.ToInt32(dataGridViewCliente.SelectedRows[0].Cells["Id_cliente"].Value);

            // Obtener los nuevos datos del cliente desde los controles del formulario
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;

            // Crear una instancia de la clase CN_Cliente
            CN_Cliente cnCliente = new CN_Cliente();

            // Crear un objeto CE_Cliente con los nuevos datos
            CE_Cliente clienteActualizado = new CE_Cliente
            {
                IdCliente = idCliente,
                Nombre = nombre,
                Direccion = direccion,
                Telefono = telefono
            };

            // Llamar al método ActualizarCliente de la capa de negocios para actualizar el cliente
            cnCliente.ActualizarCliente(clienteActualizado);

            // Volver a cargar la vista de clientes después de actualizar el cliente
            VistaClientes();

            // Limpiar los controles del formulario después de actualizar el cliente
            LimpiarControles();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridViewCliente.SelectedRows.Count > 0)
            {
                // Obtener los datos del cliente seleccionado en el DataGridView
                int idCliente = Convert.ToInt32(dataGridViewCliente.SelectedRows[0].Cells["Id_cliente"].Value);
                string nombre = dataGridViewCliente.SelectedRows[0].Cells["nombre"].Value.ToString();
                string direccion = dataGridViewCliente.SelectedRows[0].Cells["direccion"].Value.ToString();
                string telefono = dataGridViewCliente.SelectedRows[0].Cells["telefono"].Value.ToString();

                // Mostrar los datos del cliente seleccionado en los controles del formulario
                txtNombre.Text = nombre;
                txtDireccion.Text = direccion;
                txtTelefono.Text = telefono;

            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente.", "Cliente no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
