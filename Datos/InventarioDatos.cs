using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class InventarioDatos
    {
        private ConexionDB conexion = new ConexionDB();

        public DataTable listarInventario()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = conexion.establecerConexion())
            {
                cn.Open();
                string consulta = @"
                SELECT  p.IdProducto,
                        p.Nombre,
                        p.Caracteristica,
                        p.UnidadMedida,
                        c.Nombre AS Categoria,
                        m.Nombre AS Marca,
                        ISNULL(i.Stock, 0) AS Stock,
                        p.PrecioCompra,
                        p.PrecioVenta,
                        p.Estado 
                FROM Productos p 
                INNER JOIN Categorias c ON p.IdCategoria = c.IdCategoria 
                INNER JOIN Marcas m ON p.IdMarca = m.IdMarca 
                LEFT JOIN Inventario i ON p.IdProducto = i.IdProducto;";

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
