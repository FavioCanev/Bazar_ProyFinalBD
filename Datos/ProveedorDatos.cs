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
    public class ProveedorDatos
    {
        private ConexionDB conexion = new ConexionDB();

        public DataTable listar()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = conexion.establecerConexion())
            {
                cn.Open();
                string consulta = @"
                                  SELECT IdProveedor,
                                  Nombre,
                                  Ruc,
                                  Direccion,
                                  Estado,
                                  FechaRegistro 
                                  FROM Proveedor;";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        public void insertar(Proveedor p)
        {
            using (SqlConnection cn = conexion.establecerConexion())
            {
                cn.Open();

                string consulta = @"
                                  INSERT INTO Proveedor
                                  (Nombre, Ruc, Direccion, Estado, FechaRegistro)
                                  VALUES
                                  (@Nombre, @Ruc, @Direccion, @Estado, GETDATE());";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", p.nombre);
                    cmd.Parameters.AddWithValue("@Ruc", string.IsNullOrWhiteSpace(p.ruc) ? (object)DBNull.Value : p.ruc);
                    cmd.Parameters.AddWithValue("@Direccion", string.IsNullOrWhiteSpace(p.direccion) ? (object)DBNull.Value : p.direccion);
                    cmd.Parameters.AddWithValue("@Estado", string.IsNullOrWhiteSpace(p.estado) ? "ACTIVO" : p.estado);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void editarDatos(Proveedor p)
        {
            using (SqlConnection cn = conexion.establecerConexion())
            {
                cn.Open();

                string consulta = @"
                                    UPDATE Proveedor 
                                    SET Nombre = @Nombre,
                                        Ruc = @Ruc,
                                        Direccion = @Direccion,
                                        Estado = @Estado 
                                    WHERE IdProveedor = @IdProveedor;";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", p.nombre);
                    cmd.Parameters.AddWithValue("@Ruc",
                        string.IsNullOrWhiteSpace(p.ruc) ? (object)DBNull.Value : p.ruc);
                    cmd.Parameters.AddWithValue("@Direccion",
                        string.IsNullOrWhiteSpace(p.direccion) ? (object)DBNull.Value : p.direccion);
                    cmd.Parameters.AddWithValue("@Estado",
                        string.IsNullOrWhiteSpace(p.estado) ? "ACTIVO" : p.estado);
                    cmd.Parameters.AddWithValue("@IdProveedor", p.idProveedor);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
