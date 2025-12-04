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
    public partial class UsuarioPanel : Form
    {
        private UsuarioDatos usuarioDatos = new UsuarioDatos();
        public UsuarioPanel()
        {
            InitializeComponent();
        }

        private void UsuarioPanel_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }

        private void cargarUsuarios()
        {
            try
            {
                DataTable tabla = usuarioDatos.listarUsuarios();
                dgvUsuarios.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los usuarios: " + ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarUsuarios();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            using (EditarUsuarioEmergente eue = new EditarUsuarioEmergente())
            {
                eue.ShowDialog();
                if (eue.guardado)
                {
                    cargarUsuarios(); //para refrescar en dgv
                }
            }
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            using (EditarEmpleadoEmergente eee = new EditarEmpleadoEmergente())
            {
                eee.ShowDialog();
                if (eee.guardado)
                {
                    cargarUsuarios(); //para refrescar en dgv
                }
            }
        }

        //no tengo idea de como funciona este método, pero se que es para que la celda del dgv se actualice al cambiar el checkbox y así cambiar el estado de un usuario a bloqueado o desbloqueado solo con un click
        private void dgvUsuarios_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.IsCurrentCellDirty)
            {
                dgvUsuarios.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        //este complementa al anterior
        private void dgvUsuarios_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "Bloqueado")
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

                int idUsuario = Convert.ToInt32(fila.Cells["IdUsuario"].Value);
                bool bloqueado = Convert.ToBoolean(fila.Cells["Bloqueado"].Value);

                try
                {
                    usuarioDatos.actualizarBloqueado(idUsuario, bloqueado);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al actualizar bloqueo: " + ex.Message, 
                                    "Usuarios",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    cargarUsuarios();
                }
            }
        }
    }
}
