using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleDevolucion
    {
        public int idDetalleDevolucion { get; set; }
        public int idDevolucion { get; set; }
        public int idProducto { get; set; }
        public decimal cantidad { get; set; }

        //Constructores
        public DetalleDevolucion(int idDetalleDevolucion, int idDevolucion, int idProducto, decimal cantidad)
        {
            this.idDetalleDevolucion = idDetalleDevolucion;
            this.idDevolucion = idDevolucion;
            this.idProducto = idProducto;
            this.cantidad = cantidad;
        }
        public DetalleDevolucion() { }
    }
}
