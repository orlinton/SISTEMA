using CapaDatos;
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
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
            VistaVentas();
            
        }

        private void VistaVentas()
        {

            // Asegúrate de que CD_Producto esté correctamente implementado
            CD_Venta objprod = new CD_Venta();
            // Verifica si hay datos en el DataGridView antes de asignar la nueva fuente de datos
            if (dataGridViewVenta.DataSource != null)
            {
                dataGridViewVenta.DataSource = null;
            }
            // Asigna la nueva fuente de datos
            dataGridViewVenta.DataSource = objprod.VistaVentas();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txthora.Text = DateTime.Now.ToString("hh:mm:ss");
            txtFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}
