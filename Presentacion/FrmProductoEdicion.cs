using Controladores;
using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmProductoEdicion : Form
    {
        private ControllerProducto controller = new ControllerProducto();
        private Producto producto;
        public FrmProductoEdicion(Producto producto = null)
        {
            InitializeComponent();
            producto = producto ?? new Producto();

            if (producto != null)
            {
                cargarDatos();
            }
        }

        private void btnGuardarEdicion_Click(object sender, EventArgs e)
        {
            producto.nombre = txtNombre.Text;
            producto.caracteristica = txtCaracteristica.Text;
            producto.unidadMedida = txtUnidad.Text;
            producto.precioCompra = decimal.Parse(txtPrecioCompra.Text);
            producto.precioVenta = decimal.Parse(txtPrecioVenta.Text);
            producto.estado = cmbEstado.Text;

            controller.guardar(producto);
            this.DialogResult = DialogResult.OK;
        }

        private void cargarDatos()
        {
            txtNombre.Text = producto.nombre;
            txtCaracteristica.Text = producto.caracteristica;
            txtUnidad.Text = producto.unidadMedida;
            txtPrecioCompra.Text = producto.precioCompra.ToString("0.00");
            txtPrecioVenta.Text = producto.precioVenta.ToString("0.00");
            cmbEstado.Text = producto.estado;
        }
    }
}
