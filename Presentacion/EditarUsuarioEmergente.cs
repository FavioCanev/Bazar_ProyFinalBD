using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class EditarUsuarioEmergente : Form
    {
        private EmpleadoDatos empleadoDatos = new EmpleadoDatos();
        private UsuarioDatos usuarioDatos = new UsuarioDatos();
        public bool guardado { get; private set; } = false;


        public EditarUsuarioEmergente()
        {
            InitializeComponent();
        }

        private void EditarUsuarioEmergente_Load(object sender, EventArgs e)
        {
            cargarEmpleadosSinUsuario();
            cbxBloqueado.Checked = false;
        }

        private void cargarEmpleadosSinUsuario()
        { 
                DataTable tabla = empleadoDatos.ListarSinUsuarios();
                cbSelecEmpleado.DataSource = tabla;
                cbSelecEmpleado.DisplayMember = "Empleado";
                cbSelecEmpleado.ValueMember = "IdEmpleado";
                cbSelecEmpleado.SelectedIndex = -1; // No seleccionar ningún elemento por defecto
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNuevoNombreUsuario.Text) ||
                string.IsNullOrWhiteSpace(tbNuevaContrasena.Text) ||
                cbSelecEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Usuario nuevo = new Usuario
            {
                nombreUsuario = tbNuevoNombreUsuario.Text.Trim(),
                contrasenaUsuario = tbNuevaContrasena.Text.Trim(),
                idEmpleado = Convert.ToInt32(cbSelecEmpleado.SelectedValue),
                bloqueado = cbxBloqueado.Checked
            };

            try
            {
                usuarioDatos.insertar(nuevo);
                guardado = true;
                MessageBox.Show("Usuario creado correctamente");
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al crear usuario: " + ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
