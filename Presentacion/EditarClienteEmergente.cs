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
    public partial class EditarClienteEmergente : Form
    {
        private ClientesDatos clientesDatos = new ClientesDatos();

        public bool guardado { get; private set; } = false;
        public int idClienteCreado { get; private set; }
        public EditarClienteEmergente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombreCliente.Text) ||
                string.IsNullOrWhiteSpace(tbApellidosSinSeparar.Text))
            {
                MessageBox.Show("Nombre y apellidos son obligatorios.");
                return;
            }

            Cliente c = new Cliente
            {
                nombre = tbNombreCliente.Text.Trim(),
                apellidoPaterno = tbApellidosSinSeparar.Text.Trim().Split(' ')[0],
                apellidoMaterno = tbApellidosSinSeparar.Text.Trim().Split(' ').Length > 1 ? tbApellidosSinSeparar.Text.Trim().Split(' ')[1] : null,
                dni = string.IsNullOrWhiteSpace(tbDniCliente.Text) ? null : tbDniCliente.Text.Trim(),
                telefono = string.IsNullOrWhiteSpace(tbTelefono.Text) ? null : tbTelefono.Text.Trim()
            };

            try
            {
                int id = clientesDatos.Insertar(c);
                guardado = true;
                idClienteCreado = id;
                MessageBox.Show("Cliente registrado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar cliente: " + ex.Message);
            }
        }
    }
}
