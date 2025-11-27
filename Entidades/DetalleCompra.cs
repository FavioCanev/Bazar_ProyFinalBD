using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleCompra
    {
        public int idDetalleCompra { get; set; }
        public int idCompra { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public decimal precioUnitario { get; set; }

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
