using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FACTURACION_INVENTARIO
{
    public partial class FrmVenta : Form
    {
        private const string connectionString = "Data Source=DESKTOP-JOJRB03\\SQLEXPRESS;Initial Catalog=BDventa;User ID=PC;Password=password;";


        public FrmVenta()
        {
            InitializeComponent();
            ListarCategorias();

        }

        private void ListarCategorias()
        {
            CD_Venta objProd = new CD_Venta();
            cmbCliente.DataSource = objProd.listarCliente();
            cmbCliente.DisplayMember = "nombre";
            cmbCliente.ValueMember = "Id_cliente";
        }


        private void FrmVenta_Load(object sender, EventArgs e)
        {


        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {



            // Obtener los valores de los campos de texto
            string producto = txtproducto.Text.Trim();
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            decimal precio = Convert.ToDecimal(txtPrecio.Text);
            decimal total = Convert.ToDecimal(txtSubtotal.Text);

            // Agregar una nueva fila al DataGridView
            dataGridViewCarrito.Rows.Add(producto, cantidad, precio, total);

        }

        private void dataGridViewCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            // Obtener el código del producto a buscar del TextBox
            string codigoProducto = txtCodigo.Text.Trim();

            // Crear una conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Crear un comando para ejecutar el procedimiento almacenado
                    using (SqlCommand command = new SqlCommand("BuscarNombreCantidadPorCodigo", connection))
                    {
                        // Especificar que el comando es un procedimiento almacenado
                        command.CommandType = CommandType.StoredProcedure;

                        // Agregar el parámetro para el código del producto
                        command.Parameters.AddWithValue("@codigo", codigoProducto);

                        // Crear un adaptador de datos para ejecutar el comando y llenar un DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // Mostrar los resultados en los campos de texto si se encuentra el producto
                        if (table.Rows.Count > 0)
                        {
                            // Obtener el nombre y la cantidad del producto del DataTable
                            int IdProducto = Convert.ToInt32(table.Rows[0]["IdProducto"]);
                            string nombreProducto = table.Rows[0]["nombre"].ToString();
                            int cantidadProducto = Convert.ToInt32(table.Rows[0]["cantidad"]);

                            // Asignar los valores al TextBox correspondiente
                            txtIdProducto.Text = IdProducto.ToString();
                            txtproducto.Text = nombreProducto;
                            txtCantidad.Text = cantidadProducto.ToString();
                        }
                        else
                        {
                            // Limpiar los campos de texto si no se encuentra el producto
                            txtIdProducto.Text = string.Empty;
                            txtproducto.Text = string.Empty;
                            txtCantidad.Text = string.Empty;
                            MessageBox.Show("No se encontró ningún producto con ese código.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar productos: " + ex.Message);
                }
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            if (!string.IsNullOrWhiteSpace(txtCantidadVenta.Text) && !string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                // Obtener la cantidad y el precio
                int cantidad = Convert.ToInt32(txtCantidadVenta.Text);
                decimal precio = Convert.ToDecimal(txtPrecio.Text);

                // Calcular el total
                decimal total = cantidad * precio;

                // Mostrar el total en el campo txtTotal
                txtSubtotal.Text = total.ToString();
            }
            else
            {
                // Limpiar el campo txtTotal si falta alguno de los valores
                txtTotal.Text = string.Empty;
            }
        }



        private void CalcularCambio()
        {
            if (!string.IsNullOrWhiteSpace(txtEfectivo.Text) && !string.IsNullOrWhiteSpace(txtSubtotal.Text))
            {


                // Obtener el subtotal y el efectivo
                decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
                decimal efectivo = Convert.ToDecimal(txtEfectivo.Text);

                // Calcular el cambio
                decimal cambio = efectivo - subtotal;




                // Mostrar el cambio en el campo txtCambio
                txtCambio.Text = cambio.ToString();
            }
            else
            {
                // Limpiar el campo txtCambio si falta alguno de los valores
                txtCambio.Text = string.Empty;
            }

        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            CalcularCambio();
        }

        private void txtCantidadVenta_TextChanged(object sender, EventArgs e)
        {


        }

        private CD_Venta capaDatosVenta = new CD_Venta();


        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            if (dataGridViewCarrito.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar un producto en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DataTable detalle_venta = new DataTable();

            detalle_venta.Columns.Add("id_producto", typeof(string));
            detalle_venta.Columns.Add("cantidad", typeof(string));
            detalle_venta.Columns.Add("precio_unitario", typeof(int));
            detalle_venta.Columns.Add("subtotal", typeof(decimal));




            foreach (DataGridViewRow row in dataGridViewCarrito.Rows)
            {
                // Agregar una nueva fila al DataTable con los valores del detalle de venta actual
                detalle_venta.Rows.Add(new object[]
                {
                    row.Cells["id_producto"].Value.ToString(),
                     row.Cells["cantidad"].Value.ToString(),
                      row.Cells["precio_unitario"].Value.ToString(),
                       row.Cells["subtotal"].Value.ToString(),

                });

                // Crear una instancia de la clase CN_Producto
                CN_Venta capaDatosVenta = new CN_Venta();

                CE_Venta venta = new CE_Venta
                {
                    Fecha = dateTimeventa.Value,
                    IdCliente = Convert.ToInt32(cmbCliente.SelectedValue),
                    IdEmpleado = Convert.ToInt32(txtEmpleado.Text),
                    Total = Convert.ToDecimal(txtTotal.Text),
                    //IdProducto = Convert.ToInt32(txtIdProducto.SelectedValue),
                    ////Cantidad = Convert.ToInt32(CmbCategoria.SelectedValue),
                    //PrecioUnitario = dtpFechaIngreso.Value, // Obtener la fecha desde un DateTimePicker
                    //Subtotal = dtpFechaCaducidad.Value,

                };

            }
        }
    }
}
