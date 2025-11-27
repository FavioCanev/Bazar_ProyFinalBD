using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class DetalleDevolucion
    {
        private int idDetalleDevolucion { get; set; }
        private int idDevolucion { get; set; }
        private int idProducto { get; set; }
        private double cantidad { get; set; }

        //Constructores
        public DetalleDevolucion(int idDetalleDevolucion, int idDevolucion, int idProducto, double cantidad)
        {
            this.idDetalleDevolucion = idDetalleDevolucion;
            this.idDevolucion = idDevolucion;
            this.idProducto = idProducto;
            this.cantidad = cantidad;
        }
        public DetalleDevolucion() { }
    }
}
