using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Compra
    {
        private int idCompra { get; set; }
        private int idProveedor { get; set; }
        private int idEmpleado { get; set; }
        private DateTime fecha { get; set; }
        private double subtotal { get; set; }
        private string total { get; set; }
        private string estado { get; set; }
        
        //Constructores
        public Compra(int idCompra, int idProveedor, int idEmpleado, DateTime fecha, double subtotal, string total, string estado)
        {
            this.idCompra = idCompra;
            this.idProveedor = idProveedor;
            this.idEmpleado = idEmpleado;
            this.fecha = fecha;
            this.subtotal = subtotal;
            this.total = total;
            this.estado = estado;
        }
        public Compra() { }
    }
}
