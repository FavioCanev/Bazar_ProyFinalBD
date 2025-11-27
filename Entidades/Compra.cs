using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Compra
    {
        public int idCompra { get; set; }
        public int idProveedor { get; set; }
        public int idEmpleado { get; set; }
        public DateTime fecha { get; set; }
        public decimal subtotal { get; set; }
        public string total { get; set; }
        public string estado { get; set; }
        
        //Constructores
        public Compra(int idCompra, int idProveedor, int idEmpleado, DateTime fecha, decimal subtotal, string total, string estado)
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
