using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //para la conexión a la bd

namespace Datos
{
    public class ConexionDB
    {
        //datos de la conexión
        SqlConnection conex = new SqlConnection();
        private static string servidor = "localhost";
        private static string bd = "Bazar";
        private static string usuario = "BazarUser";
        private static string contraseña = "ContraseñaUltrasegura123";
        private static string puerto = "49678"; //un lío tremendo para encontrar y conectar el puerto


        //juntarlo todo en un string para mandarlo al objeto de tipo SQLConnection en el atributo ConnectionString
        private static string cadenaConexion = "Data Source =" + servidor + "," + puerto + ";" + "user id=" + usuario + ";" + "password=" + contraseña + ";" + "Initial Catalog=" + bd + ";" + "Persist Security Info=true";


        //lo hice con un tutorial de yt
        public SqlConnection establecerConexion()
        {
            //atrapamos los posibles errores o mandamos un mensaje de éxito
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                Console.WriteLine("Se conectó correctamente a la BD");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error de conexión con la BD" + e.ToString());
            }
            return conex;
        }


        //sugerencia del chad dizque para no dejar la conexión abierta, sino estática y reutilizable y así poder abrirla en cada repositorio
        public static SqlConnection obtenerConexion()
        {
            var cn = new SqlConnection(cadenaConexion);
            cn.Open();
            return cn;
        }
    }
}
