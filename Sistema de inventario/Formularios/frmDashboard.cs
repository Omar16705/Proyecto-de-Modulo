using Modelos.Entidades;
using Sistema_de_inventario.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_inventario.Formularios
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            NivelUsuario();
        }



        #region "Metodo para pintar fomrularios"

        private Form activarForm = null;

        //Creando el metodo que me va  a permitir activar los formularios

        private void AbrirForms(Form formularioPintar)
        {
            if (activarForm != null)
            {
                activarForm.Close();
            }
            //

            activarForm = formularioPintar;

            formularioPintar.TopLevel = false;
            formularioPintar.FormBorderStyle = FormBorderStyle.None;

            formularioPintar.Dock = DockStyle.Fill;

            pnlCentral.Controls.Add(formularioPintar);
            formularioPintar.BringToFront();
            formularioPintar.Show();


        }


        #endregion

        private void NivelUsuario() {
        

           switch(VerificarUsuario.Rol)
            {
                case "Administrador":
                    // Admin
                   lblUserConnet.Text = VerificarUsuario.Nombre_usuario;
                    lblNivelUsuario.Text = VerificarUsuario.Rol;
                    break;
                case "Vendedor":
                    // Vendedor
                    btnGestionUsuarios.Visible = false;
                    btnGestionProveedores.Visible = false;
                    btnGestionProductos.Visible = false;
                    lblUserConnet.Text = VerificarUsuario.Nombre_usuario;
                    lblNivelUsuario.Text = VerificarUsuario.Rol;

                    break;
                    case "Almacenista":
                    // Almacenista
                    btnGestionUsuarios.Visible = false;
                    btnGestionProveedores.Visible = false;
                    btnGestionVentas.Visible = false;
                    lblUserConnet.Text = VerificarUsuario.Nombre_usuario;
                    lblNivelUsuario.Text = VerificarUsuario.Rol;
                    break;

            }
        }

        private void btnGestionProductos_Click(object sender, EventArgs e)
        {
            AbrirForms(new frmGestionProductos());
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnlCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGestionProveedores_Click(object sender, EventArgs e)
        {
            AbrirForms(new frmGestionProveedores());
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            AbrirForms(new frmRegistrar());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult opcionSeleccionada = MessageBox.Show("¿Quieres salir?", "Cerrando Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcionSeleccionada == DialogResult.Yes)
            {
                this.Close(); // Cerramos el dashboard
                frmLogin.InstanciaLogin.Show(); // Mostramos el formulario de login




            }
        }

        private void btnGestionVentas_Click(object sender, EventArgs e)
        {
            AbrirForms(new frmGestionVentas());
        }

        private void btnGestionInventario_Click(object sender, EventArgs e)
        {
            AbrirForms(new frmGestionInventario());
        }

        private void frmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Cierra toda la aplicación al cerrar el dashboard
        }

        private void frmDashboard_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                AjustarPanelesPantallaCompleta();
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                RestaurarPaneles();
            }
        }

        private void AjustarPanelesPantallaCompleta()
        {
            // El pnlCentral ya tiene DockStyle.Fill, debería ajustarse automáticamente, pero asegurémonos de que los formularios hijos también se ajusten
            if (pnlCentral.Controls.Count > 0)
            {
                foreach (Control control in pnlCentral.Controls)
                {
                    if (control is Form formHijo)
                    {
                        formHijo.WindowState = FormWindowState.Maximized;
                        formHijo.Dock = DockStyle.Fill;
                    }
                }
            }
        }

        private void RestaurarPaneles()
        {
            if (pnlCentral.Controls.Count > 0)
            {
                foreach (Control control in pnlCentral.Controls)
                {
                    if (control is Form formHijo)
                    {
                        formHijo.WindowState = FormWindowState.Normal;
                        formHijo.Dock = DockStyle.Fill;
                    }
                }
            }
        }
    }
}
