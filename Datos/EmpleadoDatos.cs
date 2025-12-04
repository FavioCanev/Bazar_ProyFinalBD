using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class EmpleadoDatos
    {
        private ConexionDB conexion = new ConexionDB();
        public DataTable ListarSinUsuarios()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = conexion.establecerConexion())
            {
                cn.Open();

                string consulta = @"SELECT e.IdEmpleado,
                       (e.Nombre + ' ' + e.ApellidoPaterno + ' ' + e.ApellidoMaterno) AS Empleado
                FROM Empleados e
                WHERE e.IdEmpleado NOT IN (
                    SELECT u.IdEmpleado FROM Usuarios u
                );";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        public void insertar(Empleado e)
        {
            using (SqlConnection cn = conexion.establecerConexion())
            {
                cn.Open();

                string consulta = @"INSERT INTO Empleados 
                                    (Nombre, ApellidoPaterno, ApellidoMaterno, Dni, Telefono, Sueldo, IdRol, Estado, FechaContratacion) 
                                    VALUES 
                                    (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Dni, @Telefono, @Sueldo, @IdRol, @Estado, @FechaContratacion);";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", e.nombre);
                    cmd.Parameters.AddWithValue("@ApellidoPaterno", e.apellidoPaterno);
                    cmd.Parameters.AddWithValue("@ApellidoMaterno", e.apellidoMaterno);
                    cmd.Parameters.AddWithValue("@Dni", e.dni);
                    cmd.Parameters.AddWithValue("@Telefono", e.telefono);
                    cmd.Parameters.AddWithValue("@Sueldo", e.sueldo); //puede que me pida convert to decimal
                    cmd.Parameters.AddWithValue("@IdRol", e.idRol);
                    cmd.Parameters.AddWithValue("@Estado", e.estado);
                    cmd.Parameters.AddWithValue("@FechaContratacion", e.fechaContratacion);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable listarRoles()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = conexion.establecerConexion())
            {
                cn.Open();
                string consulta = "SELECT IdRol, Nombre FROM Roles;";
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
