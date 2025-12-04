using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleVentaEntidad
    {
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public decimal precioUnitario { get; set; }


        //constructores
        public DetalleVentaEntidad(int idProducto, int cantidad, decimal precioUnitario)
        {
            this.idProducto = idProducto;
            this.cantidad = cantidad;
            this.precioUnitario = precioUnitario;
        }
        public DetalleVentaEntidad() { }

    }
}
