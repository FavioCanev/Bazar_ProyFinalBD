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
    public partial class PanelVendedor : Form
    {
        private Usuario usuarioLogueado;
        private int idTurnoActual;
        private CajasDatos cajasDatos = new CajasDatos();
        private VentaDatos ventaDatos = new VentaDatos();
        private DataTable productosTabla;

        public PanelVendedor(Usuario usuario, int idTurno)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
            idTurnoActual = idTurno;
        }

        private void PanelVendedor_Load(object sender, EventArgs e)
        {
            productosTabla = ventaDatos.listarProductosConStock();

            dgvProductosDisponibles.DataSource = productosTabla;

            dgvCarrito.Columns.Clear();
            dgvCarrito.Columns.Add("IdProducto", "IdProducto");
            dgvCarrito.Columns.Add("Producto", "Producto");
            dgvCarrito.Columns.Add("Precio", "Precio");
            dgvCarrito.Columns.Add("Cantidad", "Cantidad");
            dgvCarrito.Columns.Add("Subtotal", "Subtotal");

            dgvCarrito.Columns["IdProducto"].Visible = false;

            cbMetodoPago.DataSource = ventaDatos.listarMetodosPago();
            cbMetodoPago.DisplayMember = "Nombre";
            cbMetodoPago.ValueMember = "IdMetodoPago";

            cargarClientes();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                cajasDatos.cerrarTurno(idTurnoActual);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar el turno: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Restart();
        }

        private ClientesDatos clientesDatos = new ClientesDatos();


        private void cargarClientes()
        {
            DataTable tabla = clientesDatos.listar();
            cbSelecCliente.DataSource = tabla;
            cbSelecCliente.DisplayMember = "NombreCompleto";
            cbSelecCliente.ValueMember = "IdCliente";
        }
        

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            using (EditarClienteEmergente frm = new EditarClienteEmergente())
            {
                frm.ShowDialog();
                if (frm.guardado)
                {
                    cargarClientes();
                    for (int i = 0; i < cbSelecCliente.Items.Count; i++)
                    {
                        if (cbSelecCliente.Items[i] is DataRowView drv &&
                            Convert.ToInt32(drv["IdCliente"]) == frm.idClienteCreado)
                        {
                            cbSelecCliente.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.Rows.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbMetodoPago.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un método de pago.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int? idCliente = null;
            if (cbSelecCliente.SelectedValue != null)
                idCliente = Convert.ToInt32(cbSelecCliente.SelectedValue);

            int idMetodoPago = Convert.ToInt32(cbMetodoPago.SelectedValue);

            // Calcular subtotal y total a partir del carrito
            decimal subtotal = 0;
            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                    subtotal += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }
            decimal descuento = 0;
            decimal total = subtotal - descuento;

            // Construir lista de detalles
            List<DetalleVentaEntidad> detalles = new List<DetalleVentaEntidad>();
            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                if (row.Cells["IdProducto"].Value == null)
                    continue;

                detalles.Add(new DetalleVentaEntidad
                {
                    idProducto = Convert.ToInt32(row.Cells["IdProducto"].Value),
                    cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                    precioUnitario = Convert.ToDecimal(row.Cells["Precio"].Value)
                });
            }

            try
            {
                int idVenta = ventaDatos.registrarVenta(
                    usuarioLogueado.idUsuario,
                    idCliente,
                    idMetodoPago,
                    subtotal,
                    descuento,
                    total,
                    detalles);

                MessageBox.Show("Venta registrada correctamente. ID Venta: " + idVenta, "Éxito");

                //limpia el carrito
                dgvCarrito.Rows.Clear();
                productosTabla = ventaDatos.listarProductosConStock();

                actualizarTotales();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void actualizarTotales()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                    subtotal += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }

            decimal descuento = 0;

            decimal total = subtotal - descuento;

            lblMontoSubtotal.Text = "Subtotal: $" + subtotal.ToString("0.00");
            lblMontoDescuento.Text = "Descuento: $" + descuento.ToString("0.00");
            lblMontoTotal.Text = "Total: $" + total.ToString("0.00");
        }
    }
}
