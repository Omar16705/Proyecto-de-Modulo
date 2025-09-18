namespace Sistema_de_inventario.Formularios
{
    partial class frmInicioSesion
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
            this.pnlRegistraroIniciarSesion = new System.Windows.Forms.Panel();
            this.pnlIniciaroRegistrar = new System.Windows.Forms.Panel();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlRegistraroIniciarSesion.SuspendLayout();
            this.pnlIniciaroRegistrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegistraroIniciarSesion
            // 
            this.pnlRegistraroIniciarSesion.Controls.Add(this.btnRegistrar);
            this.pnlRegistraroIniciarSesion.Controls.Add(this.btnIniciarSesion);
            this.pnlRegistraroIniciarSesion.Controls.Add(this.lblBienvenido);
            this.pnlRegistraroIniciarSesion.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRegistraroIniciarSesion.Location = new System.Drawing.Point(0, 0);
            this.pnlRegistraroIniciarSesion.Name = "pnlRegistraroIniciarSesion";
            this.pnlRegistraroIniciarSesion.Size = new System.Drawing.Size(251, 450);
            this.pnlRegistraroIniciarSesion.TabIndex = 0;
            this.pnlRegistraroIniciarSesion.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRegistraroIniciarSesion_Paint);
            // 
            // pnlIniciaroRegistrar
            // 
            this.pnlIniciaroRegistrar.Controls.Add(this.label2);
            this.pnlIniciaroRegistrar.Controls.Add(this.label1);
            this.pnlIniciaroRegistrar.Controls.Add(this.txtClave);
            this.pnlIniciaroRegistrar.Controls.Add(this.txtUsuario);
            this.pnlIniciaroRegistrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIniciaroRegistrar.Location = new System.Drawing.Point(251, 0);
            this.pnlIniciaroRegistrar.Name = "pnlIniciaroRegistrar";
            this.pnlIniciaroRegistrar.Size = new System.Drawing.Size(549, 450);
            this.pnlIniciaroRegistrar.TabIndex = 1;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(25, 60);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(207, 22);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido al Sistema";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(12, 388);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(111, 50);
            this.btnIniciarSesion.TabIndex = 1;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(141, 388);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(91, 50);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(148, 153);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(273, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(148, 239);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(273, 20);
            this.txtClave.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clave:";
            // 
            // frmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlIniciaroRegistrar);
            this.Controls.Add(this.pnlRegistraroIniciarSesion);
            this.Name = "frmInicioSesion";
            this.Text = "frmInicioSesion";
            this.pnlRegistraroIniciarSesion.ResumeLayout(false);
            this.pnlRegistraroIniciarSesion.PerformLayout();
            this.pnlIniciaroRegistrar.ResumeLayout(false);
            this.pnlIniciaroRegistrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegistraroIniciarSesion;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Panel pnlIniciaroRegistrar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}