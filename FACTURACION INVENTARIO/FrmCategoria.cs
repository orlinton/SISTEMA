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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
            vistaproveedores();
        }

        private void vistaproveedores()
        {

            // Asegúrate de que CD_Producto esté correctamente implementado
            CD_Categoria objprod = new CD_Categoria();
            // Verifica si hay datos en el DataGridView antes de asignar la nueva fuente de datos
            if (dataGridViewCategoria.DataSource != null)
            {
                dataGridViewCategoria.DataSource = null;
            }
            // Asigna la nueva fuente de datos
            dataGridViewCategoria.DataSource = objprod.VistaCategoria();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                // Verificar si el nombre de la categoría no está vacío
                if (!string.IsNullOrWhiteSpace(txtCategoria.Text))
                {
                    // Crear una instancia de la clase de negocios de categoría
                    CN_Categoria cnCategoria = new CN_Categoria();

                    // Crear una instancia de la entidad de categoría y asignar el nombre desde el TextBox
                    CE_Categoria nuevaCategoria = new CE_Categoria();
                    nuevaCategoria.NombreCategoria = txtCategoria.Text;

                    // Llamar al método de la capa de negocios para insertar la nueva categoría
                    cnCategoria.InsertarCategoria(nuevaCategoria);

                    // Mostrar un mensaje de éxito
                    MessageBox.Show("Categoría agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar el TextBox después de agregar la categoría
                    txtCategoria.Text = "";
                    vistaproveedores();

                    // Actualizar la vista de las categorías si es necesario
                    // Esto puede incluir volver a cargar los datos en un control DataGridView, ListBox, etc.
                }
                else
                {
                    // Mostrar un mensaje de error si el nombre de la categoría está vacío
                    MessageBox.Show("Por favor, ingrese el nombre de la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la inserción de la categoría
                MessageBox.Show("Error al agregar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView de categorías
            if (dataGridViewCategoria.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow row = dataGridViewCategoria.SelectedRows[0];

                // Asignar los datos a los controles del formulario
                txtCategoria.Text = row.Cells["NombreCategoria"].Value.ToString();

                // Obtener el ID de la categoría seleccionada si es necesario
                //int idCategoria = Convert.ToInt32(row.Cells["Id_categoria"].Value);

                // Aquí puedes realizar cualquier acción adicional con los datos de la categoría seleccionada

                MessageBox.Show("Categoría seleccionada: " + txtCategoria.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Mostrar un mensaje si no se ha seleccionado ninguna categoría
                MessageBox.Show("Por favor, seleccione una categoría.", "Categoría no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado una fila en el DataGridView de categorías
                if (dataGridViewCategoria.SelectedRows.Count > 0)
                {
                    // Obtener el ID de la categoría seleccionada
                    int idCategoria = Convert.ToInt32(dataGridViewCategoria.SelectedRows[0].Cells["Id_categoria"].Value);

                    // Aquí puedes llamar al método de eliminación de la capa de negocios para eliminar la categoría con el ID obtenido
                    // Por ejemplo:
                    CN_Categoria cnCategoria = new CN_Categoria();
                    cnCategoria.EliminarCategoria(idCategoria);

                    // Mostrar un mensaje de éxito después de eliminar la categoría
                    MessageBox.Show("Categoría eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    vistaproveedores();
                    // Actualizar la vista de las categorías si es necesario
                    // Esto puede incluir volver a cargar los datos en un control DataGridView, ListBox, etc.
                    // También puedes realizar cualquier otra acción que sea necesaria después de eliminar la categoría
                }
                else
                {
                    // Mostrar un mensaje si no se ha seleccionado ninguna categoría
                    MessageBox.Show("Por favor, seleccione una categoría para eliminar.", "Categoría no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante el procesamiento
                MessageBox.Show("Error al eliminar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado una fila en el DataGridView de categorías
                if (dataGridViewCategoria.SelectedRows.Count > 0)
                {
                    // Obtener el ID de la categoría seleccionada
                    int idCategoria = Convert.ToInt32(dataGridViewCategoria.SelectedRows[0].Cells["Id_categoria"].Value);

                    // Obtener el nuevo nombre de la categoría desde el campo de texto txtCategoria
                    string nuevoNombreCategoria = txtCategoria.Text;

                    // Verificar si el campo de texto no está vacío
                    if (string.IsNullOrWhiteSpace(nuevoNombreCategoria))
                    {
                        MessageBox.Show("Por favor, ingrese el nombre de la categoría.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Salir del método sin actualizar la categoría
                    }

                    // Crear una instancia de la clase de negocios de categoría
                    CN_Categoria cnCategoria = new CN_Categoria();

                    // Crear una instancia de la entidad de categoría con el nuevo nombre
                    CE_Categoria categoriaActualizada = new CE_Categoria();
                    categoriaActualizada.IdCategoria = idCategoria;
                    categoriaActualizada.NombreCategoria = nuevoNombreCategoria;

                    // Llamar al método de actualización de la categoría en la capa de negocios
                    cnCategoria.ActualizarCategoria(categoriaActualizada);

                    // Mostrar un mensaje de éxito después de actualizar la categoría
                    MessageBox.Show("Categoría actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar el campo de texto después de la actualización
                    txtCategoria.Text = "";
                    vistaproveedores();

                    // Actualizar la vista de las categorías si es necesario
                    // Esto puede incluir volver a cargar los datos en un control DataGridView, ListBox, etc.
                }
                else
                {
                    // Mostrar un mensaje si no se ha seleccionado ninguna categoría
                    MessageBox.Show("Por favor, seleccione una categoría para actualizar.", "Categoría no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la actualización
                MessageBox.Show("Error al actualizar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
