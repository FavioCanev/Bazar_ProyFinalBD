using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class DetalleCompra
    {
        private int idDetalleCompra { get; set; }
        private int idCompra { get; set; }
        private int idProducto { get; set; }
        private int cantidad { get; set; }
        private decimal precioUnitario { get; set; }

        //Constructores
        public DetalleCompra(int idDetalleCompra, int idCompra, int idProducto, int cantidad, decimal precioUnitario)
        {
            this.idDetalleCompra = idDetalleCompra;
            this.idCompra = idCompra;
            this.idProducto = idProducto;
            this.cantidad = cantidad;
            this.precioUnitario = precioUnitario;
        }
        public DetalleCompra() { }
    }
}
