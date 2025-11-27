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
        static string servidor = "localhost";
        static string bd = "Bazar";
        static string usuario = "BazarUser";
        static string contraseña = "ContraseñaUltrasegura123";
        static string puerto = "49678"; //un lío tremendo para encontrar y conectar el puerto


        //juntarlo todo en un string para mandarlo al objeto de tipo SQLConnection en el atributo ConnectionString
        string cadenaConexion = "Data Source =" + servidor + "," + puerto + ";" + "user id=" + usuario + ";" + "password=" + contraseña + ";" + "Initial Catalog=" + bd + ";" + "Persist Security Info=true";



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
    }
}
