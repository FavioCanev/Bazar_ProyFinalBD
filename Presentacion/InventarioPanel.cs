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

namespace Presentacion
{
    public partial class InventarioPanel : Form
    {
        private InventarioDatos inventarioDatos = new InventarioDatos();
        public InventarioPanel()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarInventario();
        }

        private void InventarioPanel_Load(object sender, EventArgs e)
        {
            cargarInventario();
        }

        private void cargarInventario()
        {
            try
            {
                DataTable tabla = inventarioDatos.listarInventario();
                dgvInventario.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el inventario: " + ex.Message);
            }
        }
    }
}
