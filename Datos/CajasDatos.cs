using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CajasDatos
    {
        private ConexionDB conexion = new ConexionDB();

        public int abrirTurno(int idEmpleado)
        {
            using (SqlConnection cn = conexion.establecerConexion())
            {
                cn.Open();

                string consulta = @"
                                INSERT INTO CajaTurno (IdEmpleado)
                                VALUES (@IdEmpleado);
                                SELECT SCOPE_IDENTITY();"; //preguntar que hace esto

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public void cerrarTurno(int idTurno)
        {
            using (SqlConnection cn = conexion.establecerConexion())
            {
                cn.Open();

                string consulta = @"
                                UPDATE CajaTurno
                                SET FechaCierre = GETDATE(),
                                    Estado = 'CERRADO'
                                WHERE IdTurno = @IdTurno;";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("@IdTurno", idTurno);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable listarTurnos()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = conexion.establecerConexion())
            {
                cn.Open();

                string consulta = @"
                SELECT ct.IdTurno,
                       ct.FechaApertura,
                       ct.FechaCierre,
                       ct.MontoInicial,
                       ct.MontoFinal,
                       ct.Estado,
                       e.Nombre + ' ' + e.ApellidoPaterno + ' ' + e.ApellidoMaterno AS Empleado
                FROM CajaTurno ct
                INNER JOIN Empleados e ON ct.IdEmpleado = e.IdEmpleado;";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }
    }
}
