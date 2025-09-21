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
            VerUsuarios();
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
            Usuario usuario = new Usuario();
            usuario.IdUsuario1 = Convert.ToInt32(dgvVerUsuarios.CurrentRow.Cells["IdUsuario"].Value);
            usuario.EliminarUsuario();
            VerUsuarios();

        }

        private void btnActuali_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.NombreCompletoUsuario1 = txtNombreUsuario.Text;
            usuario.CorrreoElectronico1 = txtCorreoElectronico.Text;
            usuario.Clave1 = BCrypt.Net.BCrypt.HashPassword(txtClave.Text);
            usuario.IdRol1 = Convert.ToInt32(cmbRol.SelectedValue);
            usuario.IdUsuario1 = int.Parse(dgvVerUsuarios.CurrentRow.Cells["IdUsuario"].Value.ToString());
            usuario.ActualizarUsuario();
            VerUsuarios();
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
            cmbRol.SelectedValue = dgvVerUsuarios.CurrentRow.Cells["idRol"].Value;
        }
    }
}
