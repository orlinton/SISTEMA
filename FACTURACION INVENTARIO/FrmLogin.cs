using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio; // Importa el espacio de nombres de la capa de negocio



namespace FACTURACION_INVENTARIO
{
    public partial class FrmLogin : Form
    {
        private CN_Usuario cnUsuario; // Instancia de la clase de negocio para usuarios
       

        public FrmLogin()
        {
            InitializeComponent();
            cnUsuario = new CN_Usuario(); // Inicializa la instancia de la clase de negocio

        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            bool autenticado = cnUsuario.AutenticarUsuario(nombreUsuario, contraseña);

            if (autenticado)
            {
                MessageBox.Show("Inicio de sesión exitoso.", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Obtener el ID de rol del usuario autenticado
                int idRol = cnUsuario.ObtenerIdRol(nombreUsuario);

                // Abre el formulario principal y pasa el ID de rol y el nombre de usuario como parámetros
                FrmPrincipal frmPrincipal = new FrmPrincipal(idRol, nombreUsuario);
                frmPrincipal.ShowDialog();

                // Oculta el formulario de inicio de sesión después de abrir el formulario principal
                this.Hide();
            }
            else
            {
                MessageBox.Show("Inicio de sesión fallido. Nombre de usuario o contraseña incorrectos.", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
