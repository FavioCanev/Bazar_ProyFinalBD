using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class UsuarioDatos
    {
        private ConexionDB conexion = new ConexionDB();

        public Usuario Login(string nombreUsuario, string contrasena)
        {
            Usuario usuarioEncontrado = null;
            using (SqlConnection cn = conexion.establecerConexion())
            {
                cn.Open();
                //Consulta sql para verificar el usuario
                string consulta = "SELECT IdUsuario, NombreUsuario, Contrasena, IdEmpleado, ISNULL(Bloqueado, 0) AS Bloqueado, ISNULL (FechaCreacion, GETDATE()) AS              Fechacreacion " +
                                  "FROM Usuarios " +
                                  "WHERE NombreUsuario= @NombreUsuario AND Contrasena = @Contrasena"; //consejo: poner bien los espacios en la consulta para evitar errores

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuarioEncontrado = new Usuario
                            {
                                idUsuario = Convert.ToInt32(reader["IdUsuario"]),
                                nombreUsuario = reader["NombreUsuario"].ToString(),
                                contrasenaUsuario = reader["Contrasena"].ToString(),
                                idEmpleado = Convert.ToInt32(reader["IdEmpleado"]),
                                bloqueado = Convert.ToBoolean(reader["Bloqueado"]), //arreglar esto, tuve que cambiar el tipo de dato de Bloqueado de string a bool porque en la bd está como bit
                                fechaCreacion = Convert.ToDateTime(reader["FechaCreacion"])
                            };
                        }
                    }
                }
                return usuarioEncontrado;
            }
        }


        public DataTable listarUsuarios()
        {
            DataTable tablaUsuarios = new DataTable();

            using (SqlConnection cn = conexion.establecerConexion())
            {
                cn.Open();
                string consulta1 = @"
                        SELECT  u.IdUsuario,
                        u.NombreUsuario,
                        (e.Nombre + ' ' + e.ApellidoPaterno + ' ' + e.ApellidoMaterno) AS Empleado,
                        r.Nombre AS Rol,
                        u.Bloqueado
                        FROM Usuarios u
                        INNER JOIN Empleados e ON u.IdEmpleado = e.IdEmpleado
                        INNER JOIN Roles r ON e.IdRol = r.IdRol;";

                using (SqlCommand cmd = new SqlCommand(consulta1, cn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(tablaUsuarios);
                    }
                }
            }
            return tablaUsuarios;
        }

        public void insertar(Usuario u)
        {
            using (SqlConnection cn = conexion.establecerConexion())
            {
                cn.Open();

                string consulta = @"INSERT INTO Usuarios (NombreUsuario, Contrasena, IdEmpleado, Bloqueado, FechaCreacion)
                VALUES (@usuario, @contrasena, @idEmpleado, @bloqueado, GETDATE());";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("@usuario", u.nombreUsuario);
                    cmd.Parameters.AddWithValue("@contrasena", u.contrasenaUsuario);
                    cmd.Parameters.AddWithValue("@idEmpleado", u.idEmpleado);
                    cmd.Parameters.AddWithValue("@bloqueado", u.bloqueado);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void actualizarBloqueado(int idUsuario, bool bloqueado)
        {
            using (SqlConnection cn = conexion.establecerConexion())
            {
                cn.Open();

                string consulta = @"UPDATE Usuarios 
                                  SET Bloqueado = @bloqueado 
                                  WHERE IdUsuario = @idUsuario;";

                using(SqlCommand cmd = new SqlCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("@bloqueado", bloqueado);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
