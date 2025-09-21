
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
    public partial class frmGestionProductos : UserControl
    {
        public frmGestionProductos()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        Productos Productos = new Productos();
     
        private void frmGestionProductos_Load(object sender, EventArgs e)
        {
            VerDatagriv();
            ConfigurarDataGridView();
            MostrarComboBox();
        }

        private void VerDatagriv()
        {
            dgvVerProductos.DataSource = Productos.ObtenerProductos();
        }

        private void ConfigurarDataGridView()
        {
            // Ajustar tamaño
           dgvVerProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVerProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Quitar bordes
            dgvVerProductos.BorderStyle = BorderStyle.None;

            // Estilo de encabezados
            dgvVerProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvVerProductos.EnableHeadersVisualStyles = false;
            dgvVerProductos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255); // Azul moderno
            dgvVerProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVerProductos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            dgvVerProductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Filas alternadas
            dgvVerProductos.RowsDefaultCellStyle.BackColor = Color.White;
            dgvVerProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Gris claro

            // Fuente y colores de celdas
            dgvVerProductos.DefaultCellStyle.Font = new Font("Segoe UI", 8);
            dgvVerProductos.DefaultCellStyle.ForeColor = Color.Black;
            dgvVerProductos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 216, 230); // Azul claro
            dgvVerProductos.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvVerProductos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Quitar fila vacía
            dgvVerProductos.AllowUserToAddRows = false;

            // Deshabilitar edición (opcional)
            dgvVerProductos.ReadOnly = true;

            // Ajustar selección completa de fila
            dgvVerProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Quitar encabezado de filas
            dgvVerProductos.RowHeadersVisible = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodProducto.Clear();
            txtNombreProducto.Clear();
            txtStock.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
           cmbCategoria.SelectedIndex = -1;
            cbmProveedor.SelectedIndex = -1;

        }

        Proveedores Proveedores = new Proveedores();
        Categoria Categoria = new Categoria();
        private void MostrarComboBox()
        {
            cbmProveedor.DataSource = null;
            cbmProveedor.DataSource = Proveedores.ObtenerDatosProveedores();
            cbmProveedor.DisplayMember = "NombreProveedor";
            cbmProveedor.ValueMember = "idProveedor";
            cbmProveedor.SelectedIndex = -1;


            cmbCategoria.DataSource = null;
            cmbCategoria.DataSource = Categoria.ObtenerDatosCategoria();
            cmbCategoria.DisplayMember = "NombreCategoria";
            cmbCategoria.ValueMember = "idCategoria";
            cmbCategoria.SelectedIndex = -1;


        }

        Productos productos = new Productos();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
              productos.CodigoProducto = txtCodProducto.Text.Trim();
                productos.NombreProducto = txtNombreProducto.Text.Trim();
                productos.Categoria_id = Convert.ToInt32(cmbCategoria.SelectedValue);
                productos.Proveedor_id = Convert.ToInt32(cbmProveedor.SelectedValue);
                productos.Stock = int.Parse(txtStock.Text.Trim());
                productos.PrecioCompra = decimal.Parse(txtPrecioCompra.Text.Trim());
                productos.PrecioVenta = decimal.Parse(txtPrecioVenta.Text.Trim());

                productos.InsertarProducto();
                VerDatagriv();

                MessageBox.Show("Producto agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            try
            {




                productos.CodigoProducto = txtCodProducto.Text.Trim();
               productos.NombreProducto= txtNombreProducto.Text.Trim();
                productos.Categoria_id = Convert.ToInt32(cmbCategoria.SelectedValue);
                productos.Proveedor_id = Convert.ToInt32(cbmProveedor.SelectedValue);
                productos.Stock = int.Parse(txtStock.Text.Trim());
                productos.PrecioCompra = decimal.Parse(txtPrecioCompra.Text.Trim());
                productos.PrecioVenta = decimal.Parse(txtPrecioVenta.Text.Trim());
                   productos.IdProducto = int.Parse(dgvVerProductos.CurrentRow.Cells["idProducto"].Value.ToString());


                productos.ActualizarProducto();
                VerDatagriv();

                MessageBox.Show("Producto actualizado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvVerProductos_DoubleClick(object sender, EventArgs e)
        {
            txtCodProducto.Text = dgvVerProductos.CurrentRow.Cells["CodigoProducto"].Value.ToString();
            txtNombreProducto.Text = dgvVerProductos.CurrentRow.Cells["NombreProducto"].Value.ToString();
            cmbCategoria.SelectedValue = dgvVerProductos.CurrentRow.Cells["categoria_id"].Value;
            cbmProveedor.SelectedValue = dgvVerProductos.CurrentRow.Cells["Proveedor_id"].Value;
            txtStock.Text = dgvVerProductos.CurrentRow.Cells["Stock"].Value.ToString();
            txtPrecioCompra.Text = dgvVerProductos.CurrentRow.Cells["PrecioCompra"].Value.ToString();
            txtPrecioVenta.Text = dgvVerProductos.CurrentRow.Cells["PrecioVenta"].Value.ToString();

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvVerProductos.CurrentRow.Cells["idProducto"].Value);
                productos.EliminarProducto(id);

                
                VerDatagriv();
                MessageBox.Show("Producto eliminado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}