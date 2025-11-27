using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Venta
    {
        private int idVenta { get; set; }
        private int idEmpleado { get; set; }
        private decimal idCliente { get; set; }
        private int idMetodoPago { get; set; }
        private DateTime fecha { get; set; }
        private double subtotal { get; set; }
        private double descuento { get; set; }
        private double total { get; set; }
        private double estado { get; set; }

        //Constructores
        public Venta(int idVenta, int idEmpleado, decimal idCliente, int idMetodoPago, DateTime fecha, double subtotal, double descuento, double total, double estado)
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
