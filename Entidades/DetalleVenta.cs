using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class DetalleVenta
    {
        private int idDetalleVenta { get; set; }
        private int idVenta { get; set; }
        private int idProducto { get; set; }
        private int cantidad { get; set; }
        private double precioUnitario { get; set; }

        //Constructores
        public DetalleVenta(int idDetalleVenta, int idVenta, int idProducto, int cantidad, double precioUnitario)
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
