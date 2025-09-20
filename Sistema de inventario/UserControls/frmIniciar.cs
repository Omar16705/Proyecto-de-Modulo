using Modelos.Entidades;
using Sistema_de_inventario.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_inventario.UserControls
{
    public partial class frmIniciar : UserControl
    {
        public frmIniciar()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear instancia de usuario
                Usuario usuarioLogin = new Usuario
                {
                    NombreCompletoUsuario1 = txtUsuario.Text.Trim(),
                    Clave1 = txtClave.Text.Trim() // Contraseña en texto plano para verificación
                };

                // Intentar login
                bool accesoValido = usuarioLogin.Ingresar();

                if (accesoValido)
                {
                    // Login exitoso
                    
                    MessageBox.Show("Bienvenido al Sistema", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    // Aquí puedes redirigir a la pantalla principal
                    frmDashboard dashboard = new frmDashboard();
                    dashboard.Show();
                }
                else
                {
                    // Login fallido
                    MessageBox.Show("Usuario o contraseña incorrectos",
                                   "Error de inicio de sesión",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);

                    // Limpiar campo de contraseña
                    txtUsuario.Text = "";
                    txtUsuario.Focus();
                    txtClave.Text = "";
                    txtClave.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }
    }
}
