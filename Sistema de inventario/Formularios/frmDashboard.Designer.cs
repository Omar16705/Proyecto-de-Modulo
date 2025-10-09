namespace Sistema_de_inventario.Formularios
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlNavegacion = new System.Windows.Forms.Panel();
            this.btnGestionInventario = new System.Windows.Forms.Button();
            this.btnGestionVentas = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.btnGestionProveedores = new System.Windows.Forms.Button();
            this.btnGestionProductos = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblUserConnet = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.lblNivelUsuario = new System.Windows.Forms.ToolStripLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlNavegacion.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(724, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // pnlNavegacion
            // 
            this.pnlNavegacion.AutoScroll = true;
            this.pnlNavegacion.AutoScrollMargin = new System.Drawing.Size(2, 2);
            this.pnlNavegacion.AutoScrollMinSize = new System.Drawing.Size(0, 550);
            this.pnlNavegacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(77)))), ((int)(((byte)(86)))));
            this.pnlNavegacion.Controls.Add(this.btnGestionInventario);
            this.pnlNavegacion.Controls.Add(this.btnGestionVentas);
            this.pnlNavegacion.Controls.Add(this.btnCerrarSesion);
            this.pnlNavegacion.Controls.Add(this.btnGestionUsuarios);
            this.pnlNavegacion.Controls.Add(this.btnGestionProveedores);
            this.pnlNavegacion.Controls.Add(this.btnGestionProductos);
            this.pnlNavegacion.Controls.Add(this.pnlLogo);
            this.pnlNavegacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavegacion.Location = new System.Drawing.Point(0, 0);
            this.pnlNavegacion.Name = "pnlNavegacion";
            this.pnlNavegacion.Size = new System.Drawing.Size(254, 561);
            this.pnlNavegacion.TabIndex = 1;
            // 
            // btnGestionInventario
            // 
            this.btnGestionInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionInventario.FlatAppearance.BorderSize = 0;
            this.btnGestionInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionInventario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionInventario.Location = new System.Drawing.Point(0, 422);
            this.btnGestionInventario.Name = "btnGestionInventario";
            this.btnGestionInventario.Size = new System.Drawing.Size(237, 54);
            this.btnGestionInventario.TabIndex = 7;
            this.btnGestionInventario.Text = "Gestion de Inventario";
            this.btnGestionInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionInventario.UseVisualStyleBackColor = true;
            this.btnGestionInventario.Click += new System.EventHandler(this.btnGestionInventario_Click);
            // 
            // btnGestionVentas
            // 
            this.btnGestionVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionVentas.FlatAppearance.BorderSize = 0;
            this.btnGestionVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionVentas.Location = new System.Drawing.Point(0, 368);
            this.btnGestionVentas.Name = "btnGestionVentas";
            this.btnGestionVentas.Size = new System.Drawing.Size(237, 54);
            this.btnGestionVentas.TabIndex = 6;
            this.btnGestionVentas.Text = "Gestion de Ventas";
            this.btnGestionVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionVentas.UseVisualStyleBackColor = true;
            this.btnGestionVentas.Click += new System.EventHandler(this.btnGestionVentas_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 552);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(237, 54);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionUsuarios.FlatAppearance.BorderSize = 0;
            this.btnGestionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionUsuarios.Location = new System.Drawing.Point(0, 314);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(237, 54);
            this.btnGestionUsuarios.TabIndex = 4;
            this.btnGestionUsuarios.Text = "Gestion de Usuarios";
            this.btnGestionUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionUsuarios.UseVisualStyleBackColor = true;
            this.btnGestionUsuarios.Click += new System.EventHandler(this.btnGestionUsuarios_Click);
            // 
            // btnGestionProveedores
            // 
            this.btnGestionProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionProveedores.FlatAppearance.BorderSize = 0;
            this.btnGestionProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionProveedores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionProveedores.Location = new System.Drawing.Point(0, 260);
            this.btnGestionProveedores.Name = "btnGestionProveedores";
            this.btnGestionProveedores.Size = new System.Drawing.Size(237, 54);
            this.btnGestionProveedores.TabIndex = 3;
            this.btnGestionProveedores.Text = "Gestion de Proveedores";
            this.btnGestionProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionProveedores.UseVisualStyleBackColor = true;
            this.btnGestionProveedores.Click += new System.EventHandler(this.btnGestionProveedores_Click);
            // 
            // btnGestionProductos
            // 
            this.btnGestionProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionProductos.FlatAppearance.BorderSize = 0;
            this.btnGestionProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionProductos.Location = new System.Drawing.Point(0, 206);
            this.btnGestionProductos.Name = "btnGestionProductos";
            this.btnGestionProductos.Size = new System.Drawing.Size(237, 54);
            this.btnGestionProductos.TabIndex = 2;
            this.btnGestionProductos.Text = "Gestion de Productos";
            this.btnGestionProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionProductos.UseVisualStyleBackColor = true;
            this.btnGestionProductos.Click += new System.EventHandler(this.btnGestionProductos_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.label2);
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(237, 206);
            this.pnlLogo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(32, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistema de Inventario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_de_inventario.Properties.Resources.lista;
            this.pictureBox1.Location = new System.Drawing.Point(27, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlCentral
            // 
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(254, 0);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(880, 536);
            this.pnlCentral.TabIndex = 2;
            this.pnlCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCentral_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.lblUserConnet,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.lblNivelUsuario});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(880, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(141, 22);
            this.toolStripLabel1.Text = "Usuario Conectado:";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // lblUserConnet
            // 
            this.lblUserConnet.Name = "lblUserConnet";
            this.lblUserConnet.Size = new System.Drawing.Size(12, 22);
            this.lblUserConnet.Text = ".";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(120, 22);
            this.toolStripLabel2.Text = "Nivel de Usuario:";
            // 
            // lblNivelUsuario
            // 
            this.lblNivelUsuario.Name = "lblNivelUsuario";
            this.lblNivelUsuario.Size = new System.Drawing.Size(12, 22);
            this.lblNivelUsuario.Text = ".";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(254, 536);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 25);
            this.panel2.TabIndex = 3;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 561);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlNavegacion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard-Usuario";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlNavegacion.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlNavegacion;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblUserConnet;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel lblNivelUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGestionProductos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGestionProveedores;
        private System.Windows.Forms.Button btnGestionUsuarios;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnGestionVentas;
        private System.Windows.Forms.Button btnGestionInventario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}