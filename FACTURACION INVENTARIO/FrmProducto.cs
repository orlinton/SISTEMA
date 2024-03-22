using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace FACTURACION_INVENTARIO
{
    public partial class FrmProducto : Form
    {
        private string idprod;

        public FrmProducto()
        {
            InitializeComponent();
            ListarProductos();
            ListarCategorias();
            ListarProveedores();
            // Iterar a través de las columnas del DataGridView y mostrar sus nombres en la consola de depuración
            foreach (DataGridViewColumn column in dataGridViewProducto.Columns)
            {
                Console.WriteLine(column.Name);
            }
        }


        private void ListarProductos()
        {

            // Asegúrate de que CD_Producto esté correctamente implementado
            CD_Producto objprod = new CD_Producto();
            // Verifica si hay datos en el DataGridView antes de asignar la nueva fuente de datos
            if (dataGridViewProducto.DataSource != null)
            {
                dataGridViewProducto.DataSource = null;
            }
            // Asigna la nueva fuente de datos
            dataGridViewProducto.DataSource = objprod.vistaProducto();
        }

        private void ListarCategorias()
        {
            CD_Producto objProd = new CD_Producto();
            CmbCategoria.DataSource = objProd.ListarCategorias();
            CmbCategoria.DisplayMember = "nomb_categoria";
            CmbCategoria.ValueMember = "Id_categoria";
        }

        private void ListarProveedores()
        {
            CD_Producto objProd = new CD_Producto();
            CmbProveedores.DataSource = objProd.ListarProveedores();
            CmbProveedores.DisplayMember = "nombre";
            CmbProveedores.ValueMember = "Id_proveedores";
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) { }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Verificar si todos los campos están llenos
            if (string.IsNullOrWhiteSpace(txtproducto.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                string.IsNullOrWhiteSpace(txtUnidadMedida.Text) ||
                string.IsNullOrWhiteSpace(txtNota.Text) ||
                string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                CmbProveedores.SelectedIndex == -1 ||
                CmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar un nuevo producto.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método sin agregar el producto
            }
            // Crear una instancia de la clase CN_Producto
            CN_Producto cnProducto = new CN_Producto();

            // Crear un objeto CE_Producto con los datos del formulario
            CE_Producto nuevoProducto = new CE_Producto
            {
                Nombre = txtproducto.Text,
                Descripcion = txtDescripcion.Text,
                Precio = Convert.ToDecimal(txtPrecio.Text),
                Cantidad = Convert.ToInt32(txtCantidad.Text),
                Proveedor = Convert.ToInt32(CmbProveedores.SelectedValue),
                Categoria = Convert.ToInt32(CmbCategoria.SelectedValue),
                FechaIngreso = dtpFechaIngreso.Value, // Obtener la fecha desde un DateTimePicker
                FechaCaducidad = dtpFechaCaducidad.Value,
                UnidadMedida = txtUnidadMedida.Text,
                Nota = txtNota.Text,
                Codigo = txtCodigo.Text
            };

            // Llamar al método InsertarProducto de la capa de negocios para agregar el nuevo producto
            cnProducto.InsertarProducto(nuevoProducto);

            // Limpiar los controles del formulario después de agregar el producto
            LimpiarControles();
            ListarProductos();
        }

        private void LimpiarControles()
        {
            txtproducto.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtUnidadMedida.Text = "";
            txtNota.Text = "";
            txtCantidad.Text = "";
            txtCodigo.Text = "";
            // Limpiar otros controles si es necesario
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, el separador decimal y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Permitir solo un separador decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            // Permitir solo un separador decimal
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridViewProducto.SelectedRows.Count > 0)
            {
                // Obtener el ID del producto seleccionado
                int idProducto = Convert.ToInt32(dataGridViewProducto.SelectedRows[0].Cells["IdProducto"].Value);

                // Confirmar con el usuario si realmente desea eliminar el producto
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Llamar al método EliminarProducto de la capa de negocio para eliminar el producto
                    CN_Producto cnProducto = new CN_Producto();
                    cnProducto.EliminarProducto(idProducto);

                    // Actualizar la vista de productos después de eliminar
                    ListarProductos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Seleccione Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {// Verificar si hay una fila seleccionada en el DataGridView
            if (dataGridViewProducto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto de la lista para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el ID del producto seleccionado
            int idProducto = Convert.ToInt32(dataGridViewProducto.SelectedRows[0].Cells["IdProducto"].Value);

            // Verificar que los campos obligatorios estén completos
            if (string.IsNullOrWhiteSpace(txtproducto.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Todos los campos obligatorios deben completarse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener los valores de los controles del formulario
            string nombre = txtproducto.Text;
            string descripcion = txtDescripcion.Text;
            decimal precio = Convert.ToDecimal(txtPrecio.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int proveedorId = Convert.ToInt32(CmbProveedores.SelectedValue);
            int categoriaId = Convert.ToInt32(CmbCategoria.SelectedValue);
            DateTime fechaIngreso = dtpFechaIngreso.Value;
            DateTime fechaCaducidad = dtpFechaCaducidad.Value;
            string unidadMedida = txtUnidadMedida.Text;
            string nota = txtNota.Text;
            string codigo = txtCodigo.Text;

            // Crear un objeto CE_Producto con los datos actualizados
            CE_Producto productoActualizado = new CE_Producto
            {
                IdProducto = idProducto,
                Nombre = nombre,
                Descripcion = descripcion,
                Precio = precio,
                Cantidad = cantidad,
                Proveedor = proveedorId,
                Categoria = categoriaId,
                FechaIngreso = fechaIngreso,
                FechaCaducidad = fechaCaducidad,
                UnidadMedida = unidadMedida,
                Nota = nota,
                Codigo = codigo
            };

            // Instanciar la clase CN_Producto
            CN_Producto cnProducto = new CN_Producto();

            // Llamar al método de actualización en la capa de negocio
            cnProducto.Actualizar_Producto(productoActualizado);

            // Actualizar la lista de productos después de la actualización
            ListarProductos();

            // Limpiar los controles del formulario después de la actualización
            LimpiarControles();

            // Mostrar un mensaje de éxito al usuario
            MessageBox.Show("El producto se ha actualizado correctamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridViewProducto.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow row = dataGridViewProducto.SelectedRows[0];

                // Asignar los datos a los controles del formulario
                txtproducto.Text = row.Cells[1].Value.ToString();
                txtDescripcion.Text = row.Cells[2].Value.ToString();
                txtPrecio.Text = row.Cells[3].Value.ToString();
                txtCantidad.Text = row.Cells[4].Value.ToString();
                txtUnidadMedida.Text = row.Cells[9].Value.ToString();
                txtNota.Text = row.Cells[10].Value.ToString();
                txtCodigo.Text = row.Cells[11].Value.ToString();




                //// Seleccionar el proveedor y la categoría en los ComboBox
                SetComboBoxSelectedIndex(CmbProveedores, row.Cells[5].Value);
                SetComboBoxSelectedIndex(CmbCategoria, row.Cells[6].Value);

                // Obtener y establecer las fechas
                DateTime fechaIngreso = Convert.ToDateTime(row.Cells[7].Value);
                DateTime fechaCaducidad = Convert.ToDateTime(row.Cells[8].Value);
                dtpFechaIngreso.Value = fechaIngreso;
                dtpFechaCaducidad.Value = fechaCaducidad;

                // Guardar el ID del producto seleccionado para su posterior uso
                idprod = row.Cells["IdProducto"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto de la lista.", "Seleccione Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetComboBoxSelectedIndex(ComboBox comboBox, object value)
        {// Verifica si el valor proporcionado está en la lista de elementos del ComboBox
            int index = comboBox.FindStringExact(value.ToString());

            if (index != -1)
            {
                // Si el valor está en la lista, establece el índice seleccionado
                comboBox.SelectedIndex = index;
            }
            else
            {
                // Si el valor no está en la lista, puedes manejarlo según tus necesidades.
                // Puedes mostrar un mensaje, establecer un valor predeterminado, etc.
                MessageBox.Show($"El valor {value} no se encuentra en la lista del ComboBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
