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

namespace Sistema_de_inventario.Formularios
{
    public partial class frmRestablecerClave : Form
    {
        public frmRestablecerClave()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNombreUsuario.Text) || string.IsNullOrWhiteSpace( txtNuevaClave.Text) || string.IsNullOrWhiteSpace(txtConfirmarClave.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNuevaClave.Text))
            {
                MessageBox.Show("Las contraseñas no puede quedar vacia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtConfirmarClave.Text))
            {
                MessageBox.Show("Confirma la nueva clave.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            Usuario usuario = new Usuario();
            string nameusuario = txtNombreUsuario.Text.Trim();
            string nuevaPass = txtNuevaClave.Text;
            string confirmarPass = txtConfirmarClave.Text;

            if (string.IsNullOrWhiteSpace(nameusuario))
            {
                MessageBox.Show("Ingrese el nombre de usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(nuevaPass) || string.IsNullOrEmpty(confirmarPass))
            {
                MessageBox.Show("Las contraseñas no pueden estar vacías.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nuevaPass != confirmarPass)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string password = txtNuevaClave.Text;
            if (password.Length < 8 ||
                !password.Any(char.IsUpper) ||
                !password.Any(char.IsDigit) ||
                !password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres, una mayúscula, un número y un carácter especial.");
                return;
            }

            //Verificamos si el usuario existe o no, si existe esto se pasa a actualizar la contra xddd
            if (!usuario.UsuarioExiste(nameusuario))
            {
                MessageBox.Show("El usuario no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ///aqui ya se pasa a actualizar 
            bool actualizado = usuario.RestablecerPassword(nameusuario, nuevaPass);

            if (actualizado)
            {
                MessageBox.Show("La contraseña ha sido restablecida correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar la contraseña. Verifica los registros y la conexión con la base de datos cxd.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
