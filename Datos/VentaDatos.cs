using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class VentaDatos
    {
        private ConexionDB conexion = new ConexionDB();
        public DataTable listarProductosConStock()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = conexion.establecerConexion())
            {
                cn.Open();

                string consulta = @"
                    SELECT  p.IdProducto,
                            p.Nombre,
                            p.PrecioVenta,
                            ISNULL(i.Stock, 0) AS Stock
                    FROM Productos p
                    LEFT JOIN Inventario i ON p.IdProducto = i.IdProducto
                    WHERE p.Estado = 'ACTIVO';";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }
            return tabla;
        }

        public DataTable listarMetodosPago()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = conexion.establecerConexion())
            {
                cn.Open();

                string consulta = @"SELECT IdMetodoPago, Nombre FROM MetodoPago;";

                using (SqlCommand cmd = new SqlCommand(consulta, cn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }

            return tabla;
        }

        public int registrarVenta(int idEmpleado, int? idCliente, int idMetodoPago, decimal subtotal, decimal descuento, decimal total, List<DetalleVentaEntidad> detalles)
        {
            using (SqlConnection cn = conexion.establecerConexion())
            {
                cn.Open();
                using (SqlTransaction tran = cn.BeginTransaction()) { 
                    try
                    {
                        string insertVenta = @"
                            INSERT INTO Venta 
                                (Fecha, IdEmpleado, IdCliente, IdMetodoPago, 
                                 Subtotal, Descuento, Total, Estado) 
                            VALUES 
                                (GETDATE(), @IdEmpleado, @IdCliente, @IdMetodoPago,
                                 @Subtotal, @Descuento, @Total, 'COMPLETADO'); 
                            SELECT SCOPE_IDENTITY();";
                    

                        int idVenta;

                        using (SqlCommand cmdVenta = new SqlCommand(insertVenta, cn, tran))
                        {
                            cmdVenta.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                            if (idCliente.HasValue)
                            {
                                cmdVenta.Parameters.AddWithValue("@IdCliente", idCliente.Value);
                            }
                            else
                            {
                                cmdVenta.Parameters.AddWithValue("@IdCliente", DBNull.Value);
                            }
                            cmdVenta.Parameters.AddWithValue("@IdMetodoPago", idMetodoPago);
                            cmdVenta.Parameters.AddWithValue("@Subtotal", subtotal);
                            cmdVenta.Parameters.AddWithValue("@Descuento", descuento);
                            cmdVenta.Parameters.AddWithValue("@Total", total);

                            idVenta = Convert.ToInt32(cmdVenta.ExecuteScalar());
                        }

                        string insertDetalle = @"
                            INSERT INTO DetalleVenta 
                                (IdVenta, IdProducto, Cantidad, PrecioUnitario) 
                            VALUES 
                                (@IdVenta, @IdProducto, @Cantidad, @PrecioUnitario);";

                        string updateStock = @"
                            UPDATE Inventario 
                            SET Stock = Stock - @Cantidad, FechaActualizacion = GETDATE() 
                            WHERE IdProducto = @IdProducto;";

                        foreach (var d in detalles)
                        {
                            //detalle
                            using (SqlCommand cmdDetalle = new SqlCommand(insertDetalle, cn, tran))
                            {
                                cmdDetalle.Parameters.AddWithValue("@IdVenta", idVenta);
                                cmdDetalle.Parameters.AddWithValue("@IdProducto", d.idProducto);
                                cmdDetalle.Parameters.AddWithValue("@Cantidad", d.cantidad);
                                cmdDetalle.Parameters.AddWithValue("@PrecioUnitario", d.precioUnitario);
                                cmdDetalle.ExecuteNonQuery();
                            }

                            //stock
                            using (SqlCommand cmdStock = new SqlCommand(updateStock, cn, tran))
                            {
                                cmdStock.Parameters.AddWithValue("@IdProducto", d.idProducto);
                                cmdStock.Parameters.AddWithValue("@Cantidad", d.cantidad);
                                cmdStock.ExecuteNonQuery();
                            }
                        }

                        tran.Commit();
                        return idVenta;
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
