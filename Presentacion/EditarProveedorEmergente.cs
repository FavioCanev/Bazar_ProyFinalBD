using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Datos;

namespace Presentacion
{
    public partial class EditarProveedorEmergente : Form
    {
        private ProveedorDatos proveedorDatos = new ProveedorDatos();
        
        public bool guardado { get; private set; } = false;

        public EditarProveedorEmergente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombreProveedor.Text))
            {
                MessageBox.Show("El nombre del proveedor es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Proveedor p = proveedorEditar ?? new Proveedor();


            string activo;
            if (cbxActivo.Checked == true)
            {
                activo = "ACTIVO";
            }
            else
            {
                activo = "INACTIVO";
            }

            p.nombre = tbNombreProveedor.Text.Trim();
            p.ruc = string.IsNullOrWhiteSpace(tbRucProveedor.Text) ? null : tbRucProveedor.Text.Trim();
            p.direccion = string.IsNullOrWhiteSpace(tbDireccionProveedor.Text) ? null : tbDireccionProveedor.Text.Trim();
            p.estado = activo;

            try
            {
                if (proveedorEditar == null)
                {
                    proveedorDatos.insertar(p);
                }
                else
                {
                    proveedorDatos.editarDatos(p);
                }

                guardado = true;
                MessageBox.Show("Proveedor guardado correctamente.");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al crear al proveedor: " + ex.Message);
            }
        }

        //nuevo campo para saber si es edición y el proveedor a editar
        private Proveedor proveedorEditar;

        public EditarProveedorEmergente (Proveedor proveedor) : this()
        {
            proveedorEditar = proveedor;
        }

        private void EditarProveedorEmergente_Load(object sender, EventArgs e)
        {
            if (proveedorEditar != null)
            {
                //modo edición
                tbNombreProveedor.Text = proveedorEditar.nombre;
                tbRucProveedor.Text = proveedorEditar.ruc;
                tbDireccionProveedor.Text = proveedorEditar.direccion;
                cbxActivo.Checked = proveedorEditar.estado == "ACTIVO";
            }

            else
            {

            }
        }
    }
}
