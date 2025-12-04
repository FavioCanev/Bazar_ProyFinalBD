using Datos;
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
    public partial class EditarEmpleadoEmergente : Form
    {
        private EmpleadoDatos empleadoDatos = new EmpleadoDatos();
        public EditarEmpleadoEmergente()
        {
            InitializeComponent();
        }
        public bool guardado { get; private set; } = false;

        private void EditarEmpleadoEmergente_Load(object sender, EventArgs e)
        {
            cargarRoles();
            dtpFechaContratacion.Value = DateTime.Today;
        }

        private void cargarRoles()
        {
            DataTable tabla = empleadoDatos.listarRoles();
            cbRoles.DataSource = tabla;
            cbRoles.DisplayMember = "Nombre";
            cbRoles.ValueMember = "IdRol";
            cbRoles.SelectedIndex = -1; // No seleccionar ningún elemento por defecto -- sugerencia de copilot
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombreEmpleado.Text) ||
                string.IsNullOrWhiteSpace(tbApellidosSinSeparar.Text) ||
                string.IsNullOrWhiteSpace(tbDniEmpleado.Text) ||
                string.IsNullOrWhiteSpace(tbTelefono.Text) ||
                string.IsNullOrWhiteSpace(tbSueldo.Text) ||
                cbRoles.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbDniEmpleado.Text.Length != 8 || !tbDniEmpleado.Text.All(char.IsDigit))
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos numéricos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(tbSueldo.Text, out decimal sueldo) || sueldo < 0)
            {
                MessageBox.Show("El sueldo debe ser un número decimal positivo y los decimales separados por punto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string estadoSelec;
            if (cbxActivo.Checked == true)
            {
                estadoSelec = "ACTIVO";
            }
            else
            {
                estadoSelec = "INACTIVO";
            }

            Empleado emp = new Empleado
            {//preguntarle al profe por el split y el trim, puede que no sean compatibles
                nombre = tbNombreEmpleado.Text.Trim(),
                apellidoPaterno = tbApellidosSinSeparar.Text.Trim().Split(' ')[0], //el split es para separar las palabras de una cadena, así solo le pedimos al usuario que ingrese los apellidos juntos y luego los separamos
                apellidoMaterno = tbApellidosSinSeparar.Text.Trim().Split(' ').Length > 1 ? tbApellidosSinSeparar.Text.Trim().Split(' ')[1] : "",
                dni = tbDniEmpleado.Text.Trim(),
                telefono = tbTelefono.Text.Trim(),
                sueldo = sueldo,
                idRol = Convert.ToInt32(cbRoles.SelectedValue),
                estado = estadoSelec,
                fechaContratacion = dtpFechaContratacion.Value.Date
            };

            try
            {
                empleadoDatos.insertar(emp);
                guardado = true;
                MessageBox.Show("Empleado guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
