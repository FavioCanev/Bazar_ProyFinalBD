using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class PanelAdmin : Form
    {
        private Usuario usuarioLogueado;

        public PanelAdmin(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
        }

        private void PanelAdmin_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormularioEnPanel(Form formHijo)
        {
            panelContenedor.Controls.Clear();
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void btnPanelUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new UsuarioPanel());
        }

        private void btnPanelProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ProveedorPanel());
        }

        private void btnPanelInventario_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new InventarioPanel());
        }

        private void btnPanelCajas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new CajaPanel());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new MovimientosPanel());
        }
    }
}
