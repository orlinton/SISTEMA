using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            Timer timer = new Timer();
            timer.Interval = 1000; // 1000 ms = 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
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
            txtFecha.Text = DateTime.Now.ToShortDateString();

        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            txthora.Text = DateTime.Now.ToString("HH:mm:ss");

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
        {// Obtener el código del producto a buscar del TextBox
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
                            string nombreProducto = table.Rows[0]["nombre"].ToString();
                            string cantidadProducto = table.Rows[0]["cantidad"].ToString();

                            // Asignar los valores al TextBox correspondiente
                            txtproducto.Text = nombreProducto;
                            txtCantidad.Text = cantidadProducto;
                        }
                        else
                        {
                            // Limpiar los campos de texto si no se encuentra el producto
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
        
    }
}
