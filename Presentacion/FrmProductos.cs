using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;
using Datos;
using Entidades;

namespace Presentacion
{
    public partial class FrmProductos : Form
    {
        private readonly ControllerProducto controller = new ControllerProducto();
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void cargarProductos()
        {

            dgvProducto.DataSource = controller.obtenerTodos();

        }


        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            var frm = new FrmProductoEdicion();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cargarProductos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProducto.CurrentRow == null) return;

            var producto = (Producto)dgvProducto.CurrentRow.DataBoundItem;
            var frm = new FrmProductoEdicion(producto);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                cargarProductos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProducto.CurrentRow == null) return;

            var producto = (Producto)dgvProducto.CurrentRow.DataBoundItem;

            controller.eliminar(producto.idProducto);
            cargarProductos();
        }
    }
}
