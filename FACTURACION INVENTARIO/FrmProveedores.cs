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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
            vistaproveedores();
        }

        private void vistaproveedores()
        {

            // Asegúrate de que CD_Producto esté correctamente implementado
            CD_Proveedores objprod = new CD_Proveedores();
            // Verifica si hay datos en el DataGridView antes de asignar la nueva fuente de datos
            if (dataGridViewProveedores.DataSource != null)
            {
                dataGridViewProveedores.DataSource = null;
            }
            // Asigna la nueva fuente de datos
            dataGridViewProveedores.DataSource = objprod.VerProveedores();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            // Verificar si todos los campos están llenos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtNota.Text)) 
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar un nuevo proveedor.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método sin agregar el proveedor
            }

            // Crear una instancia de la clase CN_Proveedores
            CN_Proveedores cnProveedor = new CN_Proveedores();

            // Crear un objeto CE_Proveedores con los datos del formulario
            CE_Proveedores nuevoProveedor = new CE_Proveedores
            {
                Nombre = txtNombre.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text,
                Nota = txtNota.Text,
            };

            // Llamar al método InsertarProveedor de la capa de negocios para agregar el nuevo proveedor
            cnProveedor.InsertarProveedor(nuevoProveedor);

            // Volver a cargar la vista de proveedores después de agregar el proveedor
            vistaproveedores();

            // Limpiar los controles del formulario después de agregar el proveedor
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            // Limpiar los controles del formulario
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtNota.Clear();
        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {

            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridViewProveedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un proveedor para actualizar.", "Proveedor no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método si no se ha seleccionado ninguna fila
            }

            // Obtener el ID del proveedor seleccionado en el DataGridView
            int idProveedor = Convert.ToInt32(dataGridViewProveedores.SelectedRows[0].Cells["Id_proveedores"].Value);

            // Obtener los nuevos datos del proveedor desde los controles del formulario
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            string nota = txtNota.Text;

            // Verificar si todos los campos están llenos
            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(direccion) ||
                string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(nota))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de actualizar el proveedor.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método sin actualizar el proveedor
            }

            // Crear una instancia de la clase CN_Proveedores
            CN_Proveedores cnProveedor = new CN_Proveedores();

            // Crear un objeto CE_Cliente con los nuevos datos
            CE_Proveedores proveedoresActualizado = new CE_Proveedores
            {
                Id_proveedores = idProveedor,
                Nombre = nombre,
                Direccion = direccion,
                Telefono = telefono,
                Correo = correo,
                Nota = nota
            };

            // Llamar al método ActualizarCliente de la capa de negocios para actualizar el cliente
            cnProveedor.ActualizarProveedor(proveedoresActualizado);

            // Volver a cargar la vista de proveedores después de actualizar el proveedor
            vistaproveedores();

            // Limpiar los controles del formulario después de actualizar el proveedor
            LimpiarControles();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridViewProveedores.SelectedRows.Count > 0)
            {
                // Obtener los datos del proveedor seleccionado en el DataGridView
                int idProveedor = Convert.ToInt32(dataGridViewProveedores.SelectedRows[0].Cells["Id_proveedores"].Value);
                string nombre = dataGridViewProveedores.SelectedRows[0].Cells["nombre"].Value.ToString();
                string direccion = dataGridViewProveedores.SelectedRows[0].Cells["direccion"].Value.ToString();
                string telefono = dataGridViewProveedores.SelectedRows[0].Cells["telefono"].Value.ToString();
                string correo = dataGridViewProveedores.SelectedRows[0].Cells["correo"].Value.ToString();
                string nota = dataGridViewProveedores.SelectedRows[0].Cells["nota"].Value.ToString();

                // Mostrar los datos del proveedor seleccionado en los controles del formulario
                txtNombre.Text = nombre;
                txtDireccion.Text = direccion;
                txtTelefono.Text = telefono;
                txtCorreo.Text = correo;
                txtNota.Text = nota;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un proveedor.", "Proveedor no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridViewProveedores.SelectedRows.Count > 0)
            {
                // Obtener el ID del proveedor seleccionado
                int idProveedor = Convert.ToInt32(dataGridViewProveedores.SelectedRows[0].Cells["Id_proveedores"].Value);

                // Confirmar con el usuario si realmente desea eliminar el proveedor
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este proveedor?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Llamar al método EliminarProveedor de la capa de negocio para eliminar el proveedor
                    CN_Proveedores cnProveedor = new CN_Proveedores();
                    cnProveedor.EliminarProveedor(idProveedor);

                    // Actualizar la vista de proveedores después de eliminar
                    vistaproveedores();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un proveedor para eliminar.", "Seleccione Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
