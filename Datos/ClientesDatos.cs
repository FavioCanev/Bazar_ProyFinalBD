using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class ClientesDatos
    {
        private ConexionDB conexion = new ConexionDB();

        public DataTable listar()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = conexion.establecerConexion())
            {
                cn.Open();

                string consulta = @"
                SELECT IdCliente,
                       (Nombre + ' ' + ApellidoPaterno + ' ' + ISNULL(ApellidoMaterno, '')) AS NombreCompleto
                FROM Clientes;";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }

            return tabla;
        }

        public int Insertar(Cliente c)
        {
            using (SqlConnection cn = conexion.establecerConexion())
            {
                cn.Open();

                string query = @"
                INSERT INTO Clientes (Nombre, ApellidoPaterno, ApellidoMaterno, Dni, Telefono)
                VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Dni, @Telefono);
                SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", c.nombre);
                    cmd.Parameters.AddWithValue("@ApellidoPaterno", c.apellidoPaterno);
                    cmd.Parameters.AddWithValue("@ApellidoMaterno",
                        string.IsNullOrWhiteSpace(c.apellidoMaterno) ? (object)DBNull.Value : c.apellidoMaterno);
                    cmd.Parameters.AddWithValue("@Dni",
                        string.IsNullOrWhiteSpace(c.dni) ? (object)DBNull.Value : c.dni);
                    cmd.Parameters.AddWithValue("@Telefono",
                        string.IsNullOrWhiteSpace(c.telefono) ? (object)DBNull.Value : c.telefono);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
    }
}
