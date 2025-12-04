using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RolDatos
    {
        private ConexionDB conexion = new ConexionDB();

        public string obtenerRolDeEmpleado(int idEmpleado)
        {
            using (SqlConnection cn = conexion.establecerConexion())
            {
                cn.Open();

                string consulta = @"
                SELECT r.Nombre
                FROM Empleados e
                INNER JOIN Roles r ON e.IdRol = r.IdRol
                WHERE e.IdEmpleado = @IdEmpleado;";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("IdEmpleado", idEmpleado);
                    object result = cmd.ExecuteScalar();
                    return result == null ? null : result.ToString();
                }
            }
        }
    }
}
