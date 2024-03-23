using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using System;
using System.Data;
using System.Data.SqlClient;
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
                            txtCantidadProducto.Text = cantidadProducto.ToString();
                        }
                        else
                        {
                            // Limpiar los campos de texto si no se encuentra el producto
                            txtIdProducto.Text = string.Empty;
                            txtproducto.Text = string.Empty;
                            txtCantidadProducto.Text = string.Empty;
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
            if (!string.IsNullOrWhiteSpace(txtCantidadVenta.Text) && !string.IsNullOrWhiteSpace(txtPrecioVenta.Text))
            {
                // Obtener la cantidad y el precio
                int cantidad = Convert.ToInt32(txtCantidadVenta.Text);
                decimal precio = Convert.ToDecimal(txtPrecioVenta.Text);

                // Calcular el total
                decimal total = cantidad * precio;

                // Mostrar el total en el campo txtTotal
                txtSubtotal.Text = total.ToString();
            }
            else
            {
                // Limpiar el campo txtTotal si falta alguno de los valores
                txtcomprovante.Text = string.Empty;
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

       

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos del formulario
                int idCliente = Convert.ToInt32(cmbCliente.SelectedValue);
                int idEmpleado = int.Parse(txtEmpleado.Text);
                DateTime fecha = DateTime.Now; // Se utiliza la fecha actual
                string tipoComprobante = txtcomprovante.Text;
                decimal iva = 0.16m; // Supongamos que el IVA es fijo en 16%
                int idProducto = int.Parse(txtIdProducto.Text);
                int cantidad = int.Parse(txtCantidadVenta.Text);
                decimal precioVenta = ObtenerPrecioProducto(idProducto); // Método para obtener el precio del producto
                decimal descuento = int.Parse(txtdescuento.Text); ; // No hay descuento por defecto

                // Crear objeto CE_Venta con los datos obtenidos
                CE_Venta venta = new CE_Venta()
                {
                    IdCliente = idCliente,
                    IdEmpleado = idEmpleado,
                    Fecha = fecha,
                    TipoComprobante = tipoComprobante,
                    Iva = iva,
                    IdProducto = idProducto,
                    Cantidad = cantidad,
                    PrecioVenta = precioVenta,
                    Descuento = descuento
                };

                // Insertar la venta completa utilizando la capa de negocio
                CN_Venta capaNegocioVenta = new CN_Venta();
                capaNegocioVenta.InsertarVentaCompleta(venta);

                // Mostrar mensaje de éxito
                MessageBox.Show("Venta creada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show("Error al crear venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para obtener el precio del producto (debes implementarlo según la lógica de tu aplicación)
        private decimal ObtenerPrecioProducto(int idProducto)
        {
            // Aquí debes implementar la lógica para obtener el precio del producto según su ID
            // Por ejemplo, podrías llamar a un método en la capa de datos para obtener el precio desde la base de datos
            // Por simplicidad, aquí solo se devuelve un valor fijo de 100 para fines de demostración
            return 100;
        }
    }
}

