using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleVenta
    {
        public int idDetalleVenta { get; set; }
        public int idVenta { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public decimal precioUnitario { get; set; }

        //Constructores
        public DetalleVenta(int idDetalleVenta, int idVenta, int idProducto, int cantidad, decimal precioUnitario)
        {
            this.idDetalleVenta = idDetalleVenta;
            this.idVenta = idVenta;
            this.idProducto = idProducto;
            this.cantidad = cantidad;
            this.precioUnitario = precioUnitario;
        }
        public DetalleVenta() { }
    }
}
