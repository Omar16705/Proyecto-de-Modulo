namespace Sistema_de_inventario.Formularios
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlRegistraroIniciarSesion = new System.Windows.Forms.Panel();
            this.btnCerrarApp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lbkOlvisdastetuPass = new System.Windows.Forms.LinkLabel();
            this.pnlRegistraroIniciarSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegistraroIniciarSesion
            // 
            this.pnlRegistraroIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(77)))), ((int)(((byte)(86)))));
            this.pnlRegistraroIniciarSesion.Controls.Add(this.lbkOlvisdastetuPass);
            this.pnlRegistraroIniciarSesion.Controls.Add(this.btnCerrarApp);
            this.pnlRegistraroIniciarSesion.Controls.Add(this.pictureBox1);
            this.pnlRegistraroIniciarSesion.Controls.Add(this.lblBienvenido);
            this.pnlRegistraroIniciarSesion.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRegistraroIniciarSesion.Location = new System.Drawing.Point(0, 0);
            this.pnlRegistraroIniciarSesion.Name = "pnlRegistraroIniciarSesion";
            this.pnlRegistraroIniciarSesion.Size = new System.Drawing.Size(260, 561);
            this.pnlRegistraroIniciarSesion.TabIndex = 0;
            this.pnlRegistraroIniciarSesion.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRegistraroIniciarSesion_Paint);
            // 
            // btnCerrarApp
            // 
            this.btnCerrarApp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarApp.FlatAppearance.BorderSize = 0;
            this.btnCerrarApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarApp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarApp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrarApp.Location = new System.Drawing.Point(0, 511);
            this.btnCerrarApp.Name = "btnCerrarApp";
            this.btnCerrarApp.Size = new System.Drawing.Size(260, 50);
            this.btnCerrarApp.TabIndex = 2;
            this.btnCerrarApp.Text = "Cerrar Sistema";
            this.btnCerrarApp.UseVisualStyleBackColor = true;
            this.btnCerrarApp.Click += new System.EventHandler(this.btnCerrarApp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_de_inventario.Properties.Resources.lista;
            this.pictureBox1.Location = new System.Drawing.Point(13, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBienvenido.Location = new System.Drawing.Point(25, 60);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(207, 22);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido al Sistema";
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.label3);
            this.pnlAcciones.Controls.Add(this.btnIniciarSesion);
            this.pnlAcciones.Controls.Add(this.label2);
            this.pnlAcciones.Controls.Add(this.label1);
            this.pnlAcciones.Controls.Add(this.txtClave);
            this.pnlAcciones.Controls.Add(this.txtUsuario);
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAcciones.Location = new System.Drawing.Point(260, 0);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(774, 561);
            this.pnlAcciones.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Iniciar Sesion";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(258, 370);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(272, 77);
            this.btnIniciarSesion.TabIndex = 29;
            this.btnIniciarSesion.Text = "Iniciar sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Clave:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Usuario:";
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(255, 312);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(273, 26);
            this.txtClave.TabIndex = 26;
            this.txtClave.Text = "2211";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(255, 226);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(273, 26);
            this.txtUsuario.TabIndex = 25;
            this.txtUsuario.Text = "Omar";
            // 
            // lbkOlvisdastetuPass
            // 
            this.lbkOlvisdastetuPass.AutoSize = true;
            this.lbkOlvisdastetuPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbkOlvisdastetuPass.LinkColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbkOlvisdastetuPass.Location = new System.Drawing.Point(38, 430);
            this.lbkOlvisdastetuPass.Name = "lbkOlvisdastetuPass";
            this.lbkOlvisdastetuPass.Size = new System.Drawing.Size(182, 17);
            this.lbkOlvisdastetuPass.TabIndex = 3;
            this.lbkOlvisdastetuPass.TabStop = true;
            this.lbkOlvisdastetuPass.Text = "¿Olvidaste tu Contraseña?";
            this.lbkOlvisdastetuPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbkOlvisdastetuPass_LinkClicked);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.pnlRegistraroIniciarSesion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlRegistraroIniciarSesion.ResumeLayout(false);
            this.pnlRegistraroIniciarSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            this.pnlAcciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegistraroIniciarSesion;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrarApp;
        private System.Windows.Forms.LinkLabel lbkOlvisdastetuPass;
    }
}