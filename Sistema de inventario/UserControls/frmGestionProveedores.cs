
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
    public partial class frmGestionProveedores : UserControl
    {
        public frmGestionProveedores()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConfigurarDataGridView()
        {
            // Ajustar tamaño
           dgvVerProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVerProveedores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Quitar bordes
            dgvVerProveedores.BorderStyle = BorderStyle.None;

            // Estilo de encabezados
            dgvVerProveedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvVerProveedores.EnableHeadersVisualStyles = false;
            dgvVerProveedores.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255); // Azul moderno
            dgvVerProveedores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVerProveedores.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
           dgvVerProveedores.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Filas alternadas
            dgvVerProveedores.RowsDefaultCellStyle.BackColor = Color.White;
            dgvVerProveedores.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Gris claro

            // Fuente y colores de celdas
            dgvVerProveedores.DefaultCellStyle.Font = new Font("Segoe UI", 8);
            dgvVerProveedores.DefaultCellStyle.ForeColor = Color.Black;
            dgvVerProveedores.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 216, 230); // Azul claro
           dgvVerProveedores.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvVerProveedores.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Quitar fila vacía
            dgvVerProveedores.AllowUserToAddRows = false;

            // Deshabilitar edición (opcional)
            dgvVerProveedores.ReadOnly = true;

            // Ajustar selección completa de fila
            dgvVerProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Quitar encabezado de filas
            dgvVerProveedores.RowHeadersVisible = false;
        }

        private void frmGestionProveedores_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            VerDatafrid();
        }

      Proveedores Proveedores = new Proveedores();

        private void VerDatafrid()
        {
            dgvVerProveedores.DataSource = null;
            dgvVerProveedores.DataSource = Proveedores.VerProveedores();
        }

        Proveedores proveedores = new Proveedores();

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
               proveedores.DocumentoProveedor = txtDocumentoProveedor.Text;
                proveedores.NombreProveedor = txtNombreProveedor.Text;
                proveedores.CorreoProveedor = txtEmailProveedor.Text;
                proveedores.TelefonoProveedor = txtTelefonoProveedor.Text;


                proveedores.InsertarProveedor();
                VerDatafrid();
                MessageBox.Show("Proveedor agregado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTelefonoProveedor.Clear();
            txtEmailProveedor.Clear();
            txtNombreProveedor.Clear();
            txtDocumentoProveedor.Clear();

        }

        private void dgvVerProveedores_DoubleClick(object sender, EventArgs e)
        {
            txtNombreProveedor.Text = dgvVerProveedores.CurrentRow.Cells["NombreProveedor"].Value.ToString();
            txtDocumentoProveedor.Text = dgvVerProveedores.CurrentRow.Cells["DocumentoProveedor"].Value.ToString();
            txtEmailProveedor.Text = dgvVerProveedores.CurrentRow.Cells["CorreoProveedor"].Value.ToString();
            txtTelefonoProveedor.Text = dgvVerProveedores.CurrentRow.Cells["TelefonoProveedor"].Value.ToString();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                proveedores.DocumentoProveedor = txtDocumentoProveedor.Text;
                proveedores.NombreProveedor = txtNombreProveedor.Text;
                proveedores.CorreoProveedor = txtEmailProveedor.Text;
                proveedores.TelefonoProveedor = txtTelefonoProveedor.Text;
                proveedores.IdProveedor = Convert.ToInt32(dgvVerProveedores.CurrentRow.Cells["idProveedor"].Value);
                proveedores.ActualizarProveedor();
                VerDatafrid();
                MessageBox.Show("Proveedor actualizado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvVerProveedores.CurrentRow.Cells["idProveedor"].Value);
                proveedores.EliminarProveedor(id);


                VerDatafrid();
                MessageBox.Show("Proveedor eliminado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
