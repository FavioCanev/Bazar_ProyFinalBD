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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            Usuario u = usuarioDatos.Login(usuario, contrasena);
            if (u != null)
            {
                MessageBox.Show("Inicio de sesión exitoso. Bienvenido " + u.nombreUsuario + "!", "Éxito", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                //aquí redirigir al formulario principal
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Inténtelo de nuevo.", "Error de inicio de sesión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
