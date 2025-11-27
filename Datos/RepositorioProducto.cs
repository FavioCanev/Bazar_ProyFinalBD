using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using System.Security.Policy;

namespace Datos
{
    public class RepositorioProducto
    {
        public List<Producto> listar()
        {
            var lista = new List<Producto>();

            using (var cn = ConexionDB.obtenerConexion())
            using (var cmd = new SqlCommand(
                @"SELECT IdProducto, IdCategoria, IdMarca, IdProveedor,
                         Nombre, Caracteristica, UnidadMedida,
                         PrecioCompra, PrecioVenta, Estado, FechaRegistro
                  FROM Productos", cn))
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    lista.Add(new Producto
                    {
                        idProducto = dr.GetInt32(0),
                        idCategoria = dr.GetInt32(1),
                        idMarca = dr.GetInt32(2),
                        idProveedor = dr.GetInt32(3),
                        nombre = dr.GetString(4),
                        caracteristica = dr.GetString(5),
                        unidadMedida = dr.GetString(6),
                        precioCompra = dr.GetDecimal(7),
                        precioVenta = dr.GetDecimal(8),
                        estado = dr.GetString(9),
                        fechaRegistro = dr.GetDateTime(10)
                    });
                }
            }
            return lista;
        }


        public bool insertar(Producto p)
        {
            using (var cn = ConexionDB.obtenerConexion())
            using (var cmd = new SqlCommand(
               @"INSERT INTO Productos
                (IdCategoria, IdMarca, IdProveedor, Nombre, Caracteristica,
                 UnidadMedida, PrecioCompra, PrecioVenta, Estado, FechaRegistro)
             VALUES
                (@cat, @marca, @prov, @nom, @car, @uni, @pc, @pv, @est, GETDATE())", cn))
            {
                cmd.Parameters.AddWithValue("@cat", p.idCategoria);
                cmd.Parameters.AddWithValue("@marca", p.idMarca);
                cmd.Parameters.AddWithValue("@prov", p.idProveedor);
                cmd.Parameters.AddWithValue("@nom", p.nombre);
                cmd.Parameters.AddWithValue("@car", p.caracteristica);
                cmd.Parameters.AddWithValue("@uni", p.unidadMedida);
                cmd.Parameters.AddWithValue("@pc", p.precioCompra);
                cmd.Parameters.AddWithValue("@pv", p.precioVenta);
                cmd.Parameters.AddWithValue("@est", p.estado);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool actualizar(Producto p)
        {
            using (var cn = ConexionDB.obtenerConexion())
            using (var cmd = new SqlCommand(
                @"UPDATE Productos SET
                IdCategoria = @cat,
                IdMarca     = @marca,
                IdProveedor = @prov,
                Nombre      = @nom,
                Caracteristica = @car,
                UnidadMedida  = @uni,
                PrecioCompra  = @pc,
                PrecioVenta   = @pv,
                Estado        = @est
            WHERE IdProducto = @id", cn))
            {
                cmd.Parameters.AddWithValue("@id", p.idProducto);
                cmd.Parameters.AddWithValue("@cat", p.idCategoria);
                cmd.Parameters.AddWithValue("@marca", p.idMarca);
                cmd.Parameters.AddWithValue("@prov", p.idProveedor);
                cmd.Parameters.AddWithValue("@nom", p.nombre);
                cmd.Parameters.AddWithValue("@car", p.caracteristica);
                cmd.Parameters.AddWithValue("@uni", p.unidadMedida);
                cmd.Parameters.AddWithValue("@pc", p.precioCompra);
                cmd.Parameters.AddWithValue("@pv", p.precioVenta);
                cmd.Parameters.AddWithValue("@est", p.estado);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool eliminar(int idProducto)
        {
            using (var cn = ConexionDB.obtenerConexion())
            using (var cmd = new SqlCommand(
                @"DELETE FROM Productos WHERE IdProducto = @id", cn))
            {
                cmd.Parameters.AddWithValue("@id", idProducto);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
