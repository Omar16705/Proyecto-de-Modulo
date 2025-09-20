using Modelos.Entidades;
using Sistema_de_inventario.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_inventario.Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pnlRegistraroIniciarSesion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            pnlAcciones.Controls.Clear();
            pnlAcciones.Controls.Add(frm);

        }

                      frmRegistrar frmRegistrar = new frmRegistrar();
                      frmIniciar frm = new frmIniciar();

        private void Login_Load(object sender, EventArgs e)
        {
            pnlAcciones.Controls.Clear();
            pnlAcciones.Controls.Add(frm);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            pnlAcciones.Controls.Clear();
            pnlAcciones.Controls.Add(frmRegistrar);
        }
    }
}
