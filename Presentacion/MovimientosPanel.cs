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
    public partial class MovimientosPanel : Form
    {
        private MovimientosDatos movimientosDatos = new MovimientosDatos();
        public MovimientosPanel()
        {
            InitializeComponent();
        }

        private void MovimientosPanel_Load(object sender, EventArgs e)
        {
            cbTipo.Items.Clear();
            cbTipo.Items.Add("Ventas");
            cbTipo.Items.Add("Compras");
            cbTipo.SelectedIndex = 0;

            cargarMovimientos();
        }

        private void cargarMovimientos()
        {
            try
            {
                DataTable tabla;

                if(cbTipo.SelectedItem.ToString() == "Ventas")
                {
                    tabla = movimientosDatos.listarVentas();
                }
                else //Compras
                {
                    tabla = movimientosDatos.listarCompras();
                }
                dgvMovimientos.DataSource = tabla;
            }

            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar los movimientos: " + ex.Message);
            }
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarMovimientos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarMovimientos();
        }
    }
}
