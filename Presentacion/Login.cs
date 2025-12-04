using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidades;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private UsuarioDatos usuarioDatos = new UsuarioDatos();
        private RolDatos rolDatos = new RolDatos();
        private CajasDatos cajaDatos = new CajasDatos();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            Usuario u = usuarioDatos.Login(usuario, contrasena);

            if (u != null && !u.bloqueado)
            {
                string rol = rolDatos.obtenerRolDeEmpleado(u.idEmpleado); //hacer este método en Datos

                if (rol == "VENDEDOR")
                {
                    int idTurno = cajaDatos.abrirTurno(u.idEmpleado);
                    PanelVendedor pv = new PanelVendedor(u, idTurno);
                    pv.Show();
                    this.Hide();
                }
                else if (rol == "ADMINISTRADOR")
                {
                    PanelAdmin panel = new PanelAdmin(u);
                    this.Hide();
                    panel.Show();
                }
                else
                {
                    //abrir panel de almacenero
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos, o usuario bloqueado." + "Inténtelo de nuevo.", "Error de inicio de sesión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
