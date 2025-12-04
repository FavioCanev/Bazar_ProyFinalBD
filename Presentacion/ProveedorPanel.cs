using Datos;
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
    public partial class ProveedorPanel : Form
    {
        private ProveedorDatos proveedorDatos = new ProveedorDatos();

        public ProveedorPanel()
        {
            InitializeComponent();
        }

        private void ProveedorPanel_Load(object sender, EventArgs e)
        {
            cargarProveedores();
        }

        private void cargarProveedores()
        {
            try
            {
                DataTable tabla = proveedorDatos.listar();
                dgvProveedores.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proveedores: " + ex.Message + "\n\n" + ex.StackTrace,
        "Proveedores",
        MessageBoxButtons.OK,
        MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarProveedores();
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            using (EditarProveedorEmergente frm = new EditarProveedorEmergente())
            {
                frm.ShowDialog();
                if (frm.guardado)
                {
                    cargarProveedores();
                }
            }
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un proveedor para editar.", "Editar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Proveedor p = new Proveedor
            {
                idProveedor = Convert.ToInt32(dgvProveedores.CurrentRow.Cells["IdProveedor"].Value),
                nombre = dgvProveedores.CurrentRow.Cells["Nombre"].Value.ToString(),
                ruc = dgvProveedores.CurrentRow.Cells["Ruc"].Value == DBNull.Value ? null : dgvProveedores.CurrentRow.Cells["Ruc"].Value.ToString(),
                direccion = dgvProveedores.CurrentRow.Cells["Direccion"].Value == DBNull.Value ? null : dgvProveedores.CurrentRow.Cells["Direccion"].Value.ToString(),
                estado = dgvProveedores.CurrentRow.Cells["Estado"].Value.ToString()
            };

            using (EditarProveedorEmergente frm = new EditarProveedorEmergente(p))
            {
                frm.ShowDialog();
                if (frm.guardado)
                {
                    cargarProveedores();
                }
            }
        }

        private void btnVerContacto_Click(object sender, EventArgs e)
        {
            //falta implementar
        }
    }
}
