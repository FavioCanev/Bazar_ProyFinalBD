using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class MovimientosDatos
    {
        private ConexionDB conexion = new ConexionDB();

        public DataTable listarVentas()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = conexion.establecerConexion())
            {
                cn.Open();

                string consulta = @"
                SELECT  dv.IdDetalleVenta,
                        v.Fecha,
                        p.Nombre AS Producto,
                        dv.Cantidad,
                        dv.PrecioUnitario,
                        (dv.Cantidad * dv.PrecioUnitario) AS Importe,
                        e.Nombre + ' ' + e.ApellidoPaterno + ' ' + e.ApellidoMaterno AS Empleado
                FROM DetalleVenta dv
                INNER JOIN Venta v       ON dv.IdVenta    = v.IdVenta
                INNER JOIN Productos p   ON dv.IdProducto = p.IdProducto
                INNER JOIN Empleados e   ON v.IdEmpleado  = e.IdEmpleado;";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        public DataTable listarCompras()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = conexion.establecerConexion())
            {
                cn.Open();

                string consulta = @"
                SELECT  dc.IdDetalleCompra,
                        c.Fecha,
                        p.Nombre AS Producto,
                        dc.Cantidad,
                        dc.PrecioUnitario,
                        (dc.Cantidad * dc.PrecioUnitario) AS Importe,
                        e.Nombre + ' ' + e.ApellidoPaterno + ' ' + e.ApellidoMaterno AS Empleado
                FROM DetalleCompra dc
                INNER JOIN Compra c      ON dc.IdCompra   = c.IdCompra
                INNER JOIN Productos p   ON dc.IdProducto = p.IdProducto
                INNER JOIN Empleados e   ON c.IdEmpleado  = e.IdEmpleado;";

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
