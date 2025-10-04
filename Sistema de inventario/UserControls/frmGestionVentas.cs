using Modelos.Conexion_DB;
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
    public partial class frmGestionVentas : UserControl
    {
        public frmGestionVentas()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtMontoCambio.Clear();
            txtMontoTotal.Clear();
            txtMontoPago.Clear();
            cmbTipoDocumento.SelectedIndex = -1;
            cmbUsuario.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;
        }


        private void MostrarInformacionCMB()
        {
            cmbUsuario.DataSource = null;
            cmbUsuario.DataSource = Usuario.mostrarusurioscmb();
            cmbUsuario.DisplayMember = "NombreCompletoUsuario";
            cmbUsuario.ValueMember = "IdUsuario";
            cmbUsuario.SelectedIndex = -1;



            cmbProducto.DataSource = null;
            cmbProducto.DataSource = Productos.MostrarProductosCMB();
            cmbProducto.DisplayMember = "NombreProducto";
            cmbProducto.ValueMember = "idProducto";
            cmbProducto.SelectedIndex = -1;


            cmbTipoDocumento.DataSource = null;
            cmbTipoDocumento.DataSource = TipoDocumento.mostrarTipoDocumento();
            cmbTipoDocumento.DisplayMember = "nombreTipoDocumentoVenta";
            cmbTipoDocumento.ValueMember = "idTipoDocumentoVenta";
            cmbTipoDocumento.SelectedIndex = -1;


        }



        public void MostrarInformacionDGV()
        {
           dgvVerGestionVentas.DataSource = null;
            dgvVerGestionVentas.DataSource = Ventas.MostrarVentas();
        }


        private void frmGestionVentas_Leave(object sender, EventArgs e)
        {

        }

        private void frmGestionVentas_Load(object sender, EventArgs e)
        {
            MostrarInformacionCMB();
            MostrarInformacionDGV();
            ConfigurarDataGridView();
        }



        private void ConfigurarDataGridView()
        {
            // Ajustar tamaño
            dgvVerGestionVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           dgvVerGestionVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVerGestionVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;


            // Quitar bordes
            dgvVerGestionVentas.BorderStyle = BorderStyle.None;

            // Estilo de encabezados
            dgvVerGestionVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvVerGestionVentas.EnableHeadersVisualStyles = false;
            dgvVerGestionVentas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255); // Azul moderno
            dgvVerGestionVentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVerGestionVentas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            dgvVerGestionVentas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVerGestionVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         

            // Filas alternadas
            dgvVerGestionVentas.RowsDefaultCellStyle.BackColor = Color.White;
            dgvVerGestionVentas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Gris claro

            // Fuente y colores de celdas
            dgvVerGestionVentas.DefaultCellStyle.Font = new Font("Segoe UI", 8);
            dgvVerGestionVentas.DefaultCellStyle.ForeColor = Color.Black;
            dgvVerGestionVentas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 216, 230); // Azul claro
            dgvVerGestionVentas.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvVerGestionVentas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Quitar fila vacía
            dgvVerGestionVentas.AllowUserToAddRows = false;

            // Deshabilitar edición (opcional)
            dgvVerGestionVentas.ReadOnly = true;

            // Ajustar selección completa de fila
            dgvVerGestionVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Quitar encabezado de filas
            dgvVerGestionVentas.RowHeadersVisible = false;
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtMontoPago.Text) || string.IsNullOrWhiteSpace(txtMontoCambio.Text) || string.IsNullOrWhiteSpace(txtMontoTotal.Text) || cmbProducto.SelectedIndex == -1 || cmbTipoDocumento.SelectedIndex == -1 || cmbUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.","Ingrese todos los campos", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }





            Ventas nuevaVenta = new Ventas();
            nuevaVenta.Usuario_id = Convert.ToInt32(cmbUsuario.SelectedValue.ToString());
            nuevaVenta.Producto_id = Convert.ToInt32(cmbProducto.SelectedValue.ToString());
            nuevaVenta.TipoDocumento_id = Convert.ToInt32(cmbTipoDocumento.SelectedValue.ToString());
            nuevaVenta.Cantidad = int.Parse(txtCantidad.Text);
            nuevaVenta.MontoPago = decimal.Parse(txtMontoPago.Text);
            nuevaVenta.MontoCambio = decimal.Parse(txtMontoCambio.Text);
            nuevaVenta.MontoTotal = decimal.Parse(txtMontoTotal.Text);
            nuevaVenta.InsertarVenta(nuevaVenta);
            MostrarInformacionDGV();
            MessageBox.Show("Venta agregada con éxito");



        }

        private void dgvVerGestionVentas_DoubleClick(object sender, EventArgs e)
        {
           cmbUsuario.SelectedValue = dgvVerGestionVentas.CurrentRow.Cells["usuario_id"].Value.ToString();
            cmbProducto.SelectedValue = dgvVerGestionVentas.CurrentRow.Cells["producto_id"].Value.ToString();
            cmbTipoDocumento.SelectedValue = dgvVerGestionVentas.CurrentRow.Cells["tipoDocumentoVenta_id"].Value.ToString();
            txtCantidad.Text = dgvVerGestionVentas.CurrentRow.Cells["Cantidad"].Value.ToString();
            txtMontoPago.Text = dgvVerGestionVentas.CurrentRow.Cells["MontoPago"].Value.ToString();
            txtMontoCambio.Text = dgvVerGestionVentas.CurrentRow.Cells["MontoCambio"].Value.ToString();
            txtMontoTotal.Text = dgvVerGestionVentas.CurrentRow.Cells["MontoTotal"].Value.ToString();

        }

        private void btnActualizarVenta_Click(object sender, EventArgs e)
        {
            Ventas nuevaVenta = new Ventas();
            nuevaVenta.Usuario_id = Convert.ToInt32(cmbUsuario.SelectedValue.ToString());
            nuevaVenta.Producto_id = Convert.ToInt32(cmbProducto.SelectedValue.ToString());
            nuevaVenta.TipoDocumento_id = Convert.ToInt32(cmbTipoDocumento.SelectedValue.ToString());
            nuevaVenta.Cantidad = int.Parse(txtCantidad.Text);
            nuevaVenta.MontoPago = decimal.Parse(txtMontoPago.Text);
            nuevaVenta.MontoCambio = decimal.Parse(txtMontoCambio.Text);
            nuevaVenta.MontoTotal = decimal.Parse(txtMontoTotal.Text);
            nuevaVenta.IdVenta = int.Parse(dgvVerGestionVentas.CurrentRow.Cells["idVenta"].Value.ToString());
            nuevaVenta.ActualizarVenta(nuevaVenta);
            MostrarInformacionDGV();
            MessageBox.Show("Venta actualizada con éxito");

        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            int id = int.Parse(dgvVerGestionVentas.CurrentRow.Cells["idVenta"].Value.ToString());
            ventas.EliminarVenta(id);
            MostrarInformacionDGV();
        }
    }
}
