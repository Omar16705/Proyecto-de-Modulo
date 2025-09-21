namespace Sistema_de_inventario.UserControls
{
    partial class frmGestionUsuarios
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
            this.pnlGestionUsuarios = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlGestionUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGestionUsuarios
            // 
            this.pnlGestionUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(77)))), ((int)(((byte)(86)))));
            this.pnlGestionUsuarios.Controls.Add(this.button1);
            this.pnlGestionUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGestionUsuarios.Location = new System.Drawing.Point(0, 0);
            this.pnlGestionUsuarios.Name = "pnlGestionUsuarios";
            this.pnlGestionUsuarios.Size = new System.Drawing.Size(835, 273);
            this.pnlGestionUsuarios.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlGestionUsuarios);
            this.Name = "frmGestionUsuarios";
            this.Size = new System.Drawing.Size(835, 541);
            this.pnlGestionUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGestionUsuarios;
        private System.Windows.Forms.Button button1;
    }
}
