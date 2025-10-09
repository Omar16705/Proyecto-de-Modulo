using Modelos.Entidades;
using Sistema_de_inventario.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_inventario.Formularios
{
    public partial class frmLogin : Form
    {
       public static frmLogin InstanciaLogin;

        public frmLogin()
        {
            InitializeComponent();
            InstanciaLogin = this;
        }

        private void pnlRegistraroIniciarSesion_Paint(object sender, PaintEventArgs e)
        {

        }



                      frmRegistrar frmRegistrar = new frmRegistrar();
                    

        private void Login_Load(object sender, EventArgs e)
        {
           
        }


        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {
            try
            {


                if (string.IsNullOrWhiteSpace(txtClave.Text) || (string.IsNullOrWhiteSpace(txtUsuario.Text)))
                {
                    MessageBox.Show("Ingresa tus credenciales en los campos asignados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                if (string.IsNullOrWhiteSpace(txtUsuario.Text)) {

                    MessageBox.Show("Ingresa el usuario en el campo asignado","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
                }


                if (string.IsNullOrWhiteSpace(txtClave.Text)) {


                    MessageBox.Show("Ingresa la clave en el campo asignado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


              



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

                    MessageBox.Show("Bienvenido al Sistema: " + usuarioLogin.NombreCompletoUsuario1, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbkOlvisdastetuPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRestablecerClave frmRestablecerClave = new frmRestablecerClave();
            frmRestablecerClave.ShowDialog();
        }

        private void btnVerClave_MouseUp(object sender, MouseEventArgs e)
        {
            txtClave.PasswordChar = '*';
        }

        private void btnVerClave_MouseDown(object sender, MouseEventArgs e)
        {
            txtClave.PasswordChar = '\0';
        }
    }
}
