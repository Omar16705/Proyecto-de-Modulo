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
    public partial class frmGestionInventario : UserControl
    {
        public frmGestionInventario()
        {
            InitializeComponent();
        }

        private void frmGestionInventario_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            MostrarDatosEnDataGridView();
        }


        Productos productos = new Productos();

        private void MostrarDatosEnDataGridView()
        {
            dgvGestionInventario.DataSource = productos.ObtenerProductos();
        }


        private void ConfigurarDataGridView()
        {
            // Ajustar tamaño
           dgvGestionInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGestionInventario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvGestionInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;


            // Quitar bordes
            dgvGestionInventario.BorderStyle = BorderStyle.None;

            // Estilo de encabezados
            dgvGestionInventario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvGestionInventario.EnableHeadersVisualStyles = false;
            dgvGestionInventario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255); // Azul moderno
            dgvGestionInventario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvGestionInventario.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            dgvGestionInventario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGestionInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;


            // Filas alternadas
            dgvGestionInventario.RowsDefaultCellStyle.BackColor = Color.White;
            dgvGestionInventario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Gris claro

            // Fuente y colores de celdas
            dgvGestionInventario.DefaultCellStyle.Font = new Font("Segoe UI", 8);
            dgvGestionInventario.DefaultCellStyle.ForeColor = Color.Black;
            dgvGestionInventario.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 216, 230); // Azul claro
            dgvGestionInventario.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvGestionInventario.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Quitar fila vacía
            dgvGestionInventario.AllowUserToAddRows = false;

            // Deshabilitar edición (opcional)
            dgvGestionInventario.ReadOnly = true;

            // Ajustar selección completa de fila
            dgvGestionInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Quitar encabezado de filas
            dgvGestionInventario    .RowHeadersVisible = false;
        }

    }
}
