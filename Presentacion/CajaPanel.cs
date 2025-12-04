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
    public partial class CajaPanel : Form
    {
        private CajasDatos cajasDatos = new CajasDatos();

        public CajaPanel()
        {
            InitializeComponent();
        }

        private void CajaPanel_Load(object sender, EventArgs e)
        {
            cargarTurnos();
        }

        private void cargarTurnos()
        {
            try
            {
                DataTable tabla = cajasDatos.listarTurnos();
                dgvTurnos.DataSource = tabla;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar turnos", ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarTurnos();
        }
    }
}
