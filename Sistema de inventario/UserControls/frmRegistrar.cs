using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            try
            {
                // Validar campos obligatorios
                if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
                {
                    MessageBox.Show("El nombre completo es obligatorio.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCorreoElectronico.Text))
                {
                    MessageBox.Show("El correo electrónico es obligatorio.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtClave.Text))
                {
                    MessageBox.Show("La clave es obligatoria.");
                    return;
                }

                if (cmbRol.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un rol.");
                    return;
                }

                // Validar formato de correo
                if (!Regex.IsMatch(txtCorreoElectronico.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("El correo electrónico no tiene un formato válido.");
                    return;
                }

                // Validar longitud de clave
                if (txtClave.Text.Length < 8)
                {
                    MessageBox.Show("La clave debe tener al menos 8 caracteres.");
                    return;
                }

                // Crear y asignar usuario
                Usuario usuario = new Usuario();
                usuario.NombreCompletoUsuario1 = txtNombreUsuario.Text.Trim();
                usuario.CorrreoElectronico1 = txtCorreoElectronico.Text.Trim();
                usuario.Clave1 = BCrypt.Net.BCrypt.HashPassword(txtClave.Text);
                usuario.IdRol1 = Convert.ToInt32(cmbRol.SelectedValue);

                usuario.InsertarUsuario();
                VerUsuarios();

                MessageBox.Show("Usuario registrado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {
            MostrarRol();
            ConfigurarDataGridView();
            VerUsuarios();
        }


        private void VerUsuarios()
        {

            dgvVerUsuarios.DataSource = Usuario.MostrarUsuarios().Tables["USUARIOS"];
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


        private void ConfigurarDataGridView()
        {
            // Ajustar tamaño
            dgvVerUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVerUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Quitar bordes
            dgvVerUsuarios.BorderStyle = BorderStyle.None;

            // Estilo de encabezados
            dgvVerUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvVerUsuarios.EnableHeadersVisualStyles = false;
            dgvVerUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255); // Azul moderno
            dgvVerUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVerUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            dgvVerUsuarios.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Filas alternadas
            dgvVerUsuarios.RowsDefaultCellStyle.BackColor = Color.White;
            dgvVerUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Gris claro

            // Fuente y colores de celdas
            dgvVerUsuarios.DefaultCellStyle.Font = new Font("Segoe UI", 8);
            dgvVerUsuarios.DefaultCellStyle.ForeColor = Color.Black;
            dgvVerUsuarios.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 216, 230); // Azul claro
            dgvVerUsuarios.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvVerUsuarios.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Quitar fila vacía
            dgvVerUsuarios.AllowUserToAddRows = false;

            // Deshabilitar edición (opcional)
            dgvVerUsuarios.ReadOnly = true;

            // Ajustar selección completa de fila
            dgvVerUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Quitar encabezado de filas
            dgvVerUsuarios.RowHeadersVisible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEliminarUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que hay una fila seleccionada
                if (dgvVerUsuarios.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar un usuario para eliminar.");
                    return;
                }

                // Validar que la celda contiene un valor válido
                var cellValue = dgvVerUsuarios.CurrentRow.Cells["IdUsuario"].Value;
                if (cellValue == null || string.IsNullOrWhiteSpace(cellValue.ToString()))
                {
                    MessageBox.Show("El usuario seleccionado no tiene un ID válido.");
                    return;
                }

                // Validar que el ID es un número entero
                if (!int.TryParse(cellValue.ToString(), out int idUsuario))
                {
                    MessageBox.Show("El ID del usuario no es válido.");
                    return;
                }

                // Confirmación opcional
                var confirm = MessageBox.Show("¿Está seguro que desea eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes)
                {
                    return;
                }

                // Eliminar usuario
                Usuario usuario = new Usuario();
                usuario.IdUsuario1 = idUsuario;
                usuario.EliminarUsuario();
                VerUsuarios();

                MessageBox.Show("Usuario eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnActuali_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos obligatorios
                if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
                {
                    MessageBox.Show("El nombre completo es obligatorio.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCorreoElectronico.Text))
                {
                    MessageBox.Show("El correo electrónico es obligatorio.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtClave.Text))
                {
                    MessageBox.Show("La clave es obligatoria.");
                    return;
                }

                if (cmbRol.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un rol.");
                    return;
                }

                // Validar formato de correo
                if (!Regex.IsMatch(txtCorreoElectronico.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("El correo electrónico no tiene un formato válido.");
                    return;
                }

                // Validar longitud de clave
                if (txtClave.Text.Length < 6)
                {
                    MessageBox.Show("La clave debe tener al menos 6 caracteres.");
                    return;
                }

                // Crear y asignar usuario
                Usuario usuario = new Usuario();
                usuario.NombreCompletoUsuario1 = txtNombreUsuario.Text.Trim();
                usuario.CorrreoElectronico1 = txtCorreoElectronico.Text.Trim();
                usuario.Clave1 = BCrypt.Net.BCrypt.HashPassword(txtClave.Text);
                usuario.IdRol1 = Convert.ToInt32(cmbRol.SelectedValue);

                usuario.ActualizarUsuario();
                VerUsuarios();

                MessageBox.Show("Usuario registrado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtClave.Clear();
            txtCorreoElectronico.Clear();
            txtNombreUsuario.Clear();
            cmbRol.SelectedIndex = -1;
            txtNombreUsuario.Focus();
            txtCorreoElectronico.Focus();

        }

        private void dgvVerUsuarios_DoubleClick(object sender, EventArgs e)
        {
            txtNombreUsuario.Text = dgvVerUsuarios.CurrentRow.Cells["NombreCompletoUsuario"].Value.ToString();
            txtCorreoElectronico.Text = dgvVerUsuarios.CurrentRow.Cells["correoUsuario"].Value.ToString();
            cmbRol.SelectedValue = dgvVerUsuarios.CurrentRow.Cells["rol_id"].Value;
        }
    }
}
