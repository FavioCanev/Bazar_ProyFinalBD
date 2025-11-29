using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
                                bloqueado = reader["Bloqueado"].ToString(),
                                fechaCreacion = Convert.ToDateTime(reader["FechaCreacion"])
                            };
                        }
                    }
                }
                return usuarioEncontrado;
            }
        }
    }
}
