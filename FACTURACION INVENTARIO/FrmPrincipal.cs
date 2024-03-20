using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FACTURACION_INVENTARIO
{
    public partial class FrmPrincipal : Form
    {
      

        public FrmPrincipal(int idRol, string nombreUsuario)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario: " + nombreUsuario;
            this.WindowState = FormWindowState.Maximized;

            // Deshabilitar los botones según el ID de rol
            if (idRol == 2) // Si el ID de rol es 2 (por ejemplo, un usuario normal)
            {
                btnCliente.Enabled = false;
                btnProveedores.Enabled = false;
                btnEmpleado.Enabled = false;
               
                btnCategoria.Enabled = false;
                btnReportes.Enabled = false;              
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }



        private void PanelHijo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            AbrirFormInpanel(frmProducto, PanelHijo);
        }

        private void AbrirFormInpanel(Form formulario, Panel panel)
        {
            if (panel.Controls.Count > 0)
                panel.Controls.RemoveAt(0);

            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            panel.Controls.Add(formulario);
            panel.Tag = formulario;
            formulario.Show();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, int wParam, int lParam);

        private void PanelHijo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = true;
        }

        private void btnrptventa_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void btnrptcompra_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void btnrptinventario_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsalir2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            FrmVenta frmVenta = new FrmVenta();
            AbrirFormInpanel(frmVenta, PanelHijo);
        }



        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmInventario frmInventario = new FrmInventario();
            AbrirFormInpanel(frmInventario, PanelHijo);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            AbrirFormInpanel(frmCliente, PanelHijo);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores frmproveedores = new FrmProveedores();
            AbrirFormInpanel(frmproveedores, PanelHijo);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            FrmEmpleado frmEmpleado = new FrmEmpleado();
            AbrirFormInpanel(frmEmpleado, PanelHijo);
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoria frmCategoria = new FrmCategoria();
            AbrirFormInpanel(frmCategoria, PanelHijo);
        }
    }
}