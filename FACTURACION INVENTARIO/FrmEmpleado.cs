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
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
            listarROL();
            vistaproveedores();
        }


        private void listarROL()
        {
            CD_Empleado objProd = new CD_Empleado();
            cmbRol.DataSource = objProd.VerTodosLosRoles();
            cmbRol.DisplayMember = "nombre";
            cmbRol.ValueMember = "Id_Rol";
        }

        private void vistaproveedores()
        {

            // Asegúrate de que CD_Producto esté correctamente implementado
            CD_Empleado objprod = new CD_Empleado();
            // Verifica si hay datos en el DataGridView antes de asignar la nueva fuente de datos
            if (dataGridViewEmpleado.DataSource != null)
            {
                dataGridViewEmpleado.DataSource = null;
            }
            // Asigna la nueva fuente de datos
            dataGridViewEmpleado.DataSource = objprod.VistaEmpleado();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Verificar si todos los campos están llenos
            if (string.IsNullOrWhiteSpace(TxtnNombre.Text) ||
                string.IsNullOrWhiteSpace(TxtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(TxtCargo.Text) ||
                string.IsNullOrWhiteSpace(TxtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text) ||
                 string.IsNullOrWhiteSpace(txtNota.Text) ||
                cmbRol.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar un nuevo empleado.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método sin agregar el empleado
            }

            try
            {
                // Crear una instancia de la clase CN_Empleado
                CN_Empleado cnEmpleado = new CN_Empleado();

                // Crear un objeto CE_Empleado con los datos del formulario
                CE_Empleado nuevoEmpleado = new CE_Empleado
                {
                    Nombre = TxtnNombre.Text,
                    Apellido = TxtApellido.Text,
                    Telefono = txtTelefono.Text,
                    Cargo = TxtCargo.Text,
                    FechaInicio = dateTimeFecha.Value,
                    Usuario = TxtUsuario.Text,
                    Contraseña = txtContraseña.Text,
                    Nota = txtNota.Text,
                    IdRol = Convert.ToInt32(cmbRol.SelectedValue) // Suponiendo que el ComboBox tiene un DataSource y el campo ValueMember está configurado correctamente.
                };

                // Llamar al método CrearEmpleado de la capa de negocios para agregar el nuevo empleado
                cnEmpleado.CrearEmpleado(nuevoEmpleado);


                // Limpiar los controles del formulario después de agregar el empleado
                LimpiarControles();

                vistaproveedores();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                MessageBox.Show("Error al agregar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarControles()
        {
            // Limpiar los controles del formulario
            TxtnNombre.Clear();
            txtContraseña.Clear();
            txtTelefono.Clear();
            TxtCargo.Clear();
            txtNota.Clear();
            TxtUsuario.Clear();
            txtContraseña.Clear();
            cmbRol.SelectedIndex = -1; // Reinicia la selección en el ComboBox de Roles
            dateTimeFecha.Value = DateTime.Now; // Establece la fecha actual en el DateTimePicker
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridViewEmpleado.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow row = dataGridViewEmpleado.SelectedRows[0];

                // Asignar los datos a los controles del formulario
                TxtnNombre.Text = row.Cells["NombreEmpleado"].Value.ToString();
                TxtApellido.Text = row.Cells["ApellidoEmpleado"].Value.ToString();
                txtTelefono.Text = row.Cells["TelefonoEmpleado"].Value.ToString();
                TxtCargo.Text = row.Cells["CargoEmpleado"].Value.ToString();
                TxtUsuario.Text = row.Cells["NombreUsuario"].Value.ToString();
                txtContraseña.Text = row.Cells["ContraseñaUsuario"].Value.ToString();
                txtNota.Text = row.Cells["NotaEmpleado"].Value.ToString();

                // Obtener y establecer las fechas
                DateTime fechaIngreso = Convert.ToDateTime(row.Cells["FechaInicio"].Value);
                dateTimeFecha.Value = fechaIngreso;
                

                //Si cmbRol es un ComboBox que se debe seleccionar con base en el nombre del rol,
                // puedes usar el nombre del rol en lugar del idRol.
                string nombreRol = row.Cells["NombreRol"].Value.ToString();
                SetComboBoxSelectedIndex(cmbRol, nombreRol);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado.", "Empleado no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetComboBoxSelectedIndex(ComboBox cmbRol, string nombreRol)
        {
            int index = -1;
            for (int i = 0; i < cmbRol.Items.Count; i++)
            {
                // Compara el nombre del rol con los elementos en el ComboBox
                if (cmbRol.GetItemText(cmbRol.Items[i]) == nombreRol)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                // Si se encontró el nombre del rol, establece el índice seleccionado en el ComboBox
                cmbRol.SelectedIndex = index;
            }
            else
            {
                // Si no se encontró el nombre del rol, puedes manejarlo según tus necesidades.
                // Puedes mostrar un mensaje, establecer un valor predeterminado, etc.
                MessageBox.Show($"El rol '{nombreRol}' no se encuentra en la lista del ComboBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {

            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridViewEmpleado.SelectedRows.Count > 0)
            {
                // Obtener el ID del empleado seleccionado
                int idEmpleado = Convert.ToInt32(dataGridViewEmpleado.SelectedRows[0].Cells["Id_Empleado"].Value);

                // Obtener los nuevos valores de los controles del formulario
                string nombreEmpleado = TxtnNombre.Text;
                string apellidoEmpleado = TxtApellido.Text;
                string telefonoEmpleado = txtTelefono.Text;
                string cargoEmpleado = TxtCargo.Text;
                DateTime fechaInicio = dateTimeFecha.Value;
                string nota = txtNota.Text;
                string usuario = TxtUsuario.Text;
                string contraseña = txtContraseña.Text;
                int idRol = Convert.ToInt32(cmbRol.SelectedValue); // Suponiendo que el ComboBox de roles tiene un DataSource y el campo ValueMember está configurado correctamente.

                // Verificar si todos los campos están llenos
                if (string.IsNullOrWhiteSpace(nombreEmpleado) ||
                    string.IsNullOrWhiteSpace(apellidoEmpleado) ||
                    string.IsNullOrWhiteSpace(telefonoEmpleado) ||
                    string.IsNullOrWhiteSpace(cargoEmpleado) ||
                    string.IsNullOrWhiteSpace(nota) ||
                    string.IsNullOrWhiteSpace(usuario) ||
                    string.IsNullOrWhiteSpace(contraseña))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de actualizar el empleado.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir del método sin actualizar el empleado
                }

                try
                {
                    // Llamar al método de actualización del empleado en la capa de negocios o datos
                    CN_Empleado cnEmpleado = new CN_Empleado();
                    cnEmpleado.ActualizarEmpleado(idEmpleado, nombreEmpleado, apellidoEmpleado, telefonoEmpleado, cargoEmpleado, fechaInicio, nota, usuario, contraseña, idRol);

                    // Actualizar la vista del DataGridView después de la actualización
                    vistaproveedores();

                    // Limpiar los controles del formulario después de la actualización
                    LimpiarControles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado.", "Empleado no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridViewEmpleado.SelectedRows.Count > 0)
            {
                // Obtener el ID del empleado seleccionado
                int idEmpleado = Convert.ToInt32(dataGridViewEmpleado.SelectedRows[0].Cells["Id_Empleado"].Value);

                try
                {
                    // Llamar al método de eliminación del empleado en la capa de negocios o datos
                    CN_Empleado cnEmpleado = new CN_Empleado();
                    cnEmpleado.EliminarEmpleado(idEmpleado);

                    // Actualizar la vista del DataGridView después de la eliminación
                    vistaproveedores();

                    // Limpiar los controles del formulario después de la eliminación
                    LimpiarControles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado.", "Empleado no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
