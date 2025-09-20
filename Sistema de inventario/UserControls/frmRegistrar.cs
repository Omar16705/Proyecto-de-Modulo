using Modelos.Entidades;
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
    public partial class frmRegistrar : UserControl
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.NombreCompletoUsuario1 = txtNombreUsuario.Text;
            usuario.CorrreoElectronico1 = txtCorreoElectronico.Text;
            usuario.Clave1 = BCrypt.Net.BCrypt.HashPassword(txtClave.Text);
            usuario.IdRol1 = Convert.ToInt32(cmbRol.SelectedValue);
            usuario.InsertarUsuario();
        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {
            MostrarRol();
        }

        private void MostrarRol()
        {
            var dato = Roles_Usuario.ObtenerDatosRoles();
            ////// para mostrar en el combox los nombres de los roles 
            cmbRol.DataSource = dato["ROL"];
            cmbRol.DisplayMember = "NombreRol";
            cmbRol.ValueMember = "idRol";
            cmbRol.SelectedIndex = -1;
        }
    }
}
