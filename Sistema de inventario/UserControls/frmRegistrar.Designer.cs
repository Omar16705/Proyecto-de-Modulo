namespace Sistema_de_inventario.UserControls
{
    partial class frmRegistrar
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblIdRol = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblCorrreoElectronico = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblRegistrarse = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvVerUsuarios = new System.Windows.Forms.DataGridView();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnEliminarUsuarios = new System.Windows.Forms.Button();
            this.btnActuali = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(572, 164);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(115, 63);
            this.btnRegistrar.TabIndex = 19;
            this.btnRegistrar.Text = "Registrar Usuarios";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(208, 199);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(307, 28);
            this.cmbRol.TabIndex = 18;
            // 
            // lblIdRol
            // 
            this.lblIdRol.AutoSize = true;
            this.lblIdRol.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdRol.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIdRol.Location = new System.Drawing.Point(13, 205);
            this.lblIdRol.Name = "lblIdRol";
            this.lblIdRol.Size = new System.Drawing.Size(142, 22);
            this.lblIdRol.TabIndex = 17;
            this.lblIdRol.Text = "Rol de Usuario:";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoElectronico.Location = new System.Drawing.Point(208, 112);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(307, 26);
            this.txtCorreoElectronico.TabIndex = 16;
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(208, 160);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(307, 26);
            this.txtClave.TabIndex = 15;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(208, 63);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(307, 26);
            this.txtNombreUsuario.TabIndex = 14;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClave.Location = new System.Drawing.Point(18, 164);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(71, 22);
            this.lblClave.TabIndex = 13;
            this.lblClave.Text = "Clave:";
            // 
            // lblCorrreoElectronico
            // 
            this.lblCorrreoElectronico.AutoSize = true;
            this.lblCorrreoElectronico.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrreoElectronico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCorrreoElectronico.Location = new System.Drawing.Point(18, 116);
            this.lblCorrreoElectronico.Name = "lblCorrreoElectronico";
            this.lblCorrreoElectronico.Size = new System.Drawing.Size(184, 22);
            this.lblCorrreoElectronico.TabIndex = 12;
            this.lblCorrreoElectronico.Text = "Correo Electronico:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombreUsuario.Location = new System.Drawing.Point(13, 67);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(189, 22);
            this.lblNombreUsuario.TabIndex = 11;
            this.lblNombreUsuario.Text = "Nombre de Usuario:";
            // 
            // lblRegistrarse
            // 
            this.lblRegistrarse.AutoSize = true;
            this.lblRegistrarse.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRegistrarse.Location = new System.Drawing.Point(12, 14);
            this.lblRegistrarse.Name = "lblRegistrarse";
            this.lblRegistrarse.Size = new System.Drawing.Size(205, 28);
            this.lblRegistrarse.TabIndex = 10;
            this.lblRegistrarse.Text = "Registrar Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(77)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.btnEliminarUsuarios);
            this.panel1.Controls.Add(this.btnActuali);
            this.panel1.Controls.Add(this.btnLimpiarCampos);
            this.panel1.Controls.Add(this.lblRegistrarse);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.lblNombreUsuario);
            this.panel1.Controls.Add(this.cmbRol);
            this.panel1.Controls.Add(this.lblCorrreoElectronico);
            this.panel1.Controls.Add(this.lblIdRol);
            this.panel1.Controls.Add(this.lblClave);
            this.panel1.Controls.Add(this.txtCorreoElectronico);
            this.panel1.Controls.Add(this.txtNombreUsuario);
            this.panel1.Controls.Add(this.txtClave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 253);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvVerUsuarios
            // 
            this.dgvVerUsuarios.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvVerUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvVerUsuarios.Location = new System.Drawing.Point(0, 253);
            this.dgvVerUsuarios.Name = "dgvVerUsuarios";
            this.dgvVerUsuarios.Size = new System.Drawing.Size(874, 283);
            this.dgvVerUsuarios.TabIndex = 21;
            this.dgvVerUsuarios.DoubleClick += new System.EventHandler(this.dgvVerUsuarios_DoubleClick);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(709, 75);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(115, 63);
            this.btnLimpiarCampos.TabIndex = 20;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnEliminarUsuarios
            // 
            this.btnEliminarUsuarios.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnEliminarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuarios.Location = new System.Drawing.Point(709, 164);
            this.btnEliminarUsuarios.Name = "btnEliminarUsuarios";
            this.btnEliminarUsuarios.Size = new System.Drawing.Size(115, 63);
            this.btnEliminarUsuarios.TabIndex = 22;
            this.btnEliminarUsuarios.Text = "Eliminar Usuarios";
            this.btnEliminarUsuarios.UseVisualStyleBackColor = false;
            this.btnEliminarUsuarios.Click += new System.EventHandler(this.btnEliminarUsuarios_Click);
            // 
            // btnActuali
            // 
            this.btnActuali.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActuali.FlatAppearance.BorderSize = 0;
            this.btnActuali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActuali.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActuali.Location = new System.Drawing.Point(572, 75);
            this.btnActuali.Name = "btnActuali";
            this.btnActuali.Size = new System.Drawing.Size(115, 63);
            this.btnActuali.TabIndex = 21;
            this.btnActuali.Text = "Actualizar Usuarios";
            this.btnActuali.UseVisualStyleBackColor = false;
            this.btnActuali.Click += new System.EventHandler(this.btnActuali_Click);
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvVerUsuarios);
            this.Controls.Add(this.panel1);
            this.Name = "frmRegistrar";
            this.Size = new System.Drawing.Size(874, 536);
            this.Load += new System.EventHandler(this.frmRegistrar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblIdRol;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblCorrreoElectronico;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblRegistrarse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvVerUsuarios;
        private System.Windows.Forms.Button btnEliminarUsuarios;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnActuali;
    }
}
