using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        public int idVenta { get; set; }
        public int idEmpleado { get; set; }
        public decimal idCliente { get; set; }
        public int idMetodoPago { get; set; }
        public DateTime fecha { get; set; }
        public decimal subtotal { get; set; }
        public decimal descuento { get; set; }
        public decimal total { get; set; }
        public decimal estado { get; set; }

        //Constructores
        public Venta(int idVenta, int idEmpleado, decimal idCliente, int idMetodoPago, DateTime fecha, decimal subtotal, decimal descuento, decimal total, decimal estado)
        {
            this.idVenta = idVenta;
            this.idEmpleado = idEmpleado;
            this.idCliente = idCliente;
            this.idMetodoPago = idMetodoPago;
            this.fecha = fecha;
            this.subtotal = subtotal;
            this.descuento = descuento;
            this.total = total;
            this.estado = estado;
        }
        public Venta() { }
    }
}
