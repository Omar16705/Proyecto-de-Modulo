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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
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
            pnlCentral.Controls.Clear();
           pnlCentral.Controls.Add(new frmGestionProductos());  
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnlCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGestionProveedores_Click(object sender, EventArgs e)
        {
            pnlCentral.Controls.Clear();
            pnlCentral.Controls.Add(new frmGestionProveedores());
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            pnlCentral.Controls.Clear();
            pnlCentral.Controls.Add(new frmRegistrar());
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
            pnlCentral.Controls.Clear();    
            pnlCentral.Controls.Add(new frmGestionVentas());
        }

        private void btnGestionInventario_Click(object sender, EventArgs e)
        {
            pnlCentral.Controls.Clear();
            pnlCentral.Controls.Add(new frmGestionInventario());
        }
    }
}
